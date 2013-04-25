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
	public partial class ShipControl : UserControl {
		public hajotipusok Hajok { get; private set; }
		public bool Hkivalasztva { get; private set; }

		public ShipControl() {
			InitializeComponent();
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
	}
}
