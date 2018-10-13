using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace NCVFirstComment
{
    public partial class AppConfig
    {
        /// <summary>
        /// 履歴データクラス
        /// </summary>
        [DataContract]
        public class HistoryData : INotifyPropertyChanged
        {
            /// <summary>ユーザID</summary>
            [DataMember(Name = "UserId")]
            private string _UserId;
            [DisplayName("ユーザID")]
            public string UserId
            {
                get => _UserId;
                set
                {
                    _UserId = value;
                    NotifyPropertyChanged();

                }
            }

            /// <summary>コテハン</summary>
            [DataMember(Name = "NickName")]
            private string _NickName;
            [DisplayName("コテハン")]
            public string NickName
            {
                get => _NickName;
                set
                {
                    _NickName = value;
                    NotifyPropertyChanged();
                }
            }

            /// <summary>取得回数</summary>
            [DataMember(Name = "AcquisitionCount")]
            private int _AcquisitionCount;
            [DisplayName("取得回数")]
            public int AcquisitionCount
            {
                get => _AcquisitionCount;
                set
                {
                    _AcquisitionCount = value;
                    NotifyPropertyChanged();
                }
            }

            /// <summary>登録日</summary>
            [DataMember(Name = "RegisterDate")]
            private DateTime _RegisterDate;
            [DisplayName("登録日")]
            public DateTime RegisterDate
            {
                get => _RegisterDate;
                set
                {
                    _RegisterDate = value;
                    NotifyPropertyChanged();
                }
            }


            // 値変更イベント
            public event PropertyChangedEventHandler PropertyChanged;
            private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
                => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}