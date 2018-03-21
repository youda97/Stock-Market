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
	public partial class marketByOrder : Form, StockMarketDisplay
	{

		RealtimeData StockMarket;
		String companyName;
		company newCompany;

		public marketByOrder(Object subject, String name)
		{
			concreteSub = subject;
			companyName = name;

			//Register itself as an observer
			StockMarket.Register(this);
			InitializeComponent();
			update();
		}

		public object concreteSub
		{
			set
			{
				StockMarket = (RealtimeData)value;
			}
		}

		public void update()
		{
			dataGridView1.Rows.Clear();
			dataGridView1.Refresh();

			foreach (company company in StockMarket.getCompanies())
			{
				if (company.Name == companyName)
				{
					newCompany = company;
					break;
				}
			}

			int i = 0;
			foreach (Order buyOrder in newCompany.getBuyOrders())
			{
				string[] row1 = { buyOrder.Size.ToString(), buyOrder.Price.ToString(), null, null };
				dataGridView1.Rows.Add(row1);
				i++;
				if (i == 10) break;
			}

			for (int j = 0; j < 10; j++)
			{
				string[] row1 = { null, null, null, null };
				dataGridView1.Rows.Add(row1);
			}

			

			int k = 0;
			foreach (Order sellOrder in newCompany.getSellOrders())
			{
				dataGridView1[2, k].Value = sellOrder.Price.ToString();
				dataGridView1[3, k].Value = sellOrder.Size.ToString();
				k++;
				if (k == 10) break;
			}

		}

		private void marketByOrder_FormClosed(object sender, FormClosedEventArgs e)
		{
			StockMarket.unRegister(this);
		}
	}
}

