namespace WindowsFormsApp
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.ComplexityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.textBoxLabel = new System.Windows.Forms.Label();
			this.textBox = new System.Windows.Forms.TextBox();
			this.button = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ComplexityChart)).BeginInit();
			this.SuspendLayout();
			// 
			// ComplexityChart
			// 
			this.ComplexityChart.BackColor = System.Drawing.SystemColors.Control;
			chartArea1.Name = "ChartArea1";
			this.ComplexityChart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.ComplexityChart.Legends.Add(legend1);
			this.ComplexityChart.Location = new System.Drawing.Point(81, 64);
			this.ComplexityChart.Name = "ComplexityChart";
			series1.BorderWidth = 3;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Legend = "Legend1";
			series1.LegendText = "Упрощение";
			series1.Name = "PrimitivisationSeries";
			series2.BorderWidth = 3;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series2.Legend = "Legend1";
			series2.LegendText = "Сапёр";
			series2.Name = "SapperSeries";
			this.ComplexityChart.Series.Add(series1);
			this.ComplexityChart.Series.Add(series2);
			this.ComplexityChart.Size = new System.Drawing.Size(642, 270);
			this.ComplexityChart.TabIndex = 0;
			this.ComplexityChart.Text = "ComplexityChart";
			// 
			// textBoxLabel
			// 
			this.textBoxLabel.AutoSize = true;
			this.textBoxLabel.Location = new System.Drawing.Point(108, 373);
			this.textBoxLabel.Name = "textBoxLabel";
			this.textBoxLabel.Size = new System.Drawing.Size(241, 16);
			this.textBoxLabel.TabIndex = 1;
			this.textBoxLabel.Text = "Введите максимальное значение n:";
			// 
			// textBox
			// 
			this.textBox.Location = new System.Drawing.Point(355, 370);
			this.textBox.Name = "textBox";
			this.textBox.Size = new System.Drawing.Size(100, 22);
			this.textBox.TabIndex = 2;
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(528, 369);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(175, 23);
			this.button.TabIndex = 3;
			this.button.Text = "Построить графики!";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.textBoxLabel);
			this.Controls.Add(this.ComplexityChart);
			this.Name = "MainForm";
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.ComplexityChart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart ComplexityChart;
		private System.Windows.Forms.Label textBoxLabel;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Button button;
	}
}

