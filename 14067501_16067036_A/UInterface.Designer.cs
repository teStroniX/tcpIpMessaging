namespace TcpIpMessaging
{
	partial class UInterface
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tc_chatTabs = new System.Windows.Forms.TabControl();
			this.gbx_friends = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btn_addNewFriend = new System.Windows.Forms.ToolStripButton();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.btn_alwaysTop = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_userSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_restart = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripDropDownButton();
			this.btn_settings = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_clearUser = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_clearFriends = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.btn_about = new System.Windows.Forms.ToolStripMenuItem();
			this.connState = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lbl_username = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbl_ipAdd = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lbl_datetime = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbx_friends.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gbx_friends);
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
			this.splitContainer1.Size = new System.Drawing.Size(926, 483);
			this.splitContainer1.SplitterDistance = 696;
			this.splitContainer1.TabIndex = 8;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tc_chatTabs);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(690, 477);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chat Ekranı";
			// 
			// tc_chatTabs
			// 
			this.tc_chatTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tc_chatTabs.Location = new System.Drawing.Point(3, 16);
			this.tc_chatTabs.Name = "tc_chatTabs";
			this.tc_chatTabs.SelectedIndex = 0;
			this.tc_chatTabs.Size = new System.Drawing.Size(684, 458);
			this.tc_chatTabs.TabIndex = 1;
			// 
			// gbx_friends
			// 
			this.gbx_friends.Controls.Add(this.tableLayoutPanel1);
			this.gbx_friends.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbx_friends.Location = new System.Drawing.Point(3, 3);
			this.gbx_friends.Name = "gbx_friends";
			this.gbx_friends.Padding = new System.Windows.Forms.Padding(6);
			this.gbx_friends.Size = new System.Drawing.Size(220, 452);
			this.gbx_friends.TabIndex = 4;
			this.gbx_friends.TabStop = false;
			this.gbx_friends.Text = "Arkadaş Listesi";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 427);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_addNewFriend});
			this.toolStrip1.Location = new System.Drawing.Point(3, 455);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(220, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btn_addNewFriend
			// 
			this.btn_addNewFriend.Image = global::TcpIpMessaging.Properties.Resources.add_friend;
			this.btn_addNewFriend.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btn_addNewFriend.Name = "btn_addNewFriend";
			this.btn_addNewFriend.Size = new System.Drawing.Size(118, 22);
			this.btn_addNewFriend.Text = "Yeni Arkadaş Ekle";
			this.btn_addNewFriend.Click += new System.EventHandler(this.btn_addNewFriend_Click);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripDropDownButton1,
            this.connState,
            this.toolStripLabel1});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(926, 25);
			this.toolStrip2.TabIndex = 9;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_alwaysTop,
            this.btn_userSettings,
            this.toolStripSeparator1,
            this.btn_restart,
            this.btn_exit});
			this.toolStripButton2.Image = global::TcpIpMessaging.Properties.Resources.menu;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(67, 22);
			this.toolStripButton2.Text = "Menü";
			// 
			// btn_alwaysTop
			// 
			this.btn_alwaysTop.Name = "btn_alwaysTop";
			this.btn_alwaysTop.Size = new System.Drawing.Size(181, 22);
			this.btn_alwaysTop.Text = "En Öne Sabitle";
			this.btn_alwaysTop.Click += new System.EventHandler(this.btn_alwaysTop_Click);
			// 
			// btn_userSettings
			// 
			this.btn_userSettings.Name = "btn_userSettings";
			this.btn_userSettings.Size = new System.Drawing.Size(181, 22);
			this.btn_userSettings.Text = "Kullanıcı Seçenekleri";
			this.btn_userSettings.Click += new System.EventHandler(this.btn_userSettings_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
			// 
			// btn_restart
			// 
			this.btn_restart.Name = "btn_restart";
			this.btn_restart.Size = new System.Drawing.Size(181, 22);
			this.btn_restart.Text = "Yeniden Başlat";
			this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
			// 
			// btn_exit
			// 
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(181, 22);
			this.btn_exit.Text = "Çıkış";
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_settings});
			this.toolStripButton3.Image = global::TcpIpMessaging.Properties.Resources.edit;
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(92, 22);
			this.toolStripButton3.Text = "Seçenekler";
			// 
			// btn_settings
			// 
			this.btn_settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_clearUser,
            this.btn_clearFriends});
			this.btn_settings.Name = "btn_settings";
			this.btn_settings.Size = new System.Drawing.Size(130, 22);
			this.btn_settings.Text = "Seçenekler";
			// 
			// btn_clearUser
			// 
			this.btn_clearUser.Name = "btn_clearUser";
			this.btn_clearUser.Size = new System.Drawing.Size(209, 22);
			this.btn_clearUser.Text = "Kullanıcı Verilerini Temizle";
			this.btn_clearUser.Click += new System.EventHandler(this.btn_clearUser_Click);
			// 
			// btn_clearFriends
			// 
			this.btn_clearFriends.Name = "btn_clearFriends";
			this.btn_clearFriends.Size = new System.Drawing.Size(209, 22);
			this.btn_clearFriends.Text = "Arkadaş Listesini Temizle";
			this.btn_clearFriends.Click += new System.EventHandler(this.btn_clearFriends_Click);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_about});
			this.toolStripDropDownButton1.Image = global::TcpIpMessaging.Properties.Resources.question;
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(73, 22);
			this.toolStripDropDownButton1.Text = "Yardım";
			// 
			// btn_about
			// 
			this.btn_about.Name = "btn_about";
			this.btn_about.Size = new System.Drawing.Size(124, 22);
			this.btn_about.Text = "Hakkında";
			this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
			// 
			// connState
			// 
			this.connState.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.connState.BackColor = System.Drawing.SystemColors.Control;
			this.connState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.connState.Image = global::TcpIpMessaging.Properties.Resources.checked_red;
			this.connState.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.connState.Name = "connState";
			this.connState.Size = new System.Drawing.Size(23, 22);
			this.connState.Text = "toolStripButton4";
			this.connState.Click += new System.EventHandler(this.connState_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(100, 22);
			this.toolStripLabel1.Text = "Bağlantı Durumu:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_username,
            this.lbl_ipAdd,
            this.toolStripStatusLabel3,
            this.toolStripProgressBar1,
            this.toolStripStatusLabel4,
            this.lbl_datetime});
			this.statusStrip1.Location = new System.Drawing.Point(0, 508);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(926, 22);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lbl_username
			// 
			this.lbl_username.Name = "lbl_username";
			this.lbl_username.Size = new System.Drawing.Size(99, 17);
			this.lbl_username.Text = "Abdurrahim Ayaz";
			// 
			// lbl_ipAdd
			// 
			this.lbl_ipAdd.Name = "lbl_ipAdd";
			this.lbl_ipAdd.Size = new System.Drawing.Size(69, 17);
			this.lbl_ipAdd.Text = "-192.168.1.1";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(202, 17);
			this.toolStripStatusLabel3.Spring = true;
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(180, 16);
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(202, 17);
			this.toolStripStatusLabel4.Spring = true;
			// 
			// lbl_datetime
			// 
			this.lbl_datetime.Name = "lbl_datetime";
			this.lbl_datetime.Size = new System.Drawing.Size(156, 17);
			this.lbl_datetime.Text = "Tarih: 01.01.2020 | Saat: 12:12";
			// 
			// UInterface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(926, 530);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.statusStrip1);
			this.MinimumSize = new System.Drawing.Size(873, 352);
			this.Name = "UInterface";
			this.Text = "MKT4824  - Abdurrahim Ayaz | Mustafa Yılmaz";
			this.Load += new System.EventHandler(this.UInterface_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.gbx_friends.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btn_addNewFriend;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem btn_about;
		private System.Windows.Forms.ToolStripButton connState;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_username;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel lbl_datetime;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
		private System.Windows.Forms.ToolStripMenuItem btn_alwaysTop;
		private System.Windows.Forms.ToolStripMenuItem btn_userSettings;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem btn_exit;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButton3;
		private System.Windows.Forms.ToolStripMenuItem btn_settings;
		private System.Windows.Forms.GroupBox gbx_friends;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TabControl tc_chatTabs;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ToolStripStatusLabel lbl_ipAdd;
		private System.Windows.Forms.ToolStripMenuItem btn_clearUser;
		private System.Windows.Forms.ToolStripMenuItem btn_clearFriends;
		private System.Windows.Forms.ToolStripMenuItem btn_restart;
	}
}

