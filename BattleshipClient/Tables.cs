﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BattleshipClient {
	public delegate void HajoDisableHandler();
	public delegate void StartEnableHandler();

	class Tables : Panel {
		#region deklaracio

		public event HajoDisableHandler HajoDisable;
		public event StartEnableHandler StartEnable;

		GameBoard gb;
		PortSender ps;
		public int X { get; set; }
		public int Y { get; set; }

		public hajotipusok Hajo { get; set; }
		public int Hajoszam { get; set; }
		public bool HajoLeteve { get; set; }

		Size meret;
		int aircraftc, battlesh, cruis, destr, subm;
		Bitmap hajo;
		List<Hajok> letett;
		bool shipplaceable;
		string player;
		bool horizont;

		public List<ShipPosition> sp { get; set; }
		
		bool felv;
		hajotipusok ship;
		float negyzetx;
		float negyzety;
		public int EX { get; private set; }
		public int EY { get; private set; }
		int kozepx;
		int kozepy;
		int hajoszamlalo;

		#endregion

		public Tables(int x, int y) : base() {

			#region ertekadas
			ps = CommonData.Instance.Ps;
			hajoszamlalo = 0;
			aircraftc = 1;
			battlesh = 1;
			cruis = 1;
			destr = 2;
			subm = 2;
			horizont = CommonData.Instance.HajoHorizontalis;
			felv = CommonData.Instance.HajoFelveve;
			ship = CommonData.Instance.Hajotipus;
						
			HajoMeretBeallaitas();
			//letett = new List<Bitmap>();
			letett = new List<Hajok>();
			player = CommonData.Instance.Felhasznalo.Name;
			sp = new List<ShipPosition>();
			gb = new GameBoard();
			gb.AlphaPlayer = CommonData.Instance.Felhasznalo.Name;
			this.BackgroundImage = BattleshipClient.Properties.Resources.water;
			X = x;
			Y = y;

			#endregion

			#region eventek

			this.DoubleBuffered = true;
			this.MouseMove+=new MouseEventHandler(Helper_MouseMove);
			this.Paint += new PaintEventHandler(Helper_Paint);
			this.MouseClick += new MouseEventHandler(Tables_MouseClick);
			this.MouseEnter += new EventHandler(Tables_MouseEnter);
			this.MouseLeave += new EventHandler(Tables_MouseLeave);

			#endregion
		}

		void HajoMeretBeallaitas() {
			negyzetx = ((float)this.Width / (float)X);
			negyzety = ((float)this.Height / (float)Y);
			kozepx = EX + ((int)negyzetx / 2);
			kozepy = EY + ((int)negyzety / 2);
			hajotipusok ship = CommonData.Instance.Hajotipus;
			switch (ship) {
				case hajotipusok.AircraftCarrier:
					meret = new Size((int)negyzetx * 5, (int)negyzety);
					if (felv && horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipX);
					}
					break;
				case hajotipusok.Battleship:
					meret = new Size((int)negyzetx * 4, (int)negyzety);
					if (felv && horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipX);
					}
					break;
				case hajotipusok.Cruiser:
					meret = new Size((int)negyzetx * 3, (int)negyzety);
					if (felv && horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipX);
					}
					break;
				case hajotipusok.Destroyer:
					meret = new Size((int)negyzetx * 2, (int)negyzety);
					if (felv && horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipX);
					}
					break;
				case hajotipusok.Submarine:
					meret = new Size((int)negyzetx * 1, (int)negyzety);
					if (felv && horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipX);
					}
					break;
			}
		}

		void Tables_MouseLeave(object sender, EventArgs e) {
			shipplaceable = false;
		}

		void Tables_MouseEnter(object sender, EventArgs e) {
			shipplaceable = true;
		}

		void Tables_MouseClick(object sender, MouseEventArgs e) {
			bool horiz;
			bool felv = CommonData.Instance.HajoFelveve;
			EX = e.X;
			EY = e.Y;
					
			negyzetx = ((float)this.Width / (float)X);
			negyzety = ((float)this.Height / (float)Y);
			kozepx = EX + ((int)negyzetx / 2);
			kozepy = EY + ((int)negyzety / 2);
			Graphics g = this.CreateGraphics();
			
			if (felv && (e.Button == System.Windows.Forms.MouseButtons.Right)) {
				horiz = CommonData.Instance.HajoHorizontalis;
				if (horiz) {
					CommonData.Instance.HajoHorizontalis = false;
				} else {
					CommonData.Instance.HajoHorizontalis = true;
				}
			} else if (felv && shipplaceable && e.Button ==System.Windows.Forms.MouseButtons.Left) {
				ShipPosition shippos = new ShipPosition();
				hajotipusok ship = CommonData.Instance.Hajotipus;

				#region hajo elhelyezes
                shippos.Horizontal = horizont;
                shippos.X = (int)(((float)e.X)/negyzetx);
                shippos.Y = (int)(((float)e.Y)/negyzety);
                CommonData.Instance.Hajotipus = hajotipusok.None;

                HajoLeteve = false;
				switch (ship) {
					case hajotipusok.AircraftCarrier:
						Hajo = hajotipusok.AircraftCarrier;
						if (aircraftc != 0) {
                            shippos.Size = 5;
							aircraftc -= 1;
                            HajoLeteve = true;
                            TriggerHajoDisable();
                            if (felv) {
                                hajo = BattleshipClient.Properties.Resources._01aircraft_carrier;
							}
						}
						break;
					case hajotipusok.Battleship:
						Hajo = hajotipusok.Battleship;
						if (battlesh != 0 ) {
							shippos.Size = 4;
							battlesh -= 1;
							HajoLeteve = true;
                            TriggerHajoDisable();
                            if (felv)
                                hajo = BattleshipClient.Properties.Resources._02Battleship;
						}
						break;
					case hajotipusok.Cruiser:
						Hajo = hajotipusok.Cruiser;
						if (cruis != 0) {
							shippos.Size = 3;
							cruis -= 1;
                            HajoLeteve = true;
                            TriggerHajoDisable();
                            if (felv)
                                hajo = BattleshipClient.Properties.Resources._03Cruiser;
						}
						break;
					case hajotipusok.Destroyer:
						Hajo = hajotipusok.Destroyer;
						if (destr != 0) {
							shippos.Size = 2;
							destr -= 1;
							HajoLeteve = true;
                            if (felv)
                                hajo = BattleshipClient.Properties.Resources._04Destroyer;
							if (destr == 0) {
								TriggerHajoDisable();
							}
						}
						break;
					case hajotipusok.Submarine:
						Hajo = hajotipusok.Submarine;
						if (subm != 0) {
							shippos.Size = 1;
							subm -= 1;
							HajoLeteve = true;
                            if (felv)
                                hajo = BattleshipClient.Properties.Resources._05Submarine;
							if (subm == 0) {
								TriggerHajoDisable();
							}
						}
						break;
					}

                if (HajoLeteve)
                {
                    sp.Add(shippos);
                    if (horizont)
                        meret = new Size((int)(negyzetx * (float)shippos.Size), (int)negyzety);
                    else
                        meret = new Size((int)negyzetx, (int)(negyzety * (float)shippos.Size));

                    hajo = new Bitmap(hajo, meret);
                    if (!horizont)
                        hajo.RotateFlip(RotateFlipType.Rotate90FlipX);
                    letett.Add(new Hajok((int)(shippos.X * negyzetx), (int)(shippos.Y * negyzety), hajo, meret));
                    hajoszamlalo++;
                    felv = false;
                    CommonData.Instance.Hajotipus = hajotipusok.None;
                }

				if (sp.Count >= 7) {
					for (int i = 0; i < sp.Count; i++) {
                        CommonData.Instance.gh.SetShipPositions(sp[i]);
					}
					TriggerStartEnable();
				}
				this.Refresh();
				#endregion

			}
		}

		#region kirajzolas

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
			if (letett != null) {
				for (int i = 0; i < letett.Count; i++) {
					p1.DrawImage(letett[i].Hkep, letett[i].Hely);
				}
			}
		}

		#endregion

		void Helper_MouseMove(object sender, MouseEventArgs e) {
			this.Refresh();
			bool felv = CommonData.Instance.HajoFelveve;
			horizont = CommonData.Instance.HajoHorizontalis;
			ship = CommonData.Instance.Hajotipus;
			Graphics g = this.CreateGraphics();
			float negyzetx = ((float)this.Width / (float)X);
			float negyzety = ((float)this.Height / (float)Y);
			int eX = e.X;
			int eY = e.Y;
			int kozepx = eX + ((int)negyzetx / 2);
			int kozepy = eY + ((int)negyzety / 2);
			#region hajo kirajzolás mozgás közben
			switch (ship) {
				case hajotipusok.AircraftCarrier:
					meret = new Size((int)negyzetx * 5, (int)negyzety);
					if (felv  && horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._01aircraft_carrier, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipX);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					}
					break;
				case hajotipusok.Battleship:
					meret = new Size((int)negyzetx * 4, (int)negyzety);
					if (felv  && horizont) {						
						hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._02Battleship, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					}
					break;
				case hajotipusok.Cruiser:
					meret = new Size((int)negyzetx * 3, (int)negyzety);
					if (felv  && horizont) {						
						hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._03Cruiser, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					}
					break;
				case hajotipusok.Destroyer:
					meret = new Size((int)negyzetx * 2, (int)negyzety);
					if (felv  && horizont) {						
						hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._04Destroyer, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					}
					break;
				case hajotipusok.Submarine:
					meret = new Size((int)negyzetx * 1, (int)negyzety);
					if (felv  && horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					} else if (felv && !horizont) {
						hajo = new Bitmap(BattleshipClient.Properties.Resources._05Submarine, meret);
						hajo.RotateFlip(RotateFlipType.Rotate90FlipNone);
						g.DrawImage(hajo, eX - (negyzetx / 2), eY - (negyzety / 2));
					}
					break;
			}
			#endregion
		}

		void TriggerHajoDisable() {
			if (HajoDisable != null) {
				HajoDisable();
			}
		}

		void TriggerStartEnable() {
			if (StartEnable != null) {
				StartEnable();
			}
		}
	}
}
