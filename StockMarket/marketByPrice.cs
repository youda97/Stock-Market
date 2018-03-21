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
	public partial class marketByPrice : Form, StockMarketDisplay
	{

		RealtimeData StockMarket;
		String companyName;
		company newCompany;

		public marketByPrice(Object subject, String name)
		{
			concreteSub = subject;
			companyName = name;

			//Register itself as an observer
			StockMarket.Register(this);
			InitializeComponent();
			update();
		}

		public object concreteSub {
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

			int[] number = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			Double[] price = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			int[] volume = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			int index = 0;

			var firstBuyPrice = newCompany.getBuyOrders().FirstOrDefault();
			if (firstBuyPrice != null)
			{
				price[index] = firstBuyPrice.Price;
			}

			foreach (Order B in newCompany.getBuyOrders())
			{
				if (price[index] == B.Price)
				{
					number[index]++;
					volume[index] += B.Size;
				}
				else
				{
					index++;
					number[index] = 1;
					price[index] = B.Price;
					volume[index] = B.Size;
				}
			}

			for (int j = 0; j < 10; j++)
			{
				string[] row1 = {
					(price[j] == 0 ? "" : number[j].ToString()),
					(volume[j] == 0 ? "" :volume[j].ToString()),
					(price[j] == 0 ? "" : price[j].ToString())};

				dataGridView1.Rows.Add(row1);

			}

			int[] number2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			Double[] price2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			int[] volume2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			int index2 = 0;

			var firstSellPrice = newCompany.getSellOrders().FirstOrDefault();
			if (firstSellPrice != null)
			{
				price[index2] = firstSellPrice.Price;
			}

			foreach (Order S in newCompany.getSellOrders())
			{
				if (price2[index2] == S.Price)
				{
					number2[index2]++;
					volume2[index2] += S.Size;
				}
				else
				{
					index2++;
					number2[index2] = 1;
					price2[index2] = S.Price;
					volume2[index2] = S.Size;
				}
			}
			for (int k = 0; k < 10; k++)
			{
				dataGridView1[3, k].Value = (price2[k] == 0 ? "" : price2[k].ToString());
				dataGridView1[4, k].Value = (volume2[k] == 0 ? "" : volume2[k].ToString());
				dataGridView1[5, k].Value = (price2[k] == 0 ? "" : number2[k].ToString());
			}

		}
	}
}
