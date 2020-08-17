namespace TcpIpMessaging
{
	partial class AwaitConnection
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
			this.pbx_image = new System.Windows.Forms.PictureBox();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.lbl_text = new System.Windows.Forms.Label();
			this.lbl_header = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbx_image)).BeginInit();
			this.SuspendLayout();
			// 
			// pbx_image
			// 
			this.pbx_image.Image = global::TcpIpMessaging.Properties.Resources.hourglass;
			this.pbx_image.Location = new System.Drawing.Point(12, 12);
			this.pbx_image.Name = "pbx_image";
			this.pbx_image.Size = new System.Drawing.Size(117, 128);
			this.pbx_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbx_image.TabIndex = 0;
			this.pbx_image.TabStop = false;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(312, 139);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(108, 23);
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "İptal";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// lbl_text
			// 
			this.lbl_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_text.Location = new System.Drawing.Point(134, 51);
			this.lbl_text.Name = "lbl_text";
			this.lbl_text.Size = new System.Drawing.Size(286, 85);
			this.lbl_text.TabIndex = 2;
			this.lbl_text.Text = "Abdurrahim Ayaz (192.168.1.1) \r\nKullanıcısının Yanıtı Bekleniyor..";
			// 
			// lbl_header
			// 
			this.lbl_header.AutoSize = true;
			this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lbl_header.Location = new System.Drawing.Point(135, 12);
			this.lbl_header.Name = "lbl_header";
			this.lbl_header.Size = new System.Drawing.Size(237, 24);
			this.lbl_header.TabIndex = 3;
			this.lbl_header.Text = "Bağlantı Cevabı Bekleniyor!";
			// 
			// AwaitConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 174);
			this.ControlBox = false;
			this.Controls.Add(this.lbl_text);
			this.Controls.Add(this.lbl_header);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.pbx_image);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AwaitConnection";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Bekleyiniz..";
			((System.ComponentModel.ISupportInitialize)(this.pbx_image)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbx_image;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Label lbl_text;
		private System.Windows.Forms.Label lbl_header;
	}
}