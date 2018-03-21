using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockMarket
{
	public partial class sellingOrder : Form
	{

		RealtimeData concreteSub;
		company newCompany;

		public sellingOrder(Object sub)
		{
			concreteSub = (RealtimeData)sub;

			InitializeComponent();

			foreach (company company in concreteSub.getCompanies())
			{
				this.comboBox1.Items.Add(company.Name);

			}
			comboBox1.SelectedIndex = 0;
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (company company in concreteSub.getCompanies())
			{
				int i = 0;
				if (comboBox1.SelectedIndex == i)
				{
					newCompany = company;
					break;
				}
				else i++;
			}
		}

		private void cancel_Btn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void submit_Btn_Click(object sender, EventArgs e)
		{
			newCompany.submitSellOrder(Convert.ToDouble(textBox2.Text), Convert.ToInt32(textBox1.Text));
			foreach (Control control in this.Controls)
			{
				if (control is TextBox)
				{
					TextBox textBox = (TextBox)control;
					textBox.Text = null;
				}

				if (control is ComboBox)
				{
					ComboBox comboBox = (ComboBox)control;
					if (comboBox.Items.Count > 0)
						comboBox.SelectedIndex = 0;
				}
			}
		}
	}
}
