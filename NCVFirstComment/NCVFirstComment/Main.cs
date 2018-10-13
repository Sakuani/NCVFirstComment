using Plugin;

namespace NCVFirstComment
{
    public class Main : IPluginEx
    {
        private IPluginHost _Host = null;    // ホスト
        private MainForm _MainForm = null;   // メインフォーム

        /// <summary>プラグイン名</summary>
        public string Name => "NCVFirstComment";

        /// <summary>プラグインの説明</summary>
        public string Description => System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileDescription;

        /// <summary>ホスト</summary>
        public IPluginHost Host
        {
            get => _Host;
            set
            {
                _Host = value;
                _MainForm = new MainForm(value);
            }
        }

        /// <summary>設定フォーム有無</summary>
        public bool HasSettingForm => false;
        /// <summary>設定フォーム呼び出し時の処理</summary>
        public void ShowSettingForm()
        {

        }

        /// <summary>自動実行フラグ</summary>
        public bool IsAutoRun => true;
        /// <summary>自動実行時の処理</summary>
        public void AutoRun()
        {

        }

        /// <summary>プラグイン実行時の処理</summary>
        public void Run()
        {
            _MainForm.Show(_Host.MainForm);
        }

        /// <summary>プラグインのバージョン</summary>
        public string Version => System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
    }
}