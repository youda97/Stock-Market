namespace StockMarket
{
	partial class StockSecurityExchange
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.marketClosedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.beginTradingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopTtadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stockStateSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.marketByOrderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.marketByPriceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.askToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.titleHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marketClosedToolStripMenuItem,
            this.watchToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.windowsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.MdiWindowListItem = this.windowsToolStripMenuItem;
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(2984, 49);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// marketClosedToolStripMenuItem
			// 
			this.marketClosedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginTradingToolStripMenuItem,
            this.stopTtadingToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.marketClosedToolStripMenuItem.Name = "marketClosedToolStripMenuItem";
			this.marketClosedToolStripMenuItem.Size = new System.Drawing.Size(306, 48);
			this.marketClosedToolStripMenuItem.Text = "&Market <<Closed>>";
			// 
			// beginTradingToolStripMenuItem
			// 
			this.beginTradingToolStripMenuItem.Name = "beginTradingToolStripMenuItem";
			this.beginTradingToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
			this.beginTradingToolStripMenuItem.Text = "Begin Trading";
			this.beginTradingToolStripMenuItem.Click += new System.EventHandler(this.beginTradingToolStripMenuItem_Click);
			// 
			// stopTtadingToolStripMenuItem
			// 
			this.stopTtadingToolStripMenuItem.Name = "stopTtadingToolStripMenuItem";
			this.stopTtadingToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
			this.stopTtadingToolStripMenuItem.Text = "Stop Trading";
			this.stopTtadingToolStripMenuItem.Click += new System.EventHandler(this.stopTtadingToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(323, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(326, 46);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// watchToolStripMenuItem
			// 
			this.watchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockStateSummaryToolStripMenuItem,
            this.marketByOrderToolStripMenuItem1,
            this.marketByPriceToolStripMenuItem1});
			this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
			this.watchToolStripMenuItem.Size = new System.Drawing.Size(113, 45);
			this.watchToolStripMenuItem.Text = "&Watch";
			this.watchToolStripMenuItem.Visible = false;
			// 
			// stockStateSummaryToolStripMenuItem
			// 
			this.stockStateSummaryToolStripMenuItem.Name = "stockStateSummaryToolStripMenuItem";
			this.stockStateSummaryToolStripMenuItem.Size = new System.Drawing.Size(411, 46);
			this.stockStateSummaryToolStripMenuItem.Text = "Stock State Summary";
			this.stockStateSummaryToolStripMenuItem.Click += new System.EventHandler(this.stockStateSummaryToolStripMenuItem_Click);
			// 
			// marketByOrderToolStripMenuItem1
			// 
			this.marketByOrderToolStripMenuItem1.Name = "marketByOrderToolStripMenuItem1";
			this.marketByOrderToolStripMenuItem1.Size = new System.Drawing.Size(411, 46);
			this.marketByOrderToolStripMenuItem1.Text = "Market By Order";
			// 
			// marketByPriceToolStripMenuItem1
			// 
			this.marketByPriceToolStripMenuItem1.Name = "marketByPriceToolStripMenuItem1";
			this.marketByPriceToolStripMenuItem1.Size = new System.Drawing.Size(411, 46);
			this.marketByPriceToolStripMenuItem1.Text = "Market By Price";
			// 
			// orderToolStripMenuItem
			// 
			this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bidToolStripMenuItem,
            this.askToolStripMenuItem});
			this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
			this.orderToolStripMenuItem.Size = new System.Drawing.Size(120, 48);
			this.orderToolStripMenuItem.Text = "&Orders";
			this.orderToolStripMenuItem.Visible = false;
			// 
			// bidToolStripMenuItem
			// 
			this.bidToolStripMenuItem.Name = "bidToolStripMenuItem";
			this.bidToolStripMenuItem.Size = new System.Drawing.Size(179, 46);
			this.bidToolStripMenuItem.Text = "Bid";
			this.bidToolStripMenuItem.Click += new System.EventHandler(this.bidToolStripMenuItem_Click);
			// 
			// askToolStripMenuItem
			// 
			this.askToolStripMenuItem.Name = "askToolStripMenuItem";
			this.askToolStripMenuItem.Size = new System.Drawing.Size(179, 46);
			this.askToolStripMenuItem.Text = "Ask";
			this.askToolStripMenuItem.Click += new System.EventHandler(this.askToolStripMenuItem_Click);
			// 
			// windowsToolStripMenuItem
			// 
			this.windowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.titleHorizontalToolStripMenuItem,
            this.tileVerticalToolStripMenuItem});
			this.windowsToolStripMenuItem.Name = "windowsToolStripMenuItem";
			this.windowsToolStripMenuItem.Size = new System.Drawing.Size(153, 48);
			this.windowsToolStripMenuItem.Text = "&Windows";
			// 
			// cascadeToolStripMenuItem
			// 
			this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
			this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(323, 46);
			this.cascadeToolStripMenuItem.Text = "Cascade";
			this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
			// 
			// titleHorizontalToolStripMenuItem
			// 
			this.titleHorizontalToolStripMenuItem.Name = "titleHorizontalToolStripMenuItem";
			this.titleHorizontalToolStripMenuItem.Size = new System.Drawing.Size(323, 46);
			this.titleHorizontalToolStripMenuItem.Text = "Horizontal Tile";
			this.titleHorizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalTileToolStripMenuItem_Click);
			// 
			// tileVerticalToolStripMenuItem
			// 
			this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
			this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(323, 46);
			this.tileVerticalToolStripMenuItem.Text = "Vertical Tile";
			this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.verticalTileToolStripMenuItem_Click);
			// 
			// StockSecurityExchange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(2984, 1252);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "StockSecurityExchange";
			this.Text = "Stock Market";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem windowsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bidToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem askToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem titleHorizontalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem marketClosedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem beginTradingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopTtadingToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stockStateSummaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem marketByOrderToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem marketByPriceToolStripMenuItem1;
	}
}

