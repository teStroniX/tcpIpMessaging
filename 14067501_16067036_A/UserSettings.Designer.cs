namespace TcpIpMessaging
{
	partial class UserSettings
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
			this.lbl_username = new System.Windows.Forms.Label();
			this.txb_username = new System.Windows.Forms.TextBox();
			this.lbl_ipAddress = new System.Windows.Forms.Label();
			this.txb_ipAddress = new System.Windows.Forms.TextBox();
			this.btn_set = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_username
			// 
			this.lbl_username.AutoSize = true;
			this.lbl_username.Location = new System.Drawing.Point(12, 15);
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(67, 13);
			this.lbl_username.TabIndex = 0;
			this.lbl_username.Text = "Kullanıcı Adı:";
			// 
			// txb_username
			// 
			this.txb_username.Location = new System.Drawing.Point(89, 12);
			this.txb_username.Name = "txb_username";
			this.txb_username.Size = new System.Drawing.Size(202, 20);
			this.txb_username.TabIndex = 1;
			// 
			// lbl_ipAddress
			// 
			this.lbl_ipAddress.AutoSize = true;
			this.lbl_ipAddress.Location = new System.Drawing.Point(12, 41);
			this.lbl_ipAddress.Name = "lbl_ipAddress";
			this.lbl_ipAddress.Size = new System.Drawing.Size(52, 13);
			this.lbl_ipAddress.TabIndex = 0;
			this.lbl_ipAddress.Text = "IP Adresi:";
			// 
			// txb_ipAddress
			// 
			this.txb_ipAddress.Location = new System.Drawing.Point(89, 38);
			this.txb_ipAddress.Name = "txb_ipAddress";
			this.txb_ipAddress.ReadOnly = true;
			this.txb_ipAddress.Size = new System.Drawing.Size(121, 20);
			this.txb_ipAddress.TabIndex = 1;
			// 
			// btn_set
			// 
			this.btn_set.Location = new System.Drawing.Point(216, 38);
			this.btn_set.Name = "btn_set";
			this.btn_set.Size = new System.Drawing.Size(75, 20);
			this.btn_set.TabIndex = 2;
			this.btn_set.Text = "Ayarla";
			this.btn_set.UseVisualStyleBackColor = true;
			this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(155, 64);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(136, 23);
			this.btn_cancel.TabIndex = 3;
			this.btn_cancel.Text = "İptal";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(13, 64);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(136, 23);
			this.btn_save.TabIndex = 3;
			this.btn_save.Text = "Kaydet";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// UserSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(301, 96);
			this.ControlBox = false;
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_set);
			this.Controls.Add(this.txb_ipAddress);
			this.Controls.Add(this.lbl_ipAddress);
			this.Controls.Add(this.txb_username);
			this.Controls.Add(this.lbl_username);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UserSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Kullanıcı Seçenekleri";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserSettings_FormClosing);
			this.Load += new System.EventHandler(this.UserSettings_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_username;
		private System.Windows.Forms.TextBox txb_username;
		private System.Windows.Forms.Label lbl_ipAddress;
		private System.Windows.Forms.TextBox txb_ipAddress;
		private System.Windows.Forms.Button btn_set;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_save;
	}
}