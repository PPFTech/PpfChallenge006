using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Level3
{
    public class FileControl
    {
        // 定数
        private const int CsvCulumnNumber = 2;

        #region "private"
        // プロパティの定義
        private string FilePath;
        private string Encode;
        private List<string> lines = new List<string>();
        public List<string> Lines
        {
            get { return lines; }
            set { lines = value; }
        }

        #endregion

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="filePath">リスト用ファイルパス</param>
        /// <param name="encode">文字エンコード</param>
        public FileControl(string filePath, string encode)
        {
            FilePath = filePath;
            Encode = encode;
        }
        #endregion

        #region "Method"
        /// <summary>
        /// ファイルへの書き込み
        /// </summary>
        /// <param name="lines"></param>
        /// <returns>リスト文字列</returns>
        public string Write(string lines)
        {
            string message = "";
            StreamWriter sw = null;
            try
            {
                //書き込み実行
                Encoding enc = Encoding.GetEncoding(Encode);
                sw = new StreamWriter(FilePath, false, enc);
                sw.Write(lines);
            }
            catch (Exception ex)
            {
                message = "エラー発生：" + ex.Message;
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
            return message;
        }

        /// <summary>
        /// ファイルの内容を読み込んでリストを返却
        /// </summary>
        /// <returns>リスト</returns>
        public string Read()
        {
            string line = "";
            string message = "";
            StreamReader sr = null;
            try
            {
                int count = 0;

                //ファイルを開く
                Encoding enc = Encoding.GetEncoding(Encode);
                sr = new StreamReader(FilePath, enc);
                while (sr.Peek() > -1)
                {
                    count++;

                    // 行読み込み
                    line = sr.ReadLine();

                    // 項目数チェック
                    if (line.Split(',').Length != CsvCulumnNumber)
                    {
                        if (message.Length > 0) message += "\r\n";
                        message += count.ToString() + "行目：CSVの項目数が不正です";
                        continue;
                    }
                    else
                    {
                        // 項目数が正しければプロパティに値をセット
                        lines.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                if (message.Length > 0) message += "\r\n";
                message += "エラー発生：" + ex.Message;
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            return message;
        }
        #endregion
    }
}
