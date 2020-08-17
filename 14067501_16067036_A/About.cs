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
	public partial class About : Form
	{
		// Hakkında Formu
		public About(string text)
		{
			InitializeComponent();
			lbl_text.Text = text;
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
