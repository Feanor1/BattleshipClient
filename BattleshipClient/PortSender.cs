using System;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BattleshipClient
{
	public class PortSender
	{

		private TcpClient tc;
		public PortSender() {
			tc = new TcpClient();

		}
		
		
		public static byte[] createMessage(string controller, string method, object[] args) {
			if ((method == "Register") || (method == "Login")) {
				args[1] = CalculateMD5Hash( (string)args[0] + (string)args[1] + "abc" );
			}
			
			string str = controller + ";" + method + ";" + SimpleXmlSerializer.Serialize(args) + "\n";
			Console.WriteLine(str);
			
			return Encoding.UTF8.GetBytes(str.ToCharArray());
		}

		public bool Connect(string address, int port = 5000) {
			try {
				tc.Connect(address, port);
				NetworkStream s = tc.GetStream();
				return true;
			}
			catch {
				if (port != 5001) {
					return Connect(address, 5001);
				} 
			}
			return false;
		}

		public void Disconnect() {
			tc.Close();
		}
		
		public object Send(string controller, string method, object[] args ) {
			Byte[] b;
				
			b = createMessage(controller, method, args);
			
			NetworkStream s = tc.GetStream();
			s.Write(b, 0, b.Length);
			
			Thread.Sleep(1500);

			#region controller method párok
		/*	var a = Assembly.GetCallingAssembly();
			var t = a.GetType(controller);
			var types = a.GetTypes();
			var mi = t.GetMethod(method);
			Type rv = mi.ReturnType;

			MethodInfo m = typeof(SimpleXmlSerializer).GetMethod("Deserialize").MakeGenericMethod(new Type[] { rv });
			rv.Invoke(this, new object { read(tc) });*/

			//return SimpleXmlSerializer.Deserialize<typeof(rv)>(read(tc));
			
			
			if (controller == "registrator" && method == "Register")
				return SimpleXmlSerializer.Deserialize<bool>(read(tc));

			if (controller == "authenticator" && method == "Login")
				return SimpleXmlSerializer.Deserialize<UserAccount>(read(tc));

            if (controller == "chatsystem" && method == "SendMsg")
                return SimpleXmlSerializer.Deserialize<bool>(read(tc));

			if (controller == "chatsystem" && method == "GetNewMsgs")
				return SimpleXmlSerializer.Deserialize<List<String>>(read(tc));

			if (controller == "game" && method == "CreateGame")
				return SimpleXmlSerializer.Deserialize<bool>(read(tc));

			if (controller == "game" && method == "EnemyAddedShipPositions")
				return SimpleXmlSerializer.Deserialize<bool>(read(tc));

			if (controller == "game" && method == "SetShipPositions")
                return SimpleXmlSerializer.Deserialize<bool>(read(tc));

			if (controller == "game" && method == "StartGame")
				return SimpleXmlSerializer.Deserialize<bool>(read(tc));

			if (controller == "gamesuspender" && method == "GameSuspend")
				return SimpleXmlSerializer.Deserialize<bool>(read(tc));

			if (controller == "highscoreviewer" && method == "GetHighScoreForUsers")
				return SimpleXmlSerializer.Deserialize<List<HighScore>>(read(tc));

			if (controller == "hitdetector" && method == "GetEnemyShot")
				return SimpleXmlSerializer.Deserialize<GameBoard>(read(tc));

			if (controller == "hitdetector" && method == "Shoot")
				return SimpleXmlSerializer.Deserialize<GameBoard>(read(tc));

			if (controller == "statisticsviewer" && method == "GetGameBoardsAndStatisticsForUser")
				return SimpleXmlSerializer.Deserialize<GameBoardAndStatistic>(read(tc));

			if (controller == "statisticsviewer" && method == "GetMyStatistics")
				return SimpleXmlSerializer.Deserialize<Statistic>(read(tc));
			// TODO: felvinni a controller method párokat.
			
			#endregion

			return null;
		}

		public static string CalculateMD5Hash(string input) {
			// step 1, calculate MD5 hash from input
			MD5 md5 = System.Security.Cryptography.MD5.Create();
			byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
			byte[] hash = md5.ComputeHash(inputBytes);

			// step 2, convert byte array to hex string
			StringBuilder sb = new StringBuilder();
			for (int i = 0; i < hash.Length; i++) {
				sb.Append(hash[i].ToString("X2"));
			}
			return sb.ToString();
		}

		public static string read(TcpClient tc) {
			string response = "";

			NetworkStream s = tc.GetStream();

			do {
				var data = new byte[tc.ReceiveBufferSize];
				int readCount = s.Read(data, 0, tc.ReceiveBufferSize);
				response += Encoding.UTF8.GetString(data, 0, readCount);
			} while(response[response.Length-1] != '\n');


			return response;
		}
	}
}

