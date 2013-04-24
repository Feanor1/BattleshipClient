using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BattleshipClient {
	class UserHandler : IAuthenticator, IRegistrator {

		private PortSender ps;

		public UserHandler(PortSender ps) {
			this.ps = ps;
		}

		public UserAccount Login(string Name, string Password) {
			object[] args = new object[2];
			args[0] = Name;
			args[1] = Password;
			return (UserAccount)ps.Send("authenticator", "Login", args);
		}

		public bool Register(string UserName, string PassHash, bool UserType) {
			object[] args = new object[3];
			args[0] = UserName;
			args[1] = PassHash;
			args[2] = UserType;

			Console.WriteLine("0000");
			bool response = (bool)ps.Send("registrator", "Register", args);
			Console.WriteLine("aaa");
			return response;


		}

	}
}
