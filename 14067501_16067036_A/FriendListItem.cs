using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIpMessaging
{
	public partial class FriendListItem : UserControl
	{
		public string name;
		public string ipAddress;

		// Arkadaşlar listesinde görüntülenecek olan arkadaş nesnesi
		public FriendListItem(string name, string ipAddress, EventHandler handler)
		{
			InitializeComponent();
			this.name = name;
			this.ipAddress = ipAddress;
			lbl_name.Text = name;
			lbl_ipAddress.Text = ipAddress;

			lbl_ipAddress.Click += handler;
			lbl_name.Click += handler;
			pictureBox1.Click += handler;
		}
	}
}
