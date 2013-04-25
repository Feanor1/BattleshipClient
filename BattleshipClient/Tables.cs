using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BattleshipClient {
	class Tables : Panel{
		public int X { get; set; }
		public int Y { get; set; }
		Bitmap hajo;
		ShipPosition ships;
		public Tables(int x, int y) : base() {
			ships = new ShipPosition();

			this.BackgroundImage = BattleshipClient.Properties.Resources.water;
			X = x;
			Y = y;
			this.DoubleBuffered = true;
			this.MouseMove+=new MouseEventHandler(Helper_MouseMove);
			this.Paint += new PaintEventHandler(Helper_Paint);
			this.MouseClick += new MouseEventHandler(Tables_MouseClick);
		}

		void Tables_MouseClick(object sender, MouseEventArgs e) {
			Graphics g = this.CreateGraphics();
			bool felv = CommonData.Instance.HajoFelveve;
			float negyzetx = ((float)this.Width / (float)X);
			float negyzety = ((float)this.Height / (float)Y);
			int eX = e.X;
			int eY = e.Y;
			if (felv && (e.Button == System.Windows.Forms.MouseButtons.Right)) {
				bool horiz = true;
				horiz = CommonData.Instance.HajoHorizontalis;
				if (horiz) {
					CommonData.Instance.HajoHorizontalis = false;
				} else {
					CommonData.Instance.HajoHorizontalis = true;
				}
				
				//hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
				//g.DrawImage(hajo, eY - (negyzety / 2), eX - (negyzetx / 2));
			}
		}

		void Helper_Paint(object sender, PaintEventArgs e) {
			Graphics p1 = e.Graphics;
			Brush szin = new SolidBrush(Color.Black);
			Pen halo = new Pen(szin, 1);
			float segedX = ((float)this.Width / (float)X);
			float segedY = ((float)this.Height / (float)Y);
			for (int i = 0; i < X; i++) {
				for (int j = 0; j < Y; j++) {
					p1.DrawLine(halo, (segedX + segedX * i), 0, (segedX + segedX * i), (float)this.Height);
					p1.DrawLine(halo, 0, (segedY + segedY * j), (float)this.Width, (float)(segedY + segedY * j));
				}
			}
		}
		
		void Helper_MouseMove(object sender, MouseEventArgs e) {
			this.Refresh();
			bool felv = CommonData.Instance.HajoFelveve;
			bool horizont = CommonData.Instance.HajoHorizontalis;
			hajotipusok ship = CommonData.Instance.Hajotipus;
			Graphics g = this.CreateGraphics();
			float negyzetx = ((float)this.Width / (float)X);
			float negyzety = ((float)this.Height / (float)Y);
			int eX = e.X;
			int eY = e.Y;
			int kozepx = eX + ((int)negyzetx / 2);
			int kozepy = eY + ((int)negyzety / 2);
			Size meret;
			//if (felv && horizont) {
				switch (ship) {
					case hajotipusok.AircraftCarrier:
						if (felv  && horizont) {
							meret = new Size((int)negyzetx * 5, (int)negyzety);
							hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
							g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						} else if (felv && !horizont) {
							hajo.RotateFlip(RotateFlipType.Rotate90FlipX);
							g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						}
						break;
					case hajotipusok.Battleship:
						if (felv  && horizont) {
							meret = new Size((int)negyzetx * 4, (int)negyzety);
							hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
							} else if (felv && !horizont) {
							hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
							g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						}
						break;
					case hajotipusok.Cruiser:
						if (felv  && horizont) {
							meret = new Size((int)negyzetx * 3, (int)negyzety);
							hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						} else if (felv && !horizont) {
							hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
							g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						}
						break;
					case hajotipusok.Destroyer:
						if (felv  && horizont) {
							meret = new Size((int)negyzetx * 2, (int)negyzety);
							hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
							g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						} else if (felv && !horizont) {
							hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
							g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						}
						break;
					case hajotipusok.Submarine:
						if (felv  && horizont) {
							meret = new Size((int)negyzetx * 1, (int)negyzety);
							hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
							g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						} else if (felv && !horizont) {
							hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
							g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
						}
						break;
				}
			//} 
		}
	}
}
