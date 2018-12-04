using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Level2
{
    class ToDoList
    {
        #region "Property"
        // 期限
        private string deadline;
        public string Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        // やること
        private string toDo;
        public string ToDo
        {
            get { return toDo; }
            set { toDo = value; }
        }
        #endregion

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ToDoList()
        {
        }
        #endregion

        #region "Method"      
        /// <summary>
        /// リストにToDoを追加する
        /// </summary>
        /// <param name="dataGrid">ToDoListコントロール</param>
        public void Insert(DataGridView dataGrid)
        {
            dataGrid.Rows.Add(false, Deadline, ToDo);
        }

        /// <summary>
        /// リストからToDoを削除する
        /// </summary>
        /// <param name="dataGrid">ToDoListコントロール</param>
        public void Delete(DataGridView dataGrid)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGrid.Rows.Remove(row);
                }
            }
        }
        #endregion
    }
}
