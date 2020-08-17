using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIpMessaging
{
	public partial class AwaitConnection : Form
	{
		// Bağlantı Bekleniyor formu.
		public AwaitConnection(string text)
		{
			InitializeComponent();
			lbl_text.Text = text + " " + @"
							Kullanıcısının Yanıtı Bekleniyor..";
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.No;
			this.Close();
		}
	}
}
