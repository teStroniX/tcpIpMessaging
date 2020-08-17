using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace TcpIpMessaging
{
	public partial class ChatScreen : UserControl
	{
		// Chat Ekranı Nesnesi
		List<string> messages = new List<string>();
		TcpClient client;
		string name;
		UInterface form; // Ana Formu tutan değişken;
		Thread t; // Mesaj Almak için tanımlanan Arkaplan Thread'i.
		Thread t2; // Mesah Göndermek için tanımlanan Arkaplan Thread'i.
		public ChatScreen(UInterface form, TcpClient client, string name)
		{
			InitializeComponent();

			// Mesaj göndermek ve almak için Arkaplan Threadleri tanımlanır.
			t = new Thread(MessageListener);
			t2 = new Thread(MessageSender);

			// Mesaj göndermek ve almak için tanımlanan Theadler başlatılır.
			t.Start(client);
			t2.Start(client);

			this.client = client;
			this.name = name;
			this.form = form;

			// Ana Formdaki Bağlantı durumunu gösteren image güncellenir.
			form.setConnState(Properties.Resources.checked_green);
		}

		// Mesajları arkaplanda alan Thread.
		private void MessageListener(object o)
		{
			// Değişkenler tanımlanır.
			TcpClient aaa = (TcpClient)o;
			NetworkStream stream = aaa.GetStream();
			byte[] buffer = new byte[1024];
			string nameLineText;
			int nameLineIndex;
			string messageLineText;
			int messageLineIndex;
			int buffer_size;
			string data;

			while (true)
			{
				try
				{
					// Buffer byte[] olarak alınır ve string değerine dönüştürülür.
					buffer_size = stream.Read(buffer, 0, buffer.Length);

					if (buffer_size != 0)
					{
						data = Encoding.UTF8.GetString(buffer, 0, buffer_size);

						// Mesaj sağ tarafa yaslanarak gösterilir.
						if (txb_messagePanel.InvokeRequired)
						{
							txb_messagePanel.BeginInvoke(new MethodInvoker(delegate
							{
								txb_messagePanel.AppendText("\n" + name + "(" + DateTime.Now.ToString("HH:mm") + "):\n" + data);

								nameLineText = txb_messagePanel.Lines[txb_messagePanel.Lines.Count() - 2];
								nameLineIndex = txb_messagePanel.Text.LastIndexOf(nameLineText);
								messageLineText = txb_messagePanel.Lines[txb_messagePanel.Lines.Count() - 1];
								messageLineIndex = txb_messagePanel.Text.LastIndexOf(messageLineText);

								txb_messagePanel.SelectionStart = nameLineIndex;
								txb_messagePanel.SelectionLength = nameLineText.Length;
								txb_messagePanel.SelectionAlignment = HorizontalAlignment.Right;
								txb_messagePanel.SelectionFont = new Font(txb_messagePanel.Font, FontStyle.Bold);

								txb_messagePanel.SelectionStart = messageLineIndex;
								txb_messagePanel.SelectionLength = messageLineText.Length - 1;
								txb_messagePanel.SelectionAlignment = HorizontalAlignment.Right;
								txb_messagePanel.SelectionFont = new Font(txb_messagePanel.Font, FontStyle.Regular);
								txb_messagePanel.ScrollToCaret();
								txb_messagePanel.DeselectAll();
							}));
						}
						else
						{
							txb_messagePanel.AppendText("\n" + name + " (" + DateTime.Now.ToString("HH:mm") + "):\n" + data);

							nameLineText = txb_messagePanel.Lines[txb_messagePanel.Lines.Count() - 2];
							nameLineIndex = txb_messagePanel.Text.LastIndexOf(nameLineText);
							messageLineText = txb_messagePanel.Lines[txb_messagePanel.Lines.Count() - 1];
							messageLineIndex = txb_messagePanel.Text.LastIndexOf(messageLineText);

							txb_messagePanel.SelectionStart = nameLineIndex;
							txb_messagePanel.SelectionLength = nameLineText.Length;
							txb_messagePanel.SelectionAlignment = HorizontalAlignment.Right;
							txb_messagePanel.SelectionFont = new Font(txb_messagePanel.Font, FontStyle.Bold);

							txb_messagePanel.SelectionStart = messageLineIndex;
							txb_messagePanel.SelectionLength = messageLineText.Length - 1;
							txb_messagePanel.SelectionAlignment = HorizontalAlignment.Right;
							txb_messagePanel.SelectionFont = new Font(txb_messagePanel.Font, FontStyle.Regular);
							txb_messagePanel.ScrollToCaret();
							txb_messagePanel.DeselectAll();
						}
					}
				}
				catch (Exception ex)
				{
					// Bağlantı kopması durumunda Ana Formdaki bağlantı durumunu gösteren image güncellenir.
					if (!aaa.Connected)
					{
						if (InvokeRequired)
						{
							BeginInvoke(new MethodInvoker(delegate
							{
								txb_message.Enabled = false;
							}));
						}
						else
							txb_message.Enabled = false;
						form.setConnState(Properties.Resources.checked_red);
						break;
					}
					// Hataları MessageBox nesnesinde gösterir.
					else
					{
						MessageBox.Show(ex.Message);
					}
				}
				Thread.Sleep(100);
			}
		}

		// Mesajları arkaplanda gönderen Thread fonksyionu.
		private void MessageSender(object o)
		{
			// Değişkenler tanımlanır.
			TcpClient aaa = (TcpClient)o;
			NetworkStream stream;
			byte[] buffer;
			byte[] send_buffer;

			while (true)
			{
				try
				{
					// Sırada bekleyen mesajlar birer birer byte[]'a dönüştürülür ve Client'a gönderilir.
					stream = aaa.GetStream();
					buffer = new byte[1024];

					for (int i = messages.Count - 1; i >= 0; i--)
					{
						send_buffer = new byte[1024];
						send_buffer = Encoding.UTF8.GetBytes(messages[i]);
						stream.Write(send_buffer, 0, send_buffer.Length);
						messages.RemoveAt(i);
					}
				}
				catch (Exception ex)
				{
					// Bağlantı kopması durumunda Ana Formdaki bağlantı durumunu gösteren image güncellenir.
					if (!aaa.Connected)
					{
						if(InvokeRequired)
						{
							BeginInvoke(new MethodInvoker(delegate
							{
								txb_message.Enabled = false;
							}));
						}
						else
							txb_message.Enabled = false;

						form.setConnState(Properties.Resources.checked_red);
						break;
					}
					// Hataları MessageBox nesnesinde gösterir.
					else
					{
						MessageBox.Show(ex.Message);
					}
				}
				Thread.Sleep(100);
			}
		}

		// Gönder butonu tıklama eventi.
		private void btn_send_Click(object sender, EventArgs e)
		{
			// Mesaj Girilmişse Mesajlar listesine eklenir ve sola yaslanarak mesajlaşma ekranında gösterilir.
			if (txb_message.Text.Length > 0)
			{
				messages.Add(txb_message.Text);
				txb_messagePanel.AppendText("\n" + "Ben (" + DateTime.Now.ToString("HH:mm") + "):\n" + txb_message.Text);

				string nameLineText = txb_messagePanel.Lines[txb_messagePanel.Lines.Count() - 2];
				int nameLineIndex = txb_messagePanel.Text.LastIndexOf(nameLineText);
				string messageLineText = txb_messagePanel.Lines[txb_messagePanel.Lines.Count() - 1];
				int messageLineIndex = txb_messagePanel.Text.LastIndexOf(messageLineText);

				txb_messagePanel.SelectionStart = nameLineIndex;
				txb_messagePanel.SelectionLength = nameLineText.Length;
				txb_messagePanel.SelectionAlignment = HorizontalAlignment.Left;
				txb_messagePanel.SelectionFont = new Font(txb_messagePanel.Font, FontStyle.Bold);

				txb_messagePanel.SelectionStart = messageLineIndex;
				txb_messagePanel.SelectionLength = messageLineText.Length - 1;
				txb_messagePanel.SelectionAlignment = HorizontalAlignment.Left;
				txb_messagePanel.SelectionFont = new Font(txb_messagePanel.Font, FontStyle.Regular);
				txb_messagePanel.ScrollToCaret();
				txb_messagePanel.DeselectAll();

				txb_message.Clear();
			}
		}

		// Arkaplan threadlerini kapatma fonksiyonu;
		public void CloseThreads()
		{
			t.Abort();
			t2.Abort();
		}

		// Tekrar bağlanmayı dener.
		public void StartThreads()
		{
			t.Start();
			t2.Start();
			form.setConnState(Properties.Resources.checked_green);
		}

		// Mesaj yazma TextBox'ında entera basınca göndermeyi tetikler.
		private void txb_message_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter && e.Shift)
			{
				txb_message.AppendText("\n");
				e.SuppressKeyPress = true;
			}
			else if (e.KeyData == Keys.Enter)
			{
				e.SuppressKeyPress = true;
				btn_send_Click(new object(), new EventArgs());
			}

		}
	}
}
