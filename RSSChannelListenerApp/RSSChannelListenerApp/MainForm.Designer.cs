namespace RSSChannelListenerApp
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.updateButton = new System.Windows.Forms.Button();
			this.filterPanel = new System.Windows.Forms.Panel();
			this.filterButton = new System.Windows.Forms.Button();
			this.keywordBox3 = new System.Windows.Forms.TextBox();
			this.operatorBox3 = new System.Windows.Forms.ComboBox();
			this.keywordBox2 = new System.Windows.Forms.TextBox();
			this.operatorBox2 = new System.Windows.Forms.ComboBox();
			this.keywordBox1 = new System.Windows.Forms.TextBox();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LinkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TitleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.operatorBox1 = new System.Windows.Forms.ComboBox();
			this.filterPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(13, 97);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(1323, 48);
			this.updateButton.TabIndex = 0;
			this.updateButton.Text = "Обновить";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// filterPanel
			// 
			this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.filterPanel.Controls.Add(this.filterButton);
			this.filterPanel.Controls.Add(this.keywordBox3);
			this.filterPanel.Controls.Add(this.operatorBox3);
			this.filterPanel.Controls.Add(this.keywordBox2);
			this.filterPanel.Controls.Add(this.operatorBox2);
			this.filterPanel.Controls.Add(this.keywordBox1);
			this.filterPanel.Controls.Add(this.operatorBox1);
			this.filterPanel.Controls.Add(this.numericUpDown);
			this.filterPanel.Controls.Add(this.toDateTimePicker);
			this.filterPanel.Controls.Add(this.fromDateTimePicker);
			this.filterPanel.Controls.Add(this.label3);
			this.filterPanel.Controls.Add(this.label2);
			this.filterPanel.Controls.Add(this.label1);
			this.filterPanel.Location = new System.Drawing.Point(13, 14);
			this.filterPanel.Name = "filterPanel";
			this.filterPanel.Size = new System.Drawing.Size(1322, 70);
			this.filterPanel.TabIndex = 11;
			// 
			// filterButton
			// 
			this.filterButton.Location = new System.Drawing.Point(1136, 36);
			this.filterButton.Name = "filterButton";
			this.filterButton.Size = new System.Drawing.Size(170, 23);
			this.filterButton.TabIndex = 12;
			this.filterButton.Text = "Применить фильтр";
			this.filterButton.UseVisualStyleBackColor = true;
			this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
			// 
			// keywordBox3
			// 
			this.keywordBox3.Location = new System.Drawing.Point(981, 37);
			this.keywordBox3.Name = "keywordBox3";
			this.keywordBox3.Size = new System.Drawing.Size(124, 22);
			this.keywordBox3.TabIndex = 11;
			// 
			// operatorBox3
			// 
			this.operatorBox3.FormattingEnabled = true;
			this.operatorBox3.Items.AddRange(new object[] {
            "Not",
            "Or",
            "And"});
			this.operatorBox3.Location = new System.Drawing.Point(899, 35);
			this.operatorBox3.Name = "operatorBox3";
			this.operatorBox3.Size = new System.Drawing.Size(76, 24);
			this.operatorBox3.TabIndex = 10;
			// 
			// keywordBox2
			// 
			this.keywordBox2.Location = new System.Drawing.Point(769, 37);
			this.keywordBox2.Name = "keywordBox2";
			this.keywordBox2.Size = new System.Drawing.Size(124, 22);
			this.keywordBox2.TabIndex = 9;
			// 
			// operatorBox2
			// 
			this.operatorBox2.FormattingEnabled = true;
			this.operatorBox2.Items.AddRange(new object[] {
            "Not",
            "Or",
            "And"});
			this.operatorBox2.Location = new System.Drawing.Point(687, 35);
			this.operatorBox2.Name = "operatorBox2";
			this.operatorBox2.Size = new System.Drawing.Size(76, 24);
			this.operatorBox2.TabIndex = 8;
			// 
			// keywordBox1
			// 
			this.keywordBox1.Location = new System.Drawing.Point(557, 37);
			this.keywordBox1.Name = "keywordBox1";
			this.keywordBox1.Size = new System.Drawing.Size(124, 22);
			this.keywordBox1.TabIndex = 7;
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(326, 37);
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(113, 22);
			this.numericUpDown.TabIndex = 5;
			// 
			// toDateTimePicker
			// 
			this.toDateTimePicker.Location = new System.Drawing.Point(143, 37);
			this.toDateTimePicker.Name = "toDateTimePicker";
			this.toDateTimePicker.Size = new System.Drawing.Size(127, 22);
			this.toDateTimePicker.TabIndex = 4;
			this.toDateTimePicker.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			// 
			// fromDateTimePicker
			// 
			this.fromDateTimePicker.Location = new System.Drawing.Point(10, 37);
			this.fromDateTimePicker.Name = "fromDateTimePicker";
			this.fromDateTimePicker.Size = new System.Drawing.Size(127, 22);
			this.fromDateTimePicker.TabIndex = 3;
			this.fromDateTimePicker.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(472, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "По ключевым словам:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(323, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Длина описания:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "По дате (от и до):";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDColumn,
            this.TitleColumn,
            this.LinkColumn,
            this.DescriptionColumn,
            this.DateColumn});
			this.dataGridView1.Location = new System.Drawing.Point(17, 160);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1318, 547);
			this.dataGridView1.TabIndex = 12;
			// 
			// DateColumn
			// 
			this.DateColumn.HeaderText = "Publication Date";
			this.DateColumn.MinimumWidth = 6;
			this.DateColumn.Name = "DateColumn";
			this.DateColumn.ReadOnly = true;
			this.DateColumn.Width = 300;
			// 
			// DescriptionColumn
			// 
			this.DescriptionColumn.HeaderText = "Description";
			this.DescriptionColumn.MinimumWidth = 6;
			this.DescriptionColumn.Name = "DescriptionColumn";
			this.DescriptionColumn.ReadOnly = true;
			this.DescriptionColumn.Width = 305;
			// 
			// LinkColumn
			// 
			this.LinkColumn.HeaderText = "Link";
			this.LinkColumn.MinimumWidth = 6;
			this.LinkColumn.Name = "LinkColumn";
			this.LinkColumn.ReadOnly = true;
			this.LinkColumn.Width = 305;
			// 
			// TitleColumn
			// 
			this.TitleColumn.HeaderText = "Title";
			this.TitleColumn.MinimumWidth = 6;
			this.TitleColumn.Name = "TitleColumn";
			this.TitleColumn.ReadOnly = true;
			this.TitleColumn.Width = 305;
			// 
			// IDColumn
			// 
			this.IDColumn.HeaderText = "ID";
			this.IDColumn.MinimumWidth = 6;
			this.IDColumn.Name = "IDColumn";
			this.IDColumn.ReadOnly = true;
			this.IDColumn.Width = 50;
			// 
			// operatorBox1
			// 
			this.operatorBox1.FormattingEnabled = true;
			this.operatorBox1.Items.AddRange(new object[] {
            "Not"});
			this.operatorBox1.Location = new System.Drawing.Point(475, 35);
			this.operatorBox1.Name = "operatorBox1";
			this.operatorBox1.Size = new System.Drawing.Size(76, 24);
			this.operatorBox1.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1348, 721);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.filterPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RSS Channel Listener App";
			this.filterPanel.ResumeLayout(false);
			this.filterPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Panel filterPanel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.DateTimePicker toDateTimePicker;
		private System.Windows.Forms.DateTimePicker fromDateTimePicker;
		private System.Windows.Forms.TextBox keywordBox2;
		private System.Windows.Forms.ComboBox operatorBox2;
		private System.Windows.Forms.TextBox keywordBox1;
		private System.Windows.Forms.TextBox keywordBox3;
		private System.Windows.Forms.ComboBox operatorBox3;
		private System.Windows.Forms.Button filterButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TitleColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LinkColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
		private System.Windows.Forms.ComboBox operatorBox1;
	}
}

