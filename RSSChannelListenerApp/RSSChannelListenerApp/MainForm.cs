using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSSChannelListenerApp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private async void filterButton_Click_1(object sender, EventArgs e)
		{
			var filterValues = ParseFilters();
			var jsonResponse = await SendGetRequest(false, filterValues);
			List<Article> articles = JsonConvert.DeserializeObject<List<Article>>(jsonResponse);
			FillDataGrid(articles);
		}

		private async void updateButton_Click(object sender, EventArgs e)
		{
			var filterValues = ParseFilters();
			var jsonResponse = await SendGetRequest(true, filterValues);
			List<Article> articles = JsonConvert.DeserializeObject<List<Article>>(jsonResponse);
			FillDataGrid(articles);
		}

		private async Task<string> SendGetRequest(bool toUpdate, Dictionary<string, string> filterValues)
		{
			var url = BuildUrl(toUpdate, filterValues);
			
			using (var client = new HttpClient())
			{
				var response = await client.GetStringAsync(url);
				return response;
			}
		}

		private string BuildUrl(bool toUpdate, Dictionary<string, string> filterValues)
		{
			var host = "http://localhost/homework/request_handler.php";

			var query = "toUpdate=" + toUpdate.ToString();
			foreach (var kv in filterValues)
			{
				query += "&" + kv.Key + "=" + kv.Value;
			}

			return host + "?" + query;
		}

		private Dictionary<string,string> ParseFilters()
		{
			var filterValues = new Dictionary<string, string>();
			foreach (Control control in filterPanel.Controls)
			{
				switch (control)
				{
					case DateTimePicker datePicker:
						if (datePicker.Value != DateTime.MinValue && datePicker.Value != DateTime.MaxValue) 
							filterValues.Add(control.Name, datePicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
						break;
					case NumericUpDown numericUpDown:
						if (numericUpDown.Value != 0)
							filterValues.Add(control.Name, numericUpDown.Value.ToString());
						break;
					case ComboBox comboBox:
						if (comboBox.SelectedItem != null) 
							filterValues.Add(control.Name, comboBox.SelectedItem.ToString());
						break;
					case TextBox textBox:
						if (textBox.Text != string.Empty)
							filterValues.Add(control.Name, textBox.Text);
						break;
					default:
						continue;
				}
			}
			return filterValues;
		}

		private void FillDataGrid(List<Article> articles)
		{
			dataGridView1.Rows.Clear();
			foreach (var article in articles)
			{
				int rowIndex = dataGridView1.Rows.Add();
				dataGridView1.Rows[rowIndex].Cells[0].Value = article.Id;
				dataGridView1.Rows[rowIndex].Cells[1].Value = article.Title;
				dataGridView1.Rows[rowIndex].Cells[2].Value = article.Link;
				dataGridView1.Rows[rowIndex].Cells[3].Value = article.Description;
				dataGridView1.Rows[rowIndex].Cells[4].Value = article.PubDate;
			}
		}
	}
}
