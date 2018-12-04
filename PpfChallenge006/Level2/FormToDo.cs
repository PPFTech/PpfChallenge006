using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level2
{
    public partial class FormToDo : Form
    {
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
        /// フォームロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormToDo_Load(object sender, EventArgs e)
        {
            // 期限に今日の1週間後の日付をセットしておく
            dateTimePickerDeadline.Value = DateTime.Now.AddDays(7);
        }

        /// <summary>
        /// 登録ボタン押下時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // ToDoリストクラスのインスタンス生成
            ToDoList list = new ToDoList();

            // 入力値をプロパティにセット
            list.Deadline = dateTimePickerDeadline.Text;
            list.ToDo = textToDo.Text;

            // ToDoをリストに追加
            list.Insert(dataGridViewToDo);
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
                // ToDoリストクラスのインスタンス生成
                ToDoList list = new ToDoList();
                list.Delete(dataGridViewToDo);
            }

        }
        #endregion
    }
}
