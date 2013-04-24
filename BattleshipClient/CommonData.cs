using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleshipClient {
	internal class CommonData {
		protected CommonData() { }
		protected static CommonData _instance = new CommonData();
		public static CommonData Instance { get { return _instance; } }
		public bool HajoFelveve { get; set; }
		public hajotipusok Hajotipus { get; set; }
		public UserAccount Felhasznalo { get; set; }
		public PortSender Ps { get; set; }
	}
}
