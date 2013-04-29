using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient {
	internal class CommonData {
		protected CommonData() { }
		protected static CommonData _instance = new CommonData();
		public static CommonData Instance { get { return _instance; } }
		public bool HajoFelveve { get; set; }
		public hajotipusok Hajotipus { get; set; }
		public bool HajoHorizontalis { get; set; }
		public UserAccount Felhasznalo { get; set; }
		public PortSender Ps { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
        public GameHandler gh { get; set; }
        public bool GameCreator { get; set; }
        public BoardControl Bcjoiner { get; set; }
        public BoardControl Bccreator { get; set; }
        public ChatControl Chatc { get; set; }
        public ShipControl Shipc { get; set; }
        public CreateControl Createc { get; set; }
        public Button StartGomb { get; set; }
        public Label PlayerLabel { get; set; }
	}
}
