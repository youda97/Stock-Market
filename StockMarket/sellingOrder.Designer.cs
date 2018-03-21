namespace StockMarket
{
	partial class sellingOrder
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.submit_Btn = new System.Windows.Forms.Button();
			this.cancel_Btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(48, 54);
			this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(280, 32);
			this.label1.TabIndex = 15;
			this.label1.Text = "Select Share to Sell: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(91, 201);
			this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(237, 32);
			this.label2.TabIndex = 16;
			this.label2.Text = "Number of Share:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(113, 287);
			this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(215, 32);
			this.label3.TabIndex = 17;
			this.label3.Text = "Purchase Price:";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownWidth = 519;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(375, 51);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(476, 39);
			this.comboBox1.TabIndex = 8;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(375, 198);
			this.textBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(260, 38);
			this.textBox1.TabIndex = 9;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(375, 284);
			this.textBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(260, 38);
			this.textBox2.TabIndex = 18;
			// 
			// submit_Btn
			// 
			this.submit_Btn.Location = new System.Drawing.Point(190, 421);
			this.submit_Btn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.submit_Btn.Name = "submit_Btn";
			this.submit_Btn.Size = new System.Drawing.Size(200, 55);
			this.submit_Btn.TabIndex = 13;
			this.submit_Btn.Text = "Submit";
			this.submit_Btn.UseVisualStyleBackColor = true;
			this.submit_Btn.Click += new System.EventHandler(this.submit_Btn_Click);
			// 
			// cancel_Btn
			// 
			this.cancel_Btn.Location = new System.Drawing.Point(491, 421);
			this.cancel_Btn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.cancel_Btn.Name = "cancel_Btn";
			this.cancel_Btn.Size = new System.Drawing.Size(200, 55);
			this.cancel_Btn.TabIndex = 14;
			this.cancel_Btn.Text = "Cancl";
			this.cancel_Btn.UseVisualStyleBackColor = true;
			this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
			// 
			// sellingOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(899, 527);
			this.Controls.Add(this.cancel_Btn);
			this.Controls.Add(this.submit_Btn);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "sellingOrder";
			this.Text = "selingOrder";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button submit_Btn;
		private System.Windows.Forms.Button cancel_Btn;
	}
}