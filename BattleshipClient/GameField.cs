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
		public hajotipusok Hajok { get; set; }
		public bool Hkiv { get; set; }
		public int X { get; private set; }
		public int Y { get; private set; }

		public hajotipusok Hajo { get; set; }
		public int Hajoszam { get; set; }
		public bool HajoLeteve { get; set; }

		#endregion

		public GameField(PortSender psa, UserAccount usa)
        {
            InitializeComponent();
			usera = usa;
			ps = psa;

			this.boardControl2.HajoLeszed += new HajoHandler(boardControl2_HajoLeszed);

			Hajok = shipControl1.Hajok;
			Hkiv = shipControl1.Hkivalasztva;

			gh = new GameHandler(ps);
			ch = new ChatHandler(ps);
			//panel1 = new Panel();
			//panel1.Location = new Point(12, 46);
			//panel1.Name = "panel1";
			//panel1.Size = new Size(300, 300);
			//panel1.BackColor = Color.Aqua;
			//panel1.Visible = false;
			//this.Controls.Add(panel1);

			//panel2 = new Panel();
			//panel2.Location = new Point(324, 46);
			//panel2.Size = new Size(300, 300);
			//panel2.BackColor = Color.Aqua;
			//panel2.Visible = false;
		//	this.Controls.Add(panel2);
        }

		void boardControl2_HajoLeszed() {
			Hajo = boardControl2.Hajo;
			Hajoszam = boardControl2.Hajoszam;
			HajoLeteve = boardControl2.HajoLeteve;
			shipControl1.Hajo = Hajo;
			shipControl1.HajoLeteve = HajoLeteve;
			shipControl1.Hajoszam = Hajoszam;
			shipControl1.Refresh();
		}

		private void button2_Click(object sender, EventArgs e) {
			
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
			boardControl1.X = X;
			boardControl1.Y = Y;
			//boardControl1.Visible = true; //ellenfél
			boardControl1.Visible = false;
			boardControl2.X = X;
			boardControl2.Y = Y;
			labelEnemy.Visible = true;
			boardControl2.Visible = true; //én
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
			if (e.Button == System.Windows.Forms.MouseButtons.Right) {
				
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
    }
}
