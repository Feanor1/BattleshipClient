using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient
{
	public partial class GamesControl : UserControl	{
		PortSender ps;
		UserAccount ua;
		public GameBoard gb { get; private set; }
		public GamesControl() {
			ps = CommonData.Instance.Ps;
			ua = new UserAccount();
			ua = CommonData.Instance.Felhasznalo;
			InitializeComponent();
			if (ua != null) {
				//listBox1.Items.Add(ua.Gameboards.ToString());
				List<GameBoard> a = ua.Gameboards;
				//listBox1.DataSource = ua.Gameboards;
				foreach (GameBoard item in a) {
					string id = item.IdInDatabase.ToString();
					string x = item.sizeX.ToString();
					string y = item.sizeY.ToString();
					string alfa = item.AlphaPlayer;
					string beta = item.BetaPlayer;
					if (!item.Finished) {
						listBox1.Items.Add("(" + alfa + ";" + beta + "): "  + "ID: " + id  + " ; " + "X: " + x + " ; " + "Y: " + y);
					}
					 
				}
			}
			
		}

		private void button1_Click(object sender, EventArgs e) {
			gb = (GameBoard)listBox1.SelectedItem;
			object[] args = new object[1];
			args[0] = gb.IdInDatabase;
			ps.Send("game", "StartGame", args);
		}
	}
}
