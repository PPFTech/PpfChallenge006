using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Level3
{
    public partial class FormToDo : Form
    {
        private const string XmlFilePath = @"Setting.xml";
        private string CsvFilePath = "";
        private string CsvFileEncode = "";

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormToDo()
        {
            InitializeComponent();
        }
        #endregion

        #region "Event"
        /// <summary>
        /// フォームのShownイベント・ハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FormToDo_Shown(object sender, EventArgs e)
        {
            // 選択されているセルをなくす
            dataGridViewToDo.CurrentCell = null;
        }

        /// <summary>
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormToDo_Load(object sender, EventArgs e)
        {
            // 期限に今日の日付をセットしておく
            dateTimePickerDeadline.Value = DateTime.Now;

            // XMLファイル読み込み
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XmlFilePath);
            CsvFilePath = xmlDoc.SelectSingleNode("csvfile/path").InnerText;
            CsvFileEncode = xmlDoc.SelectSingleNode("csvfile/encode").InnerText;

            // ToDoリストの保存済みデータがあれば読み込んでグリッドに表示
            if (File.Exists(CsvFilePath))
            {
                // ファイル操作用クラスのインスタンス生成
                FileControl file = new FileControl(CsvFilePath, CsvFileEncode);
                // ファイル読み込み実行
                string error = file.Read();
                // 戻り値(リスト)をグリッドに追加
                foreach (string line in file.Lines)
                {
                    // 行を配列化
                    string[] toDoArray = line.Split(',');
                    // グリッドに値をセット
                    dataGridViewToDo.Rows.Add(false, toDoArray[0], toDoArray[1].Replace("<br>", "\r\n"));
                }
                if (error.Length != 0)
                {
                    MessageBox.Show("保存済みデータ読み込みエラー：\r\n" + error);
                }
            }
        }

        /// <summary>
        /// 登録ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // ToDoリストクラスのインスタンス生成
            GridControl list = new GridControl(dataGridViewToDo);

            // 入力値をプロパティにセット
            list.Column1 = dateTimePickerDeadline.Text;
            list.Column2 = textToDo.Text.Replace(",", "，");

            // ToDoをリストに追加
            list.Add();
        }

        /// <summary>
        /// 削除ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // 行が選択されているかチェック
            if(dataGridViewToDo.SelectedRows.Count <= 0)
            {
                MessageBox.Show("削除したい行を選択してください");
            }
            else
            {
                if (MessageBox.Show("削除して良いですか？", "削除", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    // ToDoリストクラスのインスタンス生成
                    GridControl list = new GridControl(dataGridViewToDo);
                    list.Remove();
                }
            }
        }

        /// <summary>
        /// 保存ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("現在のリスト内容で保存しますか？\r\n完了チェックを入れたToDoは保存対象外となり、次回以降は表示されません。", "保存", MessageBoxButtons.YesNo);
            if (dr != DialogResult.Yes) return;

            string lines = "";
            // グリッドの読み込み
            for (int i = 0; i < dataGridViewToDo.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewToDo.Columns.Count; j++)
                {
                    bool nextflg = false;
                    switch (j)
                    {
                        case 0:
                            if (dataGridViewToDo.Rows[i].Cells[j].Value.ToString() == "1") nextflg = true;
                            break;
                        case 1:
                            lines += dataGridViewToDo.Rows[i].Cells[j].Value.ToString();
                            break;
                        case 2:
                            lines += ",";
                            lines += dataGridViewToDo.Rows[i].Cells[j].Value.ToString().Replace("\r\n", "<br>");
                            lines += "\r\n";
                            break;
                    }
                    if (nextflg) break;
                }
            }
            // 保存開始
            FileControl file = new FileControl(CsvFilePath, CsvFileEncode);
            string error = file.Write(lines);
            if (error.Length == 0) {
                MessageBox.Show("保存完了");
            }
            else
            {
                MessageBox.Show(error);
            }
        }

        /// <summary>
        /// CurrentCellDirtyStateChangedイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewToDo_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewToDo.CurrentCellAddress.X == 0 && dataGridViewToDo.IsCurrentCellDirty)
            {
                //コミットする
                dataGridViewToDo.CommitEdit(DataGridViewDataErrorContexts.Commit);

            }
        }

        /// <summary>
        /// CellValueChangedイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewToDo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //列のインデックスを確認する
            if(e.ColumnIndex != 0 || e.RowIndex == -1) return;

            if(dataGridViewToDo[e.ColumnIndex, e.RowIndex].Value.ToString() == "1"){
                // 完了チェック
                DialogResult dr = MessageBox.Show("完了チェックを付けたToDoをリストから削除して良いですか？", "ToDo完了", MessageBoxButtons.YesNo);
                if (dr != DialogResult.Yes) return;
                // ToDoリストクラスのインスタンス生成
                GridControl list = new GridControl(dataGridViewToDo);
                list.Remove();
            }
        }

        /// <summary>
        /// フォームのShownイベント・ハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewToDo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 列のインデックスを確認する
            if (e.ColumnIndex != 1) return;

            // 期限の桁数チェック
            string deadline = e.Value.ToString();
            if (deadline.Length == 0) return;

            // 期限文字列から「年月日」を除去
            deadline = deadline.Replace("年", "");
            deadline = deadline.Replace("月", "");
            deadline = deadline.Replace("日", "");

            // 今日の日付を取得
            DateTime date = DateTime.Now;
            String today = date.ToString("yyyyMMdd");

            // 期限の到来チェック
            if(deadline == today)
            {
                // 期限は今日
                e.CellStyle.ForeColor = System.Drawing.Color.Blue;
            }
            else if (int.Parse(deadline) < int.Parse(today))
            {
                // 期限が過ぎている
                e.CellStyle.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion
    }
}
