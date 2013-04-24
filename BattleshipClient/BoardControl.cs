using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient {
	public partial class BoardControl : UserControl {
		public int X { get; set; }
		public int Y { get; set; }
		Bitmap hajo;
		Tables segit;
		public BoardControl() {
			InitializeComponent();
			segit = new Tables(10, 10);
			segit.Width = 400;
			segit.Height = 400;
			segit.Location = new Point(5, 5);
			this.Controls.Add(segit);
		}

	/*	protected override void OnPaint(PaintEventArgs e) {
			base.OnPaint(e);
			bool felv = CommonData.Instance.HajoFelveve;
			hajotipusok ship = CommonData.Instance.Hajotipus;
			Graphics g = panel1.CreateGraphics();
			float negyzetx = (400 / (float)X);
			float negyzety = 400 / (float)Y;
			int eX = MousePosition.X;
			int eY = MousePosition.Y;
			int kozepx = eX + ((int)negyzetx / 2);
			int kozepy = eY + ((int)negyzety / 2);
			Size meret;
			if (felv) {
				switch (ship) {
					case hajotipusok.AircraftCarrier:
						meret = new Size((int)negyzetx * 5, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
					case hajotipusok.Battleship:
						meret = new Size((int)negyzetx * 4, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
					case hajotipusok.Cruiser:
						meret = new Size((int)negyzetx * 3, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
					case hajotipusok.Destroyer:
						meret = new Size((int)negyzetx * 2, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
					case hajotipusok.Submarine:
						meret = new Size((int)negyzetx * 1, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
				}
			}
		}*/

	/*	private void panel1_Paint(object sender, PaintEventArgs e) {
			Graphics p1 = e.Graphics;
			Brush szin = new SolidBrush(Color.Black);
			Pen halo = new Pen(szin, 1);
			float segedX = ((float)panel1.Width / (float)X);
			float segedY = ((float)panel1.Height / (float)Y);
			for (int i = 0; i < X; i++) {
				for (int j = 0; j < Y; j++) {
					p1.DrawLine(halo, (segedX + segedX * i), 0, (segedX + segedX * i), (float)panel1.Height);
					p1.DrawLine(halo, 0, (segedY + segedY * j), (float)panel1.Width, (float)(segedY + segedY * j));
				}
			}
			//Rajzol(sender, e);
			OnPaint(e);
		}
		*/
	/*	private void Rajzol(object sender, PaintEventArgs e) {
			bool felv = CommonData.Instance.HajoFelveve;
			hajotipusok ship = CommonData.Instance.Hajotipus;
			Graphics g = CreateGraphics();
			float negyzetx = (400 / (float)X);
			float negyzety = 400 / (float)Y;
			int eX = MousePosition.X;
			int eY = MousePosition.Y;
			int kozepx = eX + ((int)negyzetx / 2);
			int kozepy = eY + ((int)negyzety / 2);
			Size meret;
			if (felv) {
				switch (ship) {
					case hajotipusok.AircraftCarrier:
						meret = new Size((int)negyzetx * 5, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
					case hajotipusok.Battleship:
						meret = new Size((int)negyzetx * 4, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
					case hajotipusok.Cruiser:
						meret = new Size((int)negyzetx * 3, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
					case hajotipusok.Destroyer:
						meret = new Size((int)negyzetx * 2, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
					case hajotipusok.Submarine:
						meret = new Size((int)negyzetx * 1, (int)negyzety);
						hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
						g.DrawImage(hajo, eX + 5, eY + 5);
						break;
				}
				//g.Dispose();
				panel1.Refresh();
			}
		}*/

		private void BoardControl_Paint(object sender, PaintEventArgs e) {
			/*int[] szam = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
			Label[] labels = new Label[Y];
			//for (int i = 0; i < labels.Length; i++) {
			//    labels[i].AutoSize = true;
			//}

			for (int i = 0; i < labels.Length; i++) {
				labels[i] = new Label();
				labels[i].Text = szam[i].ToString();
				//labels[i].Size = new Size(14, 14);
				labels[i].AutoSize = true;
				labels[i].Location = new Point(6, 23 + (20 + 2) * i);

			}
			this.Controls.AddRange(labels);

			String[] betuk = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T" };
			Label[] labels2 = new Label[X];
			
			for (int i = 0; i < labels2.Length; i++) {
				int szelesseg = (panel1.Width / X);
				int feleX;
				labels2[i] = new Label();
				labels2[i].Text = betuk[i].ToString();
				labels2[i].Size = new Size(14, 14);
				//labels2[i].Location = new Point(23 + (20 + 2) * i, 6);
				feleX = ((panel1.Width / X) / 2) * i;

				labels2[i].Location = new Point(feleX + szelesseg, 0);
				
			}

			this.Controls.AddRange(labels2);*/
		}

		private void BoardControl_MouseMove(object sender, MouseEventArgs e) {
			//	panel1.Invalidate();
			/*	bool felv = CommonData.Instance.HajoFelveve;
				hajotipusok ship = CommonData.Instance.Hajotipus;
				Graphics g = CreateGraphics();
				float negyzetx = (400 / (float)X);
				float negyzety = 400 / (float)Y;
				int kozepx = e.X + ((int)negyzetx / 2);
				int kozepy = e.Y + ((int)negyzety / 2);
				Size meret;
				if (felv) {
					switch (ship) {
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
				}*/
		}

		//private void panel1_MouseMove(object sender, MouseEventArgs e) {
		//    panel1.Refresh();
		//    bool felv = CommonData.Instance.HajoFelveve;
		//    hajotipusok ship = CommonData.Instance.Hajotipus;
		//    Graphics g = panel1.CreateGraphics();
		//    float negyzetx = (400 / (float)X);
		//    float negyzety = 400 / (float)Y;
		//    int eX = e.X;
		//    int eY = e.Y;
		//    int kozepx = eX + ((int)negyzetx / 2);
		//    int kozepy = eY + ((int)negyzety / 2);
		//    Size meret;
		//    if (felv) {
		//        switch (ship) {
		//            case hajotipusok.AircraftCarrier:
		//                meret = new Size((int)negyzetx * 5, (int)negyzety);
		//                hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
		//                g.DrawImage(hajo, eX + 5, eY + 5);
		//                break;
		//            case hajotipusok.Battleship:
		//                meret = new Size((int)negyzetx * 4, (int)negyzety);
		//                hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
		//                g.DrawImage(hajo, eX + 5, eY + 5);
		//                break;
		//            case hajotipusok.Cruiser:
		//                meret = new Size((int)negyzetx * 3, (int)negyzety);
		//                hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
		//                g.DrawImage(hajo, eX + 5, eY + 5);
		//                break;
		//            case hajotipusok.Destroyer:
		//                meret = new Size((int)negyzetx * 2, (int)negyzety);
		//                hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
		//                g.DrawImage(hajo, eX + 5, eY + 5);
		//                break;
		//            case hajotipusok.Submarine:
		//                meret = new Size((int)negyzetx * 1, (int)negyzety);
		//                hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
		//                g.DrawImage(hajo, eX + 5, eY + 5);
		//                break;
		//        }
		//    }//
		//}
	}
}

