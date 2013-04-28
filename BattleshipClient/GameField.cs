using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace BattleshipClient {
	
    public partial class GameField : Form {
		
		#region deklaracio

		UserAccount usera;
		Form1 alap;
		GameHandler gh;
		ChatHandler ch;
		PortSender ps;
		Bitmap hajo;
		BoardControl EnemyControl;
		BoardControl PlayerControl;
		public hajotipusok Hajok { get; set; }
		public bool Hkiv { get; set; }
		public int X { get; private set; }
		public int Y { get; private set; }
		List<ShipPosition> Sp { get; set; }
		public hajotipusok Hajo { get; set; }
		public int Hajoszam { get; set; }
		public bool HajoLeteve { get; set; }

		#endregion

		public GameField(PortSender psa, UserAccount usa)
        {
            InitializeComponent();
			usera = usa;
			ps = psa;
			EnemyControl = new BoardControl();
			EnemyControl.Location = new Point(556, 58);
			this.Controls.Add(EnemyControl);
			PlayerControl = new BoardControl();
			EnemyControl.Visible = false;
			PlayerControl.Location = new Point(10, 58);
			this.Controls.Add(PlayerControl);
			PlayerControl.Visible = false;
			this.PlayerControl.HajoLeszed += new HajoHandler(PlayerControl_HajoLeszed);
			this.PlayerControl.StartOK += new StartHandler(PlayerControl_StartOK);

			Hajok = shipControl1.Hajok;
			Hkiv = shipControl1.Hkivalasztva;

			gh = new GameHandler(ps);
			ch = new ChatHandler(ps);
        }

		void PlayerControl_StartOK() {
			Sp = PlayerControl.SP;
			//for (int i = 0; i < Sp.Count; i++) {
			//    object[] args = new object[3];
			//    args[0] = Sp[i].Horizontal = boardControl2.SP[i].Horizontal;
			//    args[1] = Sp[i].OwnerIsAlphaPlayer;
			//    args[2] = Sp[i].Hits;
			//    ps.Send("game", "SetShipPositions", args);
			//}
			button2.Enabled = true;
			EnemyControl.Visible = true;
		}

		void PlayerControl_HajoLeszed() {
			Hajo = PlayerControl.Hajo;
			Hajoszam = PlayerControl.Hajoszam;
			HajoLeteve = PlayerControl.HajoLeteve;
			shipControl1.Hajo = Hajo;
			shipControl1.HajoLeteve = HajoLeteve;
			shipControl1.Hajoszam = Hajoszam;
			shipControl1.ShipControl_ShipRemove();
		}

		private void button2_Click(object sender, EventArgs e) {
			GameBoard uj = new GameBoard();
			uj.AlphaPlayer = this.Name;
			usera.Gameboards.Add(uj);
			uj.IdInDatabase = usera.Gameboards[usera.Gameboards.Count - 1].IdInDatabase + 1;
			object[] args = new object[1];
			args[0] = uj.IdInDatabase;
			ps.Send("game", "StartGame", args);
			button2.Text = "Waiting...";
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			Close();
		}

		private void GameField_FormClosing(object sender, FormClosingEventArgs e) {
			object[] args = new object[0];
			bool felfuggesztve = false;
			felfuggesztve = (bool)ps.Send("gamesuspender", "GameSuspend", args);
			alap = new Form1();
			alap.Show();
		}

		private void createControl1_Bezar() {
			X = createControl1.X;
			Y = createControl1.Y;
			this.Controls.Remove(createControl1);
			chatControl1.Visible = true;
			shipControl1.Visible = true;
			labelPlayerField.Visible = true;
			EnemyControl.X = X;
			EnemyControl.Y = Y;
			//boardControl1.Visible = true; //ellenfél
			EnemyControl.Visible = false;
			PlayerControl.X = X;
			PlayerControl.Y = Y;
			labelEnemy.Visible = true;
			PlayerControl.Visible = true; //én
			button2.Visible = true;
			gamesControl1.Visible = false;
		}

        private void suspendGameToolStripMenuItem_Click(object sender, EventArgs e) {
            object[] args = new object[0];
            bool felfuggesztve = false;
            felfuggesztve = (bool)ps.Send("gamesuspender", "GameSuspend", args);
            alap = new Form1();
            alap.Show();
        }

		private void GameField_MouseClick(object sender, MouseEventArgs e) {
			Graphics g = CreateGraphics();
			float negyzetx = (400 / (float)X);
			float negyzety = 400 / (float)Y;
			int kozepx = e.X + ((int)negyzetx / 2);
			int kozepy = e.Y + ((int)negyzety / 2);
			Size meret = new Size((int)negyzetx, (int)negyzety);
			if (shipControl1.Hkivalasztva) {
				switch (shipControl1.Hajok) {
					case hajotipusok.AircraftCarrier:
						hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
						break;
					case hajotipusok.Battleship:
						hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
						break;
					case hajotipusok.Cruiser:
						hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
						break;
					case hajotipusok.Destroyer:
						hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
						break;
					case hajotipusok.Submarine:
						hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
						break;
				}
			}
		}

		private void GameField_MouseMove(object sender, MouseEventArgs e) {
			Graphics g = CreateGraphics();
			float negyzetx = (400 / (float)X);
			float negyzety = 400 / (float)Y;
			int kozepx = e.X + ((int)negyzetx / 2);
			int kozepy = e.Y + ((int)negyzety / 2);
			Size meret;
			if (shipControl1.Hkivalasztva) {
				switch (shipControl1.Hajok) {
					case hajotipusok.AircraftCarrier:
						meret = new Size((int)negyzetx * 5, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
						g.DrawImage(hajo, e.X + 5, e.Y + 5);
						break;
					case hajotipusok.Battleship:
						meret = new Size((int)negyzetx * 4, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
						g.DrawImage(hajo, e.X + 5, e.Y + 5);
						break;
					case hajotipusok.Cruiser:
						meret = new Size((int)negyzetx * 3, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
						g.DrawImage(hajo, e.X + 5, e.Y + 5);
						break;
					case hajotipusok.Destroyer:
						meret = new Size((int)negyzetx * 2, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
						g.DrawImage(hajo, e.X + 5, e.Y + 5);
						break;
					case hajotipusok.Submarine:
						meret = new Size((int)negyzetx * 1, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
						g.DrawImage(hajo, e.X + 5, e.Y + 5);
						break;
				}
				g.Dispose();
			}
		}

		private void myStatisticsToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Under construction");
		}

		private void highscoreToolStripMenuItem1_Click(object sender, EventArgs e) {
			MessageBox.Show("Under construction");
		}

		private void rulesToolStripMenuItem_Click(object sender, EventArgs e) {
			Rules nj = new Rules();
			DialogResult resu;
			resu = nj.ShowDialog();
			if (DialogResult.Cancel == resu) {
				this.Focus();
			}
		}

		private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e) {
			About rule = new About();
			DialogResult resu;
			resu = rule.ShowDialog();
			if (DialogResult.Cancel == resu) {
				this.Focus();
			}
		}

		private void highscoreToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBox.Show("Under construction");
		}
    }
}
