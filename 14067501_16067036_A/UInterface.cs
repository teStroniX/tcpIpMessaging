using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TcpIpMessaging
{
	public partial class UInterface : Form
	{
		BackgroundWorker getClients; // Arkaplanda Gelen İstekleri Arayan Thread.
		TcpClient client; // Chat Ekranına yollanacak olan Global Client Değişkeni
		System.Windows.Forms.Timer datetime; // Tarih ve Saat bilgisini ekrana yazdıracak olan Timer Değişkeni.

		// Kullanıcının Adını ve IP Adresini tutan global değişkenler.
		string name;
		string ipAddress;

		public UInterface()
		{
			InitializeComponent();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			// Tüm Chat Tablerinin arkaplan threadlerini kapatır.
			foreach(TabPage tp in tc_chatTabs.TabPages)
			{
				ChatScreen cs = (ChatScreen)tp.Controls[0];
				cs.CloseThreads();
			}
			// Uygulamayı tüm çevre bileşenleriyle birlikte kapatır.
			Environment.Exit(Environment.ExitCode);
		}

		private void UInterface_Load(object sender, EventArgs e)
		{
			// Eğer Kullanıcı Bilgileri girilmişse onları çeker.
			// Daha Önceden Girilmiş Kullanıcı Bilgisi yoksa başlangıçta bilgi girme ekranı açar.
			if (!File.Exists("userParameters"))
			{
				UserSettings frm = new UserSettings(this, false);
				frm.ShowDialog();
			}
			else
			{
				string parameters = File.ReadAllText("userParameters");
				XmlSerializer serializer = new XmlSerializer(typeof(UserParameters));
				UserParameters param = (UserParameters)serializer.Deserialize(new StringReader(parameters));
				this.setName(param.name);
				this.setIpAddress(param.ipAddress);
			}

			// Daha önceden tanımlanmış arkadaşlar bilgisi var mı yok mu kontrolü yapar.
			if(File.Exists("friends"))
			{
				string fileString = File.ReadAllText("friends");
				XmlSerializer serializer = new XmlSerializer(typeof(List<UserParameters>));
				List<UserParameters> friends = (List<UserParameters>)serializer.Deserialize(new StringReader(fileString));

				foreach(UserParameters item in friends)
				{
					FriendListItem f = new FriendListItem(item.name, item.ipAddress, FriendClick);

					tableLayoutPanel1.RowCount++;
					tableLayoutPanel1.Controls.Add(f, 1, tableLayoutPanel1.RowCount - 2);
					tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
					tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 2].SizeType = SizeType.AutoSize;
				}
			}

			// Tarih saat bilgisini ekrana yazdıran Timer Değişkeni saniyede bir çalışacak şekilde tanımlanır ve başlatılır.
			datetime = new System.Windows.Forms.Timer();
			datetime.Interval = 1000;
			datetime.Tick += Datetime_Tick;
			datetime.Start();

			// Client bekleyen arkaplan Threadi tanımlanıt ve başlatılır.
			getClients = new BackgroundWorker();
			getClients.DoWork += ControlClients;
			getClients.WorkerSupportsCancellation = true;
			getClients.RunWorkerCompleted += GetClients_RunWorkerCompleted;
			getClients.RunWorkerAsync();
		}

		// Tarih saat bilgisini ekrana yazdıran timer fonksiyonu.
		private void Datetime_Tick(object sender, EventArgs e)
		{
			datetime.Stop();
			lbl_datetime.Text = "Tarih: " + DateTime.Now.ToString("dd/MM/yyyy") +" | Saat: " + DateTime.Now.ToString("HH:mm:ss");
			datetime.Start();
		}

		// Arkaplan isteklerini bekleyen thread bittikten sonra tekrar başlar ve bu şekilde sürekli olarak istek beklenir.
		private void GetClients_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			getClients.RunWorkerAsync();
		}

		//Arkaplan isteklerini bekleyen thread fonksiyonu.
		private void ControlClients(object sender, DoWorkEventArgs e)
		{
				// 5561 Portu sürekli olarak taranır.
				TcpListener ServerSocket = new TcpListener(IPAddress.Any, 5561);
				ServerSocket.Start();
				// İstek gönderen client tanımlanır.
				TcpClient client = ServerSocket.AcceptTcpClient();

			if (InvokeRequired)
			{
				BeginInvoke(new MethodInvoker(delegate
				{

					byte[] buffer = new byte[1024];
					// İstek gönderen mesaj byte olarak alınır ve sonrasında UTF8 kodlamasıyla stringe dönüştürülür.
					int buffer_size = client.GetStream().Read(buffer, 0, buffer.Length);
					string bufferString = Encoding.UTF8.GetString(buffer, 0, buffer_size);

					// Mesajlarda ayırıcı olarak | karakteri tanımlanmıştır. Bu şekilde mesaj parçalanır.
					string[] messages = bufferString.Split('|');

					// Mesajın ilk ve son kısmı --5561-- ise bu bir sohbet başlatma isteğidir.
					if (messages[0] == "--5561--" && messages[messages.Length - 1] == "--5561--")
					{
						// Sohbet başlatma isteği yanıtlanır.
						var ans = MessageBox.Show(messages[1] + "(" + messages[2] + ")" + " Sizinle Yeni Bit Sohbet Başlatmak İstiyor!", "Yeni Sohbet İsteği!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (ans == DialogResult.Yes) // Eğer sohbet başlatma isteği kabul edilmişse.
						{
							// İsteğin kabul edildiğine yönelik mesaj gönderilir.
							byte[] write_buffer = new byte[1024];
							write_buffer = Encoding.UTF8.GetBytes(GetConnectionString());
							client.GetStream().Write(write_buffer, 0, write_buffer.Length);

							// Yeni bir Chat Ekranı başlatılır ve TabControl nesnesine eklenir.
							TabPage page = new TabPage(messages[1]);
							ChatScreen chatScreen = new ChatScreen(this, client, messages[1]);
							chatScreen.Dock = DockStyle.Fill;
							page.Controls.Add(chatScreen);

							tc_chatTabs.TabPages.Add(page);
							tc_chatTabs.SelectedIndex = tc_chatTabs.TabPages.Count - 1;
						}
						else if (ans == DialogResult.No)
						{
							// İsteğin reddedildiğine yönelik mesaj gönderilir.
							byte[] write_buffer = new byte[1024];
							write_buffer = Encoding.UTF8.GetBytes("--0--");
							client.GetStream().Write(write_buffer, 0, write_buffer.Length);
						}
					}
					// Mesajın ilk ve son kısmı --5562-- ise bu bir arkaşlık isteğidir.
					else if (messages[0] == "--5562--" && messages[messages.Length - 1] == "--5562--")
					{
						// Arkaşlık isteği yanıtlanır.
						var ans = MessageBox.Show(messages[1] + "(" + messages[2] + ")" + " Sizinle Arkadaş Olmak İstiyor!", "Yeni Arkadaşlık İsteği!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
						if (ans == DialogResult.Yes) // Eğer arkadaşlık isteği kabul edilmişse.
						{
							// İsteğin kabul edildiğine yönelik mesaj oluşturulur.
							StringBuilder builder = new StringBuilder();

							builder.Append("--5562--").Append("|");
							builder.Append(name).Append("|");
							builder.Append(ipAddress).Append("|");
							builder.Append("--5562--");

							// İsteğin kabul edildiğine yönelik mesaj gönderilir.
							byte[] msg = Encoding.UTF8.GetBytes(builder.ToString());
							client.GetStream().Write(msg, 0, msg.Length);
							// Yeni arkadaş ekleme fonksiyonu çalıştırılır.
							addFriend(messages[1], messages[2]);
						}
						else if (ans == DialogResult.No)
						{
							byte[] msg = Encoding.UTF8.GetBytes("--0--");
							client.GetStream().Write(msg, 0, msg.Length);
						}
					}
					// Mesajın ilk ve son kısmı --5562-- ise bu bir ağ sorgulama isteğidir.
					else if (messages[0] == "--5560--" && messages[messages.Length - 1] == "--5560--")
					{
						MessageBox.Show("--");
						// İsteğe Cevaben IP Adresi Yollanır.
						StringBuilder builder = new StringBuilder();

						builder.Append("--5560--").Append("|");
						builder.Append(name).Append("|");
						builder.Append(ipAddress).Append("|");
						builder.Append("--5560--");

						// İsteğin kabul edildiğine yönelik mesaj gönderilir.
						byte[] msg = Encoding.UTF8.GetBytes(builder.ToString());
						client.GetStream().Write(msg, 0, msg.Length);
					}
				}));
			}
		}

		// Yeni arkadaş ekleme butonu tıklama eventi.
		private void btn_addNewFriend_Click(object sender, EventArgs e)
		{
			// Yeni arkadaş ekleme formu açılır.
			AddNewFriend form = new AddNewFriend(this, name, ipAddress);
			form.ShowDialog();
		}

		// Bağlantı istek metnini oluşturan fonksiyon.
		public string GetConnectionString()
		{
			StringBuilder builder = new StringBuilder();

			builder.Append("--5561--").Append("|");
			builder.Append(name).Append("|");
			builder.Append(ipAddress).Append("|");
			builder.Append("--5561--");

			return builder.ToString();
		}

		//  Her zaman üstte butonu tıklama eventi.
		private void btn_alwaysTop_Click(object sender, EventArgs e)
		{
			// Uygulamanın Her zaman üstte kalmasını sağlar;
			ToolStripMenuItem btn = (ToolStripMenuItem)sender;
			
			if(btn.Checked)
			{
				this.TopMost = false;
				btn.Checked = false;
			}
			else
			{
				this.TopMost = true;
				btn.Checked = true;
			}
		}

		// Kullanıcı Seçenekleri butonu tıklama eventi.
		private void btn_userSettings_Click(object sender, EventArgs e)
		{
			// Kullanıcı seçenekleri formunu başlatır.
			UserSettings frm = new UserSettings(this, true);
			frm.ShowDialog();
		}

		// Global name değişkeni tanımlama fonksiyonu.
		public void setName(string name)
		{
			// Global name değişkeni tanımlanırken kullanıcı adının gösterildiği label da güncellenir.
			this.name = name;
			lbl_username.Text = name;
		}

		// Global ipAddress değişkeni tanımlama fonksiyonu.
		public void setIpAddress(string ipAddress)
		{
			// Global ipAddress değişkeni tanımlanırken IP Adresinin gösterildiği label da güncellenir.
			this.ipAddress = ipAddress;
			lbl_ipAdd.Text = "- " + ipAddress;
		}

		// Yeni Arkadaş Ekleme fonksiyonu.
		public void addFriend(string name, string ipAddress)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<UserParameters>));

			// Daha önceden eklenmiş arkadaşlar var mı yok mu kontrolü yapılır.
			if (File.Exists("friends")) // Daha önceden eklenmiş arkadaşlar varsa.
			{
				// Daha önceden eklenmiş arkadaşlar xml dosyasından okunur.
				string fileString = File.ReadAllText("friends");
				List<UserParameters> friends = (List<UserParameters>)serializer.Deserialize(new StringReader(fileString));

				// Eklenmek istenen arkadaş önceki arkadaşlar arasında var mı yok mu kontrolü yapılır.
				foreach (UserParameters item in friends)
				{
					if (item.ipAddress == ipAddress)
					{
						MessageBox.Show(name + " ile zaten Arkadaşsınız!", "Arkadaş Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
				}

				// Yeni arkadaş arkadaşlar listesine eklenir.
				friends.Add(new UserParameters(name, ipAddress));
				serializer.Serialize(new StreamWriter("friends"), friends);

				// Yeni eklenen arkadaş arkadaşlar menüsünde gösterilir.
				FriendListItem f = new FriendListItem(name, ipAddress, FriendClick);

				tableLayoutPanel1.RowCount++;
				tableLayoutPanel1.Controls.Add(f, 1, tableLayoutPanel1.RowCount - 2);
				tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
				tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 2].SizeType = SizeType.AutoSize;
			}
			else
			{
				// Yeni arkadaş yeni bir xml dosyası açılarak içine kaydedilir.
				List<UserParameters> friends = new List<UserParameters>();

				friends.Add(new UserParameters(name, ipAddress));
				serializer.Serialize(new StreamWriter("friends"), friends);

				// Yeni eklenen arkadaş arkadaşlar menüsünde gösterilir.
				FriendListItem f = new FriendListItem(name, ipAddress, FriendClick);

				tableLayoutPanel1.RowCount++;
				tableLayoutPanel1.Controls.Add(f, 1, tableLayoutPanel1.RowCount - 2);
				tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
				tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 2].SizeType = SizeType.AutoSize;
			}
		}

		// Arkadaşa nesnesine tıklama eventi.
		private void FriendClick(object sender, EventArgs e)
		{
			// Arkadaş nesnesinden isim ve IP Adresi verileri alınır.
			FriendListItem item = ((FriendListItem)((Label)sender).Parent.Parent.Parent);
			AwaitConnection await = new AwaitConnection(item.name + "(" + item.ipAddress + ")");

			// Bağlantı için yeni bir thread oluşturulur.
			Thread t = new Thread(() =>
			{
				// Sohbet başlatma isteği oluşturulur.
				TcpClient client = new TcpClient();
				IPAddress ip = IPAddress.Parse(item.ipAddress);
				client.Connect(ip, 5561);
				byte[] buffer = Encoding.UTF8.GetBytes(GetConnectionString());
				client.GetStream().Write(buffer, 0, buffer.Length);
				this.client = client;

				// Sohbet başlatma cevabı beklenir.
				buffer = new byte[1024];
				int buffer_size = client.GetStream().Read(buffer, 0, buffer.Length);

				if (buffer_size > 0)
				{
					// Cevabın isteklere uygunluğu kontrol edilir.
					string ans = Encoding.UTF8.GetString(buffer, 0, buffer_size);

					string[] answer = ans.Split('|');

					if(answer.Length > 1)
					{
						if (answer[0] == "--5561--" && answer[answer.Length - 1] == "--5561--")
						{
							// Uygun cevap gelmişse yeni bir Chat Ekranı oluşturulur.
							this.name = answer[1];
							TabPage page = new TabPage(name);
							ChatScreen chatScreen = new ChatScreen(this, client, name);
							chatScreen.Dock = DockStyle.Fill;
							page.Controls.Add(chatScreen);

							// Chat Ekranı TabControl arayüzüne eklenir.
							if (InvokeRequired)
							{
								BeginInvoke(new MethodInvoker(delegate
								{
									tc_chatTabs.TabPages.Add(page);
									tc_chatTabs.SelectedIndex = tc_chatTabs.TabPages.Count - 1;
									await.Close();
								}));
							}
							else
							{
								tc_chatTabs.TabPages.Add(page);
								tc_chatTabs.SelectedIndex = tc_chatTabs.TabPages.Count - 1;
								await.Close();
							}
						}
					}
					else if(answer.Length > 0)
					{
						if(answer[0]=="--0--")
						{
							MessageBox.Show("Kullanıcı Görüşme İsteğini Kabul Etmedi!","Görüşme İsteği",MessageBoxButtons.OK,MessageBoxIcon.Information);
							BeginInvoke(new MethodInvoker(delegate
							{
								await.Close();
							}));
						}
					}
				}
				BeginInvoke(new MethodInvoker(delegate
				{
					await.Close();
				}));
			});
			t.Start();

			// İptal Tuşuna basılması durumunda thread iptal edilir.
			var dialogResult = await.ShowDialog();
			if(dialogResult == DialogResult.No)
			{
				t.Abort();
			}
		}

		// Bağlantı durumunu gösteren PictureBox güncellemek için fonksyion.
		public void setConnState(Image image)
		{
			connState.Image = image;
		}

		// Yeniden bağlanmayı dener.
		private void connState_Click(object sender, EventArgs e)
		{
			ChatScreen cs = (ChatScreen)tc_chatTabs.TabPages[tc_chatTabs.SelectedIndex].Controls[0];
		}

		// Hakkında butonu tıklama eventi.
		private void btn_about_Click(object sender, EventArgs e)
		{
			About form = new About(Properties.Resources.about);
			form.ShowDialog();
		}

		// Çıkış butonu tıklama eventi.
		private void btn_exit_Click(object sender, EventArgs e)
		{
			foreach (TabPage tp in tc_chatTabs.TabPages)
			{
				ChatScreen cs = (ChatScreen)tp.Controls[0];
				cs.CloseThreads();
			}
			Environment.Exit(Environment.ExitCode);
		}

		// Kullanıcı verilerini temizle butonu tıklama eventi.
		private void btn_clearUser_Click(object sender, EventArgs e)
		{
			// Kullanıcı verilerini tutan xml dosyası silinir.
			File.Delete("userParameters");
			// Program yeniden başlatılır.
			System.Diagnostics.Process.Start(Application.ExecutablePath);
			this.Close();
		}

		// Arkadaş verilerini temizle butonu tıklama eventi.
		private void btn_clearFriends_Click(object sender, EventArgs e)
		{
			// Arkadaşlar verilerini tutan xml dosyası silinir.
			File.Delete("friends");
			// Program yeniden başlatılır.
			System.Diagnostics.Process.Start(Application.ExecutablePath);
			this.Close();
		}

		// Yeniden başlat butonu tıklama eventi
		private void btn_restart_Click(object sender, EventArgs e)
		{
			// Program yeniden başlatılır.
			System.Diagnostics.Process.Start(Application.ExecutablePath);
			this.Close();
		}
	}
}
