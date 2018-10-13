using System.Runtime.Serialization;

namespace NCVFirstComment
{
    /// <summary>
    /// アプリデータクラス
    /// </summary>
    public partial class AppConfig
    {
        /// <summary>
        /// フォームの設定クラス
        /// </summary>
        [DataContract]
        public class FormConfig
        {
            /// <summary>[CheckBox] 運営コメントは除外</summary>
            [DataMember]
            public bool excludeOwnerComment { get; set; }
            /// <summary>[CheckBox] No1が運営コメントだった場合、No2を1Get処理する</summary>
            [DataMember]
            public bool No2AsNo1Comment { get; set; }
            /// <summary>[CheckBox] 返信コメントをする</summary>
            [DataMember]
            public bool ReplyCommentToggle { get; set; }
            /// <summary>[TextkBox] 返信コメント</summary>
            [DataMember]
            public string ReplyCommentText { get; set; }
        }
    }
}