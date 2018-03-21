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
	public partial class StockSecurityExchange : Form
	{

		private RealtimeData concreteSub;

		public StockSecurityExchange()
		{
			InitializeComponent();
		}
		private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Cascade all MDI child windows.
			this.LayoutMdi(MdiLayout.Cascade);
		}
		private void horizontalTileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Tile all child forms horizontally.
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void verticalTileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Tile all child forms vertically.
			this.LayoutMdi(MdiLayout.TileVertical);

		}

		private void bidToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bidOrder newMDIChild = new bidOrder(concreteSub);
			// Set the parent form of the child window.
			newMDIChild.MdiParent = this;
			// Display the new form.
			newMDIChild.Show();
		}

		private void askToolStripMenuItem_Click(object sender, EventArgs e)
		{
			sellingOrder newMDIChild = new sellingOrder(concreteSub);
			// Set the parent form of the child window.
			newMDIChild.MdiParent = this;
			// Display the new form.
			newMDIChild.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void beginTradingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			concreteSub = new RealtimeData();

			concreteSub.addCompany("MSFT", "Microsoft Corporation", 46.13);
			concreteSub.addCompany("AAPL", "Apple Inc.", 105.22);
			concreteSub.addCompany("FB", "Facebook Inc.", 80.67);

			this.orderToolStripMenuItem.Visible = true;
			this.watchToolStripMenuItem.Visible = true;
			this.beginTradingToolStripMenuItem.Enabled = false;
			this.marketClosedToolStripMenuItem.Text = "&Market <<Open>>";

			watchSSMenu(this.marketByOrderToolStripMenuItem1);
			watchSSMenu(this.marketByPriceToolStripMenuItem1);
		}

		public void watchSSMenu(ToolStripMenuItem options)
		{
			ToolStripMenuItem subMenu;
			List<company> companies = concreteSub.getCompanies();
			foreach (company company in companies)
			{
				if (options.Name == "marketByPriceToolStripMenuItem1")
					subMenu = new ToolStripMenuItem(company.Name, null, marketByPriceToolStripMenuItem_Click);
				else
					subMenu = new ToolStripMenuItem(company.Name, null, marketByOrderToolStripMenuItem_Click);
				options.DropDownItems.Add(subMenu);
			}
		}

		private void stopTtadingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void stockStateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			stockStateSummary newMDIChild = new stockStateSummary(concreteSub);
			// Set the parent form of the child window.
			newMDIChild.MdiParent = this;
			// Display the new form.
			newMDIChild.Show();
		}

		private void marketByOrderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			marketByOrder newMDIChild = new marketByOrder(concreteSub, sender.ToString());
			// Set the parent form of the child window.
			newMDIChild.Text = "Market Depth By Order (" + sender.ToString() + ")";
			newMDIChild.MdiParent = this;
			// Display the new form.
			newMDIChild.Show();
		}

		private void marketByPriceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			marketByPrice newMDIChild = new marketByPrice(concreteSub, sender.ToString());
			// Set the parent form of the child window.
			newMDIChild.Text = "Market Depth By Price (" + sender.ToString() + ")";
			newMDIChild.MdiParent = this;
			// Display the new form.
			newMDIChild.Show();
		}
	}
}
