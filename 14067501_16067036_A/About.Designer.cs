namespace TcpIpMessaging
{
	partial class About
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lbl_text = new System.Windows.Forms.Label();
			this.btn_close = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lbl_text, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_close, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 77);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lbl_text
			// 
			this.lbl_text.AutoSize = true;
			this.lbl_text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_text.Location = new System.Drawing.Point(3, 0);
			this.lbl_text.Name = "lbl_text";
			this.lbl_text.Padding = new System.Windows.Forms.Padding(20);
			this.lbl_text.Size = new System.Drawing.Size(235, 48);
			this.lbl_text.TabIndex = 0;
			this.lbl_text.Text = "label1";
			this.lbl_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn_close
			// 
			this.btn_close.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_close.Location = new System.Drawing.Point(3, 51);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(235, 23);
			this.btn_close.TabIndex = 1;
			this.btn_close.Text = "Kapat";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(241, 77);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "About";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Hakkında";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lbl_text;
		private System.Windows.Forms.Button btn_close;
	}
}