using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button_Click(object sender, EventArgs e)
		{
			// Парсинг переданного в textBox значения (n)
			if (!int.TryParse(textBox.Text, out int n))
			{
				return;
			}

			var pointsAmount = 5;

			// Определение точек по оси X
			var partsLength = Convert.ToInt32(Math.Round(Convert.ToDouble(n / pointsAmount)));
			var pointsX = new int[pointsAmount];
			for (int i = 0; i < pointsAmount - 1; i++)
			{
				pointsX[i] = (i + 1) * partsLength;
			}
			pointsX[pointsAmount - 1] = n;

			var primitivisation = new Primitivisation();
			var sapper = new Sapper();

			// Определение точек по оси Y для двух алгоритмов
			var pointsYprim = new long[pointsAmount];
			var pointsYsap= new long[pointsAmount];
			for (int i = 0; i < pointsAmount; i++)
			{
				pointsYprim[i] = primitivisation.CalculateTime(pointsX[i]);
				pointsYsap[i] = sapper.CalculateTime(pointsX[i]);
			}

			// Отрисовывание точек для двух алгоритмов на графике
			for (int i = 0; i < pointsAmount; i++)
			{
				ComplexityChart.Series[0].Points.AddXY(pointsX[i], pointsYprim[i]);
				ComplexityChart.Series[1].Points.AddXY(pointsX[i], pointsYsap[i]);
			}
		}
	}
}
