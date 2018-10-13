using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using static NCVFirstComment.AppConfig;

namespace NCVFirstComment
{
    /// <summary>
    /// アプリデータ入出力クラス
    /// </summary>
    public class AppConfigIO
    {
        /// <summary>保存フォルダ名</summary>
        private static readonly string SETTING_FOLDER_NAME = "NCVFirstComment";
        /// <summary>フォームデータファイル名</summary>
        private static readonly string FORM_DATA_FILE_NAME = "form-data.json";
        /// <summary>履歴データファイル名</summary>
        private static readonly string HISTORY_DATA_FILE_NAME = "history-data.json";


        /// <summary>
        /// フォームデータ読み込み
        /// </summary>
        /// <param name="saveDirectoryPath">保存先パス</param>
        /// <returns>フォームデータ</returns>
        public static FormConfig LoadFormData(string saveDirectoryPath)
        {
            string filePath = $"{saveDirectoryPath}\\{SETTING_FOLDER_NAME}\\{FORM_DATA_FILE_NAME}";

            // ファイルの存在チェック
            if (!File.Exists(filePath))
            {
                return null;
            }

            try
            {
                using (var fs = new FileStream(filePath, FileMode.Open))
                {
                    DataContractJsonSerializerSettings serSetting = new DataContractJsonSerializerSettings
                    {
                        UseSimpleDictionaryFormat = true,
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd HH:mm:ss")
                    };
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(FormConfig), serSetting);

                    return (FormConfig)ser.ReadObject(fs);
                }
            }
            catch
            {
                // TODO: 例外処理
                // 報告しやすい（してもらいやすい）形式で出力する

                return null;
            }
        }

        /// <summary>
        /// フォームデータ保存
        /// </summary>
        /// <param name="saveDirectoryPath">保存先パス</param>
        /// <param name="formConfig">フォームデータ</param>
        /// <returns></returns>
        public static bool SaveFormData(string saveDirectoryPath, FormConfig formConfig)
        {
            string settingDirectory = $"{saveDirectoryPath}\\{SETTING_FOLDER_NAME}";
            string filePath = $"{settingDirectory}\\{FORM_DATA_FILE_NAME}";

            try
            {
                // フォルダ生成
                if (!Directory.Exists(settingDirectory))
                {
                    Directory.CreateDirectory(settingDirectory);
                }


                using (var fs = new FileStream(filePath, FileMode.Create))
                using (var jw = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, true, true, "    "))
                {
                    DataContractJsonSerializerSettings serSetting = new DataContractJsonSerializerSettings
                    {
                        UseSimpleDictionaryFormat = true,
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd HH:mm:ss")
                    };
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(FormConfig), serSetting);

                    ser.WriteObject(jw, formConfig);
                    jw.Flush();
                }
            }
            catch
            {
                // TODO: 例外処理
                // 報告しやすい（してもらいやすい）形式で出力する

                return false;
            }

            return true;
        }

        /// <summary>
        /// 履歴データ読み込み
        /// </summary>
        /// <param name="saveDirectoryPath">保存先パス</param>
        /// <returns>履歴データ</returns>
        public static SortableBindingList<HistoryData> LoadHistoryData(string saveDirectoryPath)
        {
            string filePath = $"{saveDirectoryPath}\\{SETTING_FOLDER_NAME}\\{HISTORY_DATA_FILE_NAME}";

            // ファイルの存在チェック
            if (!File.Exists(filePath))
            {
                return new SortableBindingList<HistoryData>();
            }

            try
            {
                using (var fs = new FileStream(filePath, FileMode.Open))
                {
                    DataContractJsonSerializerSettings serSetting = new DataContractJsonSerializerSettings
                    {
                        UseSimpleDictionaryFormat = true,
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd HH:mm:ss")
                    };
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SortableBindingList<HistoryData>), serSetting);

                    return (SortableBindingList<HistoryData>)ser.ReadObject(fs);
                }
            }
            catch
            {
                // TODO: 例外処理
                // 報告しやすい（してもらいやすい）形式で出力する

                return new SortableBindingList<HistoryData>();
            }
        }

        /// <summary>
        /// 履歴データ保存
        /// </summary>
        /// <param name="saveDirectoryPath">保存先パス</param>
        /// <param name="historyDataList">履歴データ</param>
        /// <returns></returns>
        public static bool SaveHistoryData(string saveDirectoryPath, SortableBindingList<HistoryData> historyDataList)
        {
            string settingDirectory = $"{saveDirectoryPath}\\{SETTING_FOLDER_NAME}";
            string filePath = $"{settingDirectory}\\{HISTORY_DATA_FILE_NAME}";

            try
            {
                // フォルダ生成
                if (!Directory.Exists(settingDirectory))
                {
                    Directory.CreateDirectory(settingDirectory);
                }


                using (var fs = new FileStream(filePath, FileMode.Create))
                using (var jw = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, true, true, "    "))
                {
                    DataContractJsonSerializerSettings serSetting = new DataContractJsonSerializerSettings
                    {
                        UseSimpleDictionaryFormat = true,
                        DateTimeFormat = new DateTimeFormat("yyyy-MM-dd HH:mm:ss")
                    };
                    DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(SortableBindingList<HistoryData>), serSetting);

                    ser.WriteObject(jw, historyDataList);
                    jw.Flush();
                }
            }
            catch
            {
                // TODO: 例外処理
                // 報告しやすい（してもらいやすい）形式で出力する

                return false;
            }

            return true;
        }
    }
}