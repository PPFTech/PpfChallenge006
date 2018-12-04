using System.Windows.Forms;

namespace Level3
{
    class GridControl
    {
        #region "Private"
        private DataGridView Grid = null;
        private string column1;
        public string Column1
        {
            get { return column1; }
            set { column1 = value; }
        }
        private string column2;
        public string Column2
        {
            get { return column2; }
            set { column2 = value; }
        }
        #endregion

        #region "Constructor"
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public GridControl(DataGridView grid)
        {
            Grid = grid;
        }
        #endregion

        #region "Method"      
        /// <summary>
        /// リストにToDoを追加する
        /// </summary>
        public void Add()
        {
            Grid.Rows.Add(false, Column1, Column2);
        }

        /// <summary>
        /// リストからToDoを削除する
        /// </summary>
        public void Remove()
        {
            foreach (DataGridViewRow row in Grid.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    Grid.Rows.Remove(row);
                }
            }
        }
        #endregion
    }
}
