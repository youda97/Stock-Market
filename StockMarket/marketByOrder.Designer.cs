namespace StockMarket
{
	partial class marketByOrder
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
			System.Windows.Forms.Label label2;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Volume2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(771, 31);
			label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(64, 32);
			label2.TabIndex = 5;
			label2.Text = "Sell";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(352, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 32);
			this.label1.TabIndex = 4;
			this.label1.Text = "Buy";
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
            this.Volume,
            this.Price,
            this.Price2,
            this.Volume2});
			this.dataGridView1.Location = new System.Drawing.Point(35, 94);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 40;
			this.dataGridView1.Size = new System.Drawing.Size(968, 535);
			this.dataGridView1.TabIndex = 6;
			// 
			// Volume
			// 
			this.Volume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle11.Format = "C2";
			this.Volume.DefaultCellStyle = dataGridViewCellStyle11;
			this.Volume.HeaderText = "Volume";
			this.Volume.Name = "Volume";
			this.Volume.ReadOnly = true;
			this.Volume.Width = 80;
			// 
			// Price
			// 
			this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle12.Format = "C2";
			this.Price.DefaultCellStyle = dataGridViewCellStyle12;
			this.Price.FillWeight = 70F;
			this.Price.HeaderText = "Price";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Price.Width = 80;
			// 
			// Price2
			// 
			this.Price2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Price2.HeaderText = "Price";
			this.Price2.Name = "Price2";
			this.Price2.ReadOnly = true;
			this.Price2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Price2.Width = 80;
			// 
			// Volume2
			// 
			this.Volume2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Volume2.HeaderText = "Volume";
			this.Volume2.Name = "Volume2";
			this.Volume2.ReadOnly = true;
			this.Volume2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Volume2.Width = 80;
			// 
			// marketByOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1043, 661);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(label2);
			this.Controls.Add(this.label1);
			this.Name = "marketByOrder";
			this.Text = "Market Depth By Order";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.marketByOrder_FormClosed);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Volume2;
		public System.Windows.Forms.DataGridView dataGridView1;
	}
}