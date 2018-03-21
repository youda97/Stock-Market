namespace StockMarket
{
	partial class stockStateSummary
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(stockStateSummary));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.imgs = new System.Windows.Forms.ImageList(this.components);
			this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Symbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OpenPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChangeNet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.ChangePercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ShareVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowDrop = true;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company,
            this.Symbol,
            this.OpenPrice,
            this.LastSale,
            this.ChangeNet,
            this.Column1,
            this.ChangePercentage,
            this.ShareVolume});
			this.dataGridView1.Location = new System.Drawing.Point(33, 39);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 40;
			this.dataGridView1.Size = new System.Drawing.Size(1567, 359);
			this.dataGridView1.TabIndex = 0;
			// 
			// imgs
			// 
			this.imgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs.ImageStream")));
			this.imgs.TransparentColor = System.Drawing.Color.Transparent;
			this.imgs.Images.SetKeyName(0, "noChange.bmp");
			this.imgs.Images.SetKeyName(1, "up.bmp");
			this.imgs.Images.SetKeyName(2, "down.bmp");
			// 
			// Company
			// 
			this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Company.Frozen = true;
			this.Company.HeaderText = "Company";
			this.Company.MaxInputLength = 50;
			this.Company.Name = "Company";
			this.Company.ReadOnly = true;
			this.Company.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Company.Width = 150;
			// 
			// Symbol
			// 
			this.Symbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Symbol.FillWeight = 40F;
			this.Symbol.Frozen = true;
			this.Symbol.HeaderText = "Symbol";
			this.Symbol.MaxInputLength = 10;
			this.Symbol.Name = "Symbol";
			this.Symbol.ReadOnly = true;
			this.Symbol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Symbol.Width = 60;
			// 
			// OpenPrice
			// 
			this.OpenPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.OpenPrice.Frozen = true;
			this.OpenPrice.HeaderText = "Open Price";
			this.OpenPrice.Name = "OpenPrice";
			this.OpenPrice.ReadOnly = true;
			this.OpenPrice.Width = 60;
			// 
			// LastSale
			// 
			this.LastSale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.LastSale.FillWeight = 70F;
			this.LastSale.Frozen = true;
			this.LastSale.HeaderText = "Last Sale";
			this.LastSale.Name = "LastSale";
			this.LastSale.ReadOnly = true;
			this.LastSale.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.LastSale.Width = 60;
			// 
			// ChangeNet
			// 
			this.ChangeNet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ChangeNet.Frozen = true;
			this.ChangeNet.HeaderText = "Change Net";
			this.ChangeNet.Name = "ChangeNet";
			this.ChangeNet.ReadOnly = true;
			this.ChangeNet.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ChangeNet.Width = 60;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column1.HeaderText = "";
			this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.Column1.Width = 15;
			// 
			// ChangePercentage
			// 
			this.ChangePercentage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle2.Format = "N3";
			this.ChangePercentage.DefaultCellStyle = dataGridViewCellStyle2;
			this.ChangePercentage.HeaderText = "Change %";
			this.ChangePercentage.Name = "ChangePercentage";
			this.ChangePercentage.ReadOnly = true;
			this.ChangePercentage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ChangePercentage.Width = 60;
			// 
			// ShareVolume
			// 
			this.ShareVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.ShareVolume.HeaderText = "Share Volume";
			this.ShareVolume.Name = "ShareVolume";
			this.ShareVolume.ReadOnly = true;
			this.ShareVolume.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ShareVolume.Width = 80;
			// 
			// stockStateSummary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1637, 432);
			this.Controls.Add(this.dataGridView1);
			this.Name = "stockStateSummary";
			this.Text = "stockStateSummary";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.stockStateSummary_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ImageList imgs;
		public System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Company;
		private System.Windows.Forms.DataGridViewTextBoxColumn Symbol;
		private System.Windows.Forms.DataGridViewTextBoxColumn OpenPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn LastSale;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChangeNet;
		private System.Windows.Forms.DataGridViewImageColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChangePercentage;
		private System.Windows.Forms.DataGridViewTextBoxColumn ShareVolume;
	}
}