using Plugin;
using System;
using System.Linq;
using System.Windows.Forms;
using static NCVFirstComment.AppConfig;

namespace NCVFirstComment
{
    public partial class MainForm : Form
    {
        /// <summary>ホスト</summary>
        private IPluginHost _Host = null;
        /// <summary>履歴データ</summary>
        private SortableBindingList<HistoryData> _HistoryDataList = null;

        /// <summary>最後に接続していた放送ID</summary>
        private string _LastLiveId = "";


        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="host">プラグインホスト</param>
        public MainForm(IPluginHost host)
        {
            InitializeComponent();

            _Host = host;

            // フォームデータ読み込み
            FormConfig formConfig = AppConfigIO.LoadFormData(_Host.DirectoryPathAppSetting);
            if (formConfig != null)
            {
                excludeOwnerComment.Checked = formConfig.excludeOwnerComment;
                No2AsNo1Comment.Checked = formConfig.No2AsNo1Comment;
                ReplyCommentToggle.Checked = formConfig.ReplyCommentToggle;
                ReplyCommentTextBox.Text = formConfig.ReplyCommentText;
            }
            // 履歴データ読み込み
            _HistoryDataList = AppConfigIO.LoadHistoryData(_Host.DirectoryPathAppSetting);
            HistoryView.DataSource = _HistoryDataList;

            // イベント設定
            _Host.ReceivedComment += new ReceivedCommentEventHandler(_Host_ReceivedComment);
        }

        /// <summary>
        /// コメント受信時に発生するイベントメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _Host_ReceivedComment(object sender, ReceivedCommentEventArgs e)
        {
            try
            {
                // 多重処理防止
                if (_LastLiveId == _Host.GetPlayerStatus().LiveNum)
                {
                    return;
                }
                _LastLiveId = _Host.GetPlayerStatus().LiveNum;

                // インデックスチェック
                int commentLastIndex = e.CommentDataList.Count - 1;
                if (commentLastIndex < 0)
                {
                    return;
                }

                // 放送主時以外の受信は無視
                if (!_Host.GetPlayerStatus().Stream.IsOwner.Equals("1"))
                {
                    return;
                }

                // [設定] 運営コメントは無視
                var ownerFlag = NicoLibrary.NicoLiveData.PremiumFlags.Premium | NicoLibrary.NicoLiveData.PremiumFlags.ServerComment;
                if (excludeOwnerComment.Checked && ((e.CommentDataList[commentLastIndex].PremiumBits & (ownerFlag)) == ownerFlag))
                {
                    return;
                }

                // [設定] No1のコメントが運営コメントの場合、No2を1Get処理する
                if (No2AsNo1Comment.Checked && commentLastIndex == 1)
                {
                    if ((e.CommentDataList[0].PremiumBits & (ownerFlag)) != ownerFlag)
                    {
                        // No1が運営コメントではない
                        return;
                    }
                }
                // No1のコメント以外は無視
                else if (!e.CommentDataList[commentLastIndex].No.Equals("1"))
                {
                    return;
                }


                string userId = e.CommentDataList[commentLastIndex].UserId;
                string nickname = _Host.GetUserSettingInPlugin().UserDataList.Find(x => x.UserId == e.CommentDataList[e.CommentDataList.Count - 1].UserId)?.NickName;
                int acquisitionCount = 1;

                HistoryData historyData = _HistoryDataList.FirstOrDefault(x => x.UserId.Equals(userId));
                if (historyData == null)
                {
                    // 新規登録
                    historyData = new HistoryData
                    {
                        UserId = userId,
                        NickName = nickname,
                        AcquisitionCount = 1,
                        RegisterDate = DateTime.Now
                    };
                    _HistoryDataList.Add(historyData);
                }
                else
                {
                    // 更新
                    historyData.NickName = nickname;
                    historyData.AcquisitionCount += 1;

                    acquisitionCount = historyData.AcquisitionCount;
                }

                // 運営コメント送信有無
                if (!ReplyCommentToggle.Checked)
                {
                    return;
                }

                // 運営コメント編集
                string ownerComment = ReplyCommentTextBox.Text;
                ownerComment = ownerComment.Replace("{Nickname}", !string.IsNullOrEmpty(nickname) ? nickname : "名無し")
                    .Replace("{Count}", acquisitionCount.ToString());


                // 運営コメント送信
                _Host.SendOwnerComment(ownerComment);
            }
            catch
            {
                // TODO: 例外処理
                // 報告しやすい（してもらいやすい）形式で出力する
            }
        }

        /// <summary>
        /// Formが閉じられる時に発生するイベントメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
                return;
            }

            // フォームデータ保存
            FormConfig formConfig = new FormConfig
            {
                excludeOwnerComment = excludeOwnerComment.Checked,
                No2AsNo1Comment = No2AsNo1Comment.Checked,
                ReplyCommentToggle = ReplyCommentToggle.Checked,
                ReplyCommentText = ReplyCommentTextBox.Text
            };
            AppConfigIO.SaveFormData(_Host.DirectoryPathAppSetting, formConfig);
            // 履歴データ保存
            AppConfigIO.SaveHistoryData(_Host.DirectoryPathAppSetting, _HistoryDataList);
        }

        /// <summary>
        /// 返信コメント送信ON/OFFのチェックボックスのチェック状態変更時のイベントメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReplyCommentToggle_CheckedChanged(object sender, EventArgs e)
        {
            ReplyCommentTextBox.Enabled = ReplyCommentToggle.Checked;
        }

        /// <summary>
        /// 検索ボタン押下イベントメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBotton_Click(object sender, EventArgs e)
        {
            if (_HistoryDataList.Count < 0)
            {
                return;
            }

            if (!_HistoryDataList.Any(x => x.NickName.Equals(HistorySearchTextBox.Text)))
            {
                MessageBox.Show("ヒットするデータがありませんでした", "履歴検索", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 該当データのインデックス取得
            int hitIndex = _HistoryDataList.Select((item, index) => new { Value = item, Index = index })
                .Where(x => x.Value.NickName.Equals(HistorySearchTextBox.Text))
                .Select(item => item.Index)
                .FirstOrDefault();

            // 選択
            HistoryView[0, hitIndex].Selected = true;
            HistoryView.FirstDisplayedScrollingRowIndex = hitIndex;
        }

        /// <summary>
        /// 履歴データ削除ボタン押下イベントメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int? curIndex = HistoryView.CurrentCell?.RowIndex;
            if (curIndex == null)
            {
                return;
            }

            if (MessageBox.Show("選択したデータを削除します", "履歴データ削除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }

            _HistoryDataList.RemoveAt((int)curIndex);
        }
    }
}