namespace TcpIpMessaging
{
	partial class AddNewFriend
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
			this.lbl_ipAddress = new System.Windows.Forms.Label();
			this.txb_ipAddress = new System.Windows.Forms.TextBox();
			this.btn_send = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_ipAddress
			// 
			this.lbl_ipAddress.AutoSize = true;
			this.lbl_ipAddress.Location = new System.Drawing.Point(12, 134);
			this.lbl_ipAddress.Name = "lbl_ipAddress";
			this.lbl_ipAddress.Size = new System.Drawing.Size(94, 13);
			this.lbl_ipAddress.TabIndex = 0;
			this.lbl_ipAddress.Text = "Arkadaş IP Adresi:";
			// 
			// txb_ipAddress
			// 
			this.txb_ipAddress.Location = new System.Drawing.Point(112, 131);
			this.txb_ipAddress.Name = "txb_ipAddress";
			this.txb_ipAddress.Size = new System.Drawing.Size(259, 20);
			this.txb_ipAddress.TabIndex = 1;
			// 
			// btn_send
			// 
			this.btn_send.Location = new System.Drawing.Point(276, 157);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(95, 23);
			this.btn_send.TabIndex = 2;
			this.btn_send.Text = "İstek Gönder";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(359, 113);
			this.dataGridView1.TabIndex = 3;
			// 
			// AddNewFriend
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(383, 192);
			this.ControlBox = false;
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_send);
			this.Controls.Add(this.txb_ipAddress);
			this.Controls.Add(this.lbl_ipAddress);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddNewFriend";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Yeni Arkadaş Ekle";
			this.Load += new System.EventHandler(this.AddNewFriend_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_ipAddress;
		private System.Windows.Forms.TextBox txb_ipAddress;
		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}