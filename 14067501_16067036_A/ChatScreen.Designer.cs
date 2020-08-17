namespace TcpIpMessaging
{
	partial class ChatScreen
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_send = new System.Windows.Forms.Button();
			this.txb_message = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.txb_messagePanel = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_send
			// 
			this.btn_send.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_send.Location = new System.Drawing.Point(900, 3);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(121, 23);
			this.btn_send.TabIndex = 1;
			this.btn_send.Text = "Gönder";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
			// 
			// txb_message
			// 
			this.txb_message.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_message.Location = new System.Drawing.Point(3, 3);
			this.txb_message.Multiline = true;
			this.txb_message.Name = "txb_message";
			this.txb_message.Size = new System.Drawing.Size(891, 74);
			this.txb_message.TabIndex = 2;
			this.txb_message.WordWrap = false;
			this.txb_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_message_KeyDown);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.txb_message, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_send, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 460);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 80);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// txb_messagePanel
			// 
			this.txb_messagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_messagePanel.Location = new System.Drawing.Point(0, 0);
			this.txb_messagePanel.Name = "txb_messagePanel";
			this.txb_messagePanel.ReadOnly = true;
			this.txb_messagePanel.Size = new System.Drawing.Size(1024, 460);
			this.txb_messagePanel.TabIndex = 4;
			this.txb_messagePanel.Text = "";
			// 
			// ChatScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txb_messagePanel);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "ChatScreen";
			this.Size = new System.Drawing.Size(1024, 540);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.TextBox txb_message;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RichTextBox txb_messagePanel;
	}
}
