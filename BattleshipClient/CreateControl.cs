using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient {
	public delegate void BezarHandler();

	public partial class CreateControl : UserControl {
		public int X { get; private set; }
		public int Y { get; private set; }
		
		public event BezarHandler Bezar;

		public CreateControl() {
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e) {
		 
			try {
				X = int.Parse(textBox1.Text);
				Y = int.Parse(textBox2.Text);
			}
			catch (FormatException er) {
				MessageBox.Show("Hibás X/Y paraméter" + er.ToString());
			}
			
			bool valasz = true; //false lesz
			//valasz = gh.CreateGame(x, y);
			if (valasz) {
				MessageBox.Show("Tábla létrehozva!");
				TriggerBezar();
			} else {
				MessageBox.Show("Hibás X/Y paraméterek!");
			}
		}

		void TriggerBezar() {
			if (Bezar != null) {
				Bezar();
			}
		}
	}
}

