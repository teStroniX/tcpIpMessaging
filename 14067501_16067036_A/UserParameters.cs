using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpIpMessaging
{
	// Kullanıcı verilerinin tutulduğu UserParametes nesnesi.
	public class UserParameters
	{
		public string name { get; set; }
		public string ipAddress { get; set; }

		public UserParameters(string name, string ipAddress)
		{
			this.name = name;
			this.ipAddress = ipAddress;
		}

		public UserParameters()
		{

		}
	}
}
