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
	public partial class stockStateSummary : Form, StockMarketDisplay
	{

		RealtimeData stockMarket;
		Bitmap upImage;
		Bitmap downImage;
		Bitmap noChange;

		public stockStateSummary(Object sub)
		{
			concreteSub = sub;

			//Register itself as an observer
			stockMarket.Register(this);

			InitializeComponent();

			try
			{
				noChange = new Bitmap(this.imgs.Images[0]);
			}
			catch (Exception)
			{

				noChange = null;
			}
			try
			{
				upImage = new Bitmap(this.imgs.Images[1]);
			}
			catch (Exception)
			{

				upImage = null;
			}
			try
			{
				downImage = new Bitmap(this.imgs.Images[2]);
			}
			catch (Exception)
			{

				downImage = null;
			}
			

			update();

		}

		public object concreteSub {
			set
			{
				stockMarket = (RealtimeData) value;
			}
		}

		public void update()
		{
			dataGridView1.Rows.Clear();
			dataGridView1.Refresh();

			List<company> companies = stockMarket.getCompanies();
			int i = 0;
			foreach (company company in companies)
			{
				double changeNet;
				double changePercent;
				int volume;
				Bitmap images;
				images = noChange;

				if (company.LastSale == 0)
				{
					changeNet = 0;
					changePercent = 0;
				}
				else
				{
					changeNet = company.LastSale - company.OpenPrice;
					if (changeNet < 0)
						images = downImage;
					else if (changeNet > 0)
						images = upImage;

					changeNet = Math.Abs(company.LastSale - company.OpenPrice);
					changePercent = (changeNet / company.OpenPrice) * 100;
				}
				volume = company.getVolume();

				string[] row = { company.Name, company.Symbol, company.OpenPrice.ToString(), company.LastSale.ToString(), changeNet.ToString(), null, changePercent.ToString("00.00"), volume.ToString() };
				dataGridView1.Rows.Add(row);
				dataGridView1[5, i].Value = images;
				i++;
			}
		}

		private void stockStateSummary_FormClosed(object sender, FormClosedEventArgs e)
		{
			stockMarket.unRegister(this);
		}
	}
}
