namespace Level2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewToDo = new System.Windows.Forms.DataGridView();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.labelToDo = new System.Windows.Forms.Label();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.textToDo = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.ColumnComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnDeadline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnToDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToDo)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewToDo
            // 
            this.dataGridViewToDo.AllowUserToAddRows = false;
            this.dataGridViewToDo.AllowUserToDeleteRows = false;
            this.dataGridViewToDo.AllowUserToOrderColumns = true;
            this.dataGridViewToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewToDo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewToDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnComplete,
            this.ColumnDeadline,
            this.ColumnToDo});
            this.dataGridViewToDo.Location = new System.Drawing.Point(27, 26);
            this.dataGridViewToDo.Name = "dataGridViewToDo";
            this.dataGridViewToDo.RowHeadersVisible = false;
            this.dataGridViewToDo.RowTemplate.Height = 21;
            this.dataGridViewToDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewToDo.Size = new System.Drawing.Size(504, 309);
            this.dataGridViewToDo.TabIndex = 5;
            // 
            // labelDeadline
            // 
            this.labelDeadline.AutoSize = true;
            this.labelDeadline.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDeadline.Location = new System.Drawing.Point(544, 27);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(32, 18);
            this.labelDeadline.TabIndex = 0;
            this.labelDeadline.Text = "期限";
            // 
            // labelToDo
            // 
            this.labelToDo.AutoSize = true;
            this.labelToDo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelToDo.Location = new System.Drawing.Point(546, 86);
            this.labelToDo.Name = "labelToDo";
            this.labelToDo.Size = new System.Drawing.Size(56, 18);
            this.labelToDo.TabIndex = 2;
            this.labelToDo.Text = "やること";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.CustomFormat = "yyyy年MM月dd日";
            this.dateTimePickerDeadline.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dateTimePickerDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(548, 43);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(140, 25);
            this.dateTimePickerDeadline.TabIndex = 1;
            this.dateTimePickerDeadline.Value = new System.DateTime(2018, 11, 7, 0, 0, 0, 0);
            // 
            // textToDo
            // 
            this.textToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textToDo.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textToDo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textToDo.Location = new System.Drawing.Point(548, 102);
            this.textToDo.Name = "textToDo";
            this.textToDo.Size = new System.Drawing.Size(229, 25);
            this.textToDo.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonAdd.Location = new System.Drawing.Point(0, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 44);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "登録";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonRemove.Location = new System.Drawing.Point(130, 2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(99, 44);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "削除";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonSave.Location = new System.Drawing.Point(0, 52);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(229, 52);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons.Controls.Add(this.buttonRemove);
            this.panelButtons.Controls.Add(this.buttonSave);
            this.panelButtons.Controls.Add(this.buttonAdd);
            this.panelButtons.Location = new System.Drawing.Point(547, 235);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(230, 108);
            this.panelButtons.TabIndex = 4;
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
            // FormToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.textToDo);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.labelToDo);
            this.Controls.Add(this.labelDeadline);
            this.Controls.Add(this.dataGridViewToDo);
            this.Name = "FormToDo";
            this.Text = "ToDoリスト";
            this.Load += new System.EventHandler(this.FormToDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToDo)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewToDo;
        private System.Windows.Forms.Label labelDeadline;
        private System.Windows.Forms.Label labelToDo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.TextBox textToDo;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDeadline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnToDo;
    }
}

