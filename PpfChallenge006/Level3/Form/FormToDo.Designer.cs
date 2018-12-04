namespace Level3
{
    partial class FormToDo
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormToDo));
            this.dataGridViewToDo = new System.Windows.Forms.DataGridView();
            this.ColumnComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnToDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelToDo = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.textToDo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelToDoInput = new System.Windows.Forms.TableLayoutPanel();
            this.panelDeadline = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelToDo = new System.Windows.Forms.Panel();
            this.labelRedMemo1 = new System.Windows.Forms.Label();
            this.labelBlueMemo1 = new System.Windows.Forms.Label();
            this.labelRedMemo2 = new System.Windows.Forms.Label();
            this.labelBlueMemo2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToDo)).BeginInit();
            this.tableLayoutPanelToDoInput.SuspendLayout();
            this.panelDeadline.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelToDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewToDo
            // 
            this.dataGridViewToDo.AllowUserToAddRows = false;
            this.dataGridViewToDo.AllowUserToDeleteRows = false;
            this.dataGridViewToDo.AllowUserToOrderColumns = true;
            this.dataGridViewToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewToDo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewToDo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewToDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnComplete,
            this.ColumnDeadline,
            this.ColumnToDo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewToDo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewToDo.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewToDo.Location = new System.Drawing.Point(27, 50);
            this.dataGridViewToDo.Name = "dataGridViewToDo";
            this.dataGridViewToDo.RowHeadersVisible = false;
            this.dataGridViewToDo.RowTemplate.Height = 21;
            this.dataGridViewToDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToDo.Size = new System.Drawing.Size(504, 285);
            this.dataGridViewToDo.TabIndex = 1;
            this.dataGridViewToDo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewToDo_CellFormatting);
            this.dataGridViewToDo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewToDo_CellValueChanged);
            this.dataGridViewToDo.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewToDo_CurrentCellDirtyStateChanged);
            // 
            // ColumnComplete
            // 
            this.ColumnComplete.FalseValue = "0";
            this.ColumnComplete.FillWeight = 40F;
            this.ColumnComplete.HeaderText = "完了";
            this.ColumnComplete.Name = "ColumnComplete";
            this.ColumnComplete.TrueValue = "1";
            this.ColumnComplete.Width = 40;
            // 
            // ColumnDeadline
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnDeadline.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnDeadline.FillWeight = 110F;
            this.ColumnDeadline.HeaderText = "期限";
            this.ColumnDeadline.Name = "ColumnDeadline";
            this.ColumnDeadline.ReadOnly = true;
            this.ColumnDeadline.Width = 110;
            // 
            // ColumnToDo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ColumnToDo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnToDo.FillWeight = 350F;
            this.ColumnToDo.HeaderText = "やること";
            this.ColumnToDo.Name = "ColumnToDo";
            this.ColumnToDo.ReadOnly = true;
            this.ColumnToDo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnToDo.Width = 350;
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDeadline.Location = new System.Drawing.Point(3, 0);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(35, 20);
            this.labelDeadline.TabIndex = 0;
            this.labelDeadline.Text = "期限";
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelToDo.Location = new System.Drawing.Point(3, 5);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(61, 20);
            this.labelToDo.TabIndex = 0;
            this.labelToDo.Text = "やること";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.CustomFormat = "yyyy年MM月dd日";
            this.dateTimePickerDeadline.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(6, 21);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(140, 25);
            this.dateTimePickerDeadline.TabIndex = 1;
            this.dateTimePickerDeadline.Value = new System.DateTime(2018, 11, 7, 0, 0, 0, 0);
            // 
            // textToDo
            // 
            this.textToDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textToDo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textToDo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textToDo.Location = new System.Drawing.Point(6, 26);
            this.textToDo.MaxLength = 100;
            this.textToDo.Multiline = true;
            this.textToDo.Name = "textToDo";
            this.textToDo.Size = new System.Drawing.Size(230, 91);
            this.textToDo.TabIndex = 1;
            // 
            // tableLayoutPanelToDoInput
            // 
            this.tableLayoutPanelToDoInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelToDoInput.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelToDoInput.ColumnCount = 1;
            this.tableLayoutPanelToDoInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelToDoInput.Controls.Add(this.panelDeadline, 0, 0);
            this.tableLayoutPanelToDoInput.Controls.Add(this.panelButtons, 0, 2);
            this.tableLayoutPanelToDoInput.Controls.Add(this.panelToDo, 0, 1);
            this.tableLayoutPanelToDoInput.Location = new System.Drawing.Point(546, 26);
            this.tableLayoutPanelToDoInput.Name = "tableLayoutPanelToDoInput";
            this.tableLayoutPanelToDoInput.RowCount = 3;
            this.tableLayoutPanelToDoInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanelToDoInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelToDoInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanelToDoInput.Size = new System.Drawing.Size(242, 309);
            this.tableLayoutPanelToDoInput.TabIndex = 0;
            // 
            // panelDeadline
            // 
            this.panelDeadline.Controls.Add(this.dateTimePickerDeadline);
            this.panelDeadline.Controls.Add(this.labelDeadline);
            this.panelDeadline.Location = new System.Drawing.Point(3, 3);
            this.panelDeadline.Name = "panelDeadline";
            this.panelDeadline.Size = new System.Drawing.Size(169, 54);
            this.panelDeadline.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.buttonRemove);
            this.panelButtons.Controls.Add(this.buttonSave);
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Location = new System.Drawing.Point(9, 198);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(230, 108);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRemove.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRemove.Location = new System.Drawing.Point(130, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(99, 44);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "削除";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSave.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSave.Location = new System.Drawing.Point(0, 52);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(229, 52);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Location = new System.Drawing.Point(0, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 44);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "登録";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelToDo
            // 
            this.panelToDo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelToDo.Controls.Add(this.labelToDo);
            this.panelToDo.Controls.Add(this.textToDo);
            this.panelToDo.Location = new System.Drawing.Point(3, 63);
            this.panelToDo.Name = "panelToDo";
            this.panelToDo.Size = new System.Drawing.Size(236, 123);
            this.panelToDo.TabIndex = 1;
            // 
            // labelRedMemo1
            // 
            this.labelRedMemo1.AutoSize = true;
            this.labelRedMemo1.BackColor = System.Drawing.Color.White;
            this.labelRedMemo1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRedMemo1.ForeColor = System.Drawing.Color.Red;
            this.labelRedMemo1.Location = new System.Drawing.Point(24, 9);
            this.labelRedMemo1.Name = "labelRedMemo1";
            this.labelRedMemo1.Size = new System.Drawing.Size(68, 18);
            this.labelRedMemo1.TabIndex = 2;
            this.labelRedMemo1.Text = "日付が赤字";
            // 
            // labelBlueMemo1
            // 
            this.labelBlueMemo1.AutoSize = true;
            this.labelBlueMemo1.BackColor = System.Drawing.Color.White;
            this.labelBlueMemo1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBlueMemo1.ForeColor = System.Drawing.Color.Blue;
            this.labelBlueMemo1.Location = new System.Drawing.Point(24, 26);
            this.labelBlueMemo1.Name = "labelBlueMemo1";
            this.labelBlueMemo1.Size = new System.Drawing.Size(68, 18);
            this.labelBlueMemo1.TabIndex = 3;
            this.labelBlueMemo1.Text = "日付が青字";
            // 
            // labelRedMemo2
            // 
            this.labelRedMemo2.AutoSize = true;
            this.labelRedMemo2.BackColor = System.Drawing.Color.White;
            this.labelRedMemo2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRedMemo2.Location = new System.Drawing.Point(88, 9);
            this.labelRedMemo2.Name = "labelRedMemo2";
            this.labelRedMemo2.Size = new System.Drawing.Size(128, 18);
            this.labelRedMemo2.TabIndex = 4;
            this.labelRedMemo2.Text = "：期限が過ぎています";
            // 
            // labelBlueMemo2
            // 
            this.labelBlueMemo2.AutoSize = true;
            this.labelBlueMemo2.BackColor = System.Drawing.Color.White;
            this.labelBlueMemo2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBlueMemo2.Location = new System.Drawing.Point(88, 26);
            this.labelBlueMemo2.Name = "labelBlueMemo2";
            this.labelBlueMemo2.Size = new System.Drawing.Size(128, 18);
            this.labelBlueMemo2.TabIndex = 5;
            this.labelBlueMemo2.Text = "：今日が期限です　　";
            // 
            // FormToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.labelBlueMemo2);
            this.Controls.Add(this.labelRedMemo2);
            this.Controls.Add(this.labelBlueMemo1);
            this.Controls.Add(this.labelRedMemo1);
            this.Controls.Add(this.tableLayoutPanelToDoInput);
            this.Controls.Add(this.dataGridViewToDo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormToDo";
            this.Text = "ToDoリスト";
            this.Load += new System.EventHandler(this.FormToDo_Load);
            this.Shown += new System.EventHandler(this.FormToDo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToDo)).EndInit();
            this.tableLayoutPanelToDoInput.ResumeLayout(false);
            this.panelDeadline.ResumeLayout(false);
            this.panelDeadline.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelToDo.ResumeLayout(false);
            this.panelToDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewToDo;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelToDo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.TextBox textToDo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelToDoInput;
        private System.Windows.Forms.Panel panelDeadline;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelToDo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnToDo;
        private System.Windows.Forms.Label labelRedMemo1;
        private System.Windows.Forms.Label labelBlueMemo1;
        private System.Windows.Forms.Label labelRedMemo2;
        private System.Windows.Forms.Label labelBlueMemo2;
    }
}

