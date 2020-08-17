using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpIpMessaging
{
	public partial class AddNewFriend : Form
	{
		// Yeni arkadaş ekleme formu.
		UInterface form;
		string name;
		string ipAddress;
		AwaitConnection await;
		bool finished = false;
		public AddNewFriend(UInterface form, string name, string ipAddress)
		{
			InitializeComponent();
			this.name = name;
			this.ipAddress = ipAddress;
			this.form = form;
		}

		// Arkadaş ekleme isteği gönderir.
		private void button1_Click(object sender, EventArgs e)
		{
			new Thread(() =>
			{
				TcpClient client = new TcpClient();
				IPAddress ip = IPAddress.Parse(txb_ipAddress.Text);
				client.Connect(ip, 5561);
				byte[] buffer = Encoding.UTF8.GetBytes(GetConnectionString());
				client.GetStream().Write(buffer, 0, buffer.Length);

				buffer = new byte[1024];
				int buffer_size = client.GetStream().Read(buffer, 0, buffer.Length);

				if (buffer_size > 0)
				{
					string ans = Encoding.UTF8.GetString(buffer, 0, buffer_size);

					string[] answer = ans.Split('|');

					if (answer.Length > 0)
					{
						if (answer[0] == "--5562--" && answer[answer.Length - 1] == "--5562--")
						{
							string name = answer[1];
							string ipAdr = answer[2];

							if (InvokeRequired)
							{
								BeginInvoke(new MethodInvoker(delegate
								{
									form.addFriend(name, ipAdr);
									await.Close();
									this.Close();
								}));
							}
							else
							{
								form.addFriend(name, ipAdr);
								await.Close();
								this.Close();
							}
						}
					}
					else if(answer.Length > 0)
					{
						if(answer[0] == "--0--")
						{
							MessageBox.Show("Kullanıcı Arkadaşlık İsteğini Reddetti!","Arkadaşlık İsteği",MessageBoxButtons.OK,MessageBoxIcon.Information);
							BeginInvoke(new MethodInvoker(delegate
							{
								await.Close();
								this.Close();
							}));
						}
					}
				}
				BeginInvoke(new MethodInvoker(delegate
				{
					await.Close();
					this.Close();
				}));
			}).Start();

			await = new AwaitConnection(txb_ipAddress.Text);
			var dialogResult = await.ShowDialog();
			if (dialogResult == DialogResult.No)
				this.Close();
		}
		public string GetConnectionString()
		{
			StringBuilder builder = new StringBuilder();

			builder.Append("--5562--").Append("|");
			builder.Append(name).Append("|");
			builder.Append(ipAddress).Append("|");
			builder.Append("--5562--");

			return builder.ToString();
		}

		private void AddNewFriend_Load(object sender, EventArgs e)
		{
			/*
			dataGridView1.Columns.Add("NAME", "Kullanıcı Adı");
			dataGridView1.Columns.Add("IP", "IP Adresi");
			new Thread(() =>
			{
				TcpListener listener = new TcpListener(IPAddress.Any, 5561);
				listener.Start();
				while(!finished)
				{
					TcpClient client = listener.AcceptTcpClient();
					byte[] buffer = new byte[1024];
					int size = client.GetStream().Read(buffer, 0, buffer.Length);

					string answer = Encoding.UTF8.GetString(buffer, 0, size);

					string[] answers = answer.Split('|');

					if(answers[0] == "--5560--" && answers[3] == "--5560--")
					{
						int row = dataGridView1.Rows.Add();
						dataGridView1.Rows[row].Cells[0].Value = answers[1];
						dataGridView1.Rows[row].Cells[1].Value = answers[2];
					}
				}
			}).Start();

			new Thread(() =>
			{
				string ip = ipAddress.Substring(0, ipAddress.LastIndexOf("."));
				for (int i = 1; i <= 255; i++)
				{
					IPAddress ipadd = IPAddress.Parse(ip + i);
					TcpClient client = new TcpClient();
					client.Connect(ipadd, 5561);

					StringBuilder builder = new StringBuilder();

					builder.Append("--5560--").Append("|");
					builder.Append(name).Append("|");
					builder.Append(ipAddress).Append("|");
					builder.Append("--5560--");

					// İsteğin kabul edildiğine yönelik mesaj gönderilir.
					byte[] msg = Encoding.UTF8.GetBytes(builder.ToString());
					client.GetStream().Write(msg, 0, msg.Length);
				}
			}).Start();
			*/
		}
	}
}
