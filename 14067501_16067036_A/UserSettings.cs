using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TcpIpMessaging
{
	public partial class UserSettings : Form
	{
		UInterface form; // Formu çağıran form verisini tutan değişken.
		bool enable_close = false; // Formun kapatılmasına izin veren değişken.
		public UserSettings(UInterface form ,bool enable_cancel)
		{
			InitializeComponent();
			// Global değişkenler tannımlanır.
			this.form = form;
			btn_cancel.Enabled = enable_cancel;
		}

		private void UserSettings_Load(object sender, EventArgs e)
		{
			// Daha önceden oluşturulmuş kullanıcı bilgilerini kontrol eder.
			if (File.Exists("userParameters"))
			{
				// Xml dosyası okunur ve uygun yerlere yazılır.
				string parameters = File.ReadAllText("userParameters");
				XmlSerializer serializer = new XmlSerializer(typeof(UserParameters));
				UserParameters param = (UserParameters)serializer.Deserialize(new StringReader(parameters));

				txb_username.Text = param.name;
				txb_ipAddress.Text = param.ipAddress;
			}
		}

		// IP Adresini otomatik tanımlayan buton tıklama eventi.
		private void btn_set_Click(object sender, EventArgs e)
		{
			txb_ipAddress.Text = GetLocalIPAddress();
		}

		// IP Adresini sistemden otomatik çeken fonksiyon.
		public static string GetLocalIPAddress()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				//if (ip.AddressFamily == AddressFamily.InterNetwork)
				//{
					string s = ip.ToString();
					var ans = MessageBox.Show(s + " Adresi Kabul Ediyor Musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (ans == DialogResult.Yes)
						return s;
				//}
			}
			return "";
		}

		// İptal butonu tıklama eventi.
		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.enable_close = true;
			this.Close();
		}

		// Kaydet butonu tıklama eventi.
		private void btn_save_Click(object sender, EventArgs e)
		{
			// Gerekli alanların doldurulup doldurulmadığı kontrol edilir.
			if (txb_ipAddress.Text == "")
			{
				MessageBox.Show("İP Adres Tanımlaması Yapmanız Gerekmektedir!");
			}
			else if (txb_username.Text == "")
			{
				MessageBox.Show("Kullanıcı Adı Tanımlaması Yapmanız Gerekmektedir!");
			}
			else
			{
				// Xml dosyasına veriler yazılır.
				StreamWriter writer = new StreamWriter("userParameters");
				XmlSerializer serializer = new XmlSerializer(typeof(UserParameters));
				serializer.Serialize(writer, new UserParameters(txb_username.Text, txb_ipAddress.Text));
				writer.Close();

				// Ana Forma veriler yazılır.
				form.setName(txb_username.Text);
				form.setIpAddress(txb_ipAddress.Text);

				// Form kapatılır.
				this.enable_close = true;
				this.Close();
			}
		}

		private void UserSettings_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Eğer formun kapatılmasına izin verilmemişse kapatılmaz.
			if (!this.enable_close)
				e.Cancel = true;
		}
	}
}
