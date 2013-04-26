using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient {
	public enum hajotipusok { AircraftCarrier, Battleship, Cruiser, Destroyer, Submarine };
	public delegate void ShipRemoveHandler();

	public partial class ShipControl : UserControl {
		public event ShipRemoveHandler ShipRemove;

		public hajotipusok Hajok { get; private set; }
		public bool Hkivalasztva { get; private set; }

		public hajotipusok Hajo { get; set; }
		public int Hajoszam { get; set; }
		public bool HajoLeteve { get; set; }

		public ShipControl() {
			InitializeComponent();
			ShipRemove += new ShipRemoveHandler(ShipControl_ShipRemove);
		}

		void ShipControl_ShipRemove() {
			switch (Hajo) {
				case hajotipusok.AircraftCarrier:
					if (Hajoszam == 0) {
						if (HajoLeteve) {
							aircraftcarrier.Visible = false;
						}
					}
					break;
				case hajotipusok.Battleship:
					if (Hajoszam == 0) {
						if (HajoLeteve) {
							battleship.Visible = false;
						}
					}
					break;
				case hajotipusok.Cruiser:
					if (Hajoszam == 0) {
						if (HajoLeteve) {
							cruiser.Visible = false;
						}
					}
					break;
				case hajotipusok.Destroyer:
					if (Hajoszam == 0) {
						if (HajoLeteve) {
							destroyer.Visible = false;
						}
					}
					break;
				case hajotipusok.Submarine:
					if (Hajoszam == 0) {
						if (HajoLeteve) {
							submarine.Visible = false;
						}
					}
					break;
			}
		}

		private void aircraftcarrier_Click(object sender, EventArgs e) {
			CommonData.Instance.HajoFelveve = true;
			CommonData.Instance.HajoHorizontalis = true;
			CommonData.Instance.Hajotipus = hajotipusok.AircraftCarrier;
		}

		private void battleship_Click(object sender, EventArgs e) {
			CommonData.Instance.HajoFelveve = true;
			CommonData.Instance.HajoHorizontalis = true;
			CommonData.Instance.Hajotipus = hajotipusok.Battleship;
		}

		private void cruiser_Click(object sender, EventArgs e) {
			CommonData.Instance.HajoFelveve = true;
			CommonData.Instance.HajoHorizontalis = true;
			CommonData.Instance.Hajotipus = hajotipusok.Cruiser;
		}

		private void destroyer_Click(object sender, EventArgs e) {
			CommonData.Instance.HajoFelveve = true;
			CommonData.Instance.HajoHorizontalis = true;
			CommonData.Instance.Hajotipus = hajotipusok.Destroyer;
		}

		private void submarine_Click(object sender, EventArgs e) {
			CommonData.Instance.HajoFelveve = true;
			CommonData.Instance.HajoHorizontalis = true;
			CommonData.Instance.Hajotipus = hajotipusok.Submarine;
		}

		void TriggerShipRemove() {
			if (ShipRemove != null) {
				ShipRemove();
			}
		}
	}
}
