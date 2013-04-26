using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient {
	public delegate void HajoHandler();
	public delegate void StartHandler();

	public partial class BoardControl : UserControl {
		public event HajoHandler HajoLeszed;
		public event StartHandler StartOK;

		public int X { get; set; }
		public int Y { get; set; }

		public hajotipusok Hajo { get; set; }
		public int Hajoszam { get; set; }
		public bool HajoLeteve { get; set; }

		Tables segit;
		public BoardControl() {
			InitializeComponent();
			segit = new Tables(10, 10);
			segit.Width = 400;
			segit.Height = 400;
			segit.Location = new Point(5, 5);
			this.Controls.Add(segit);
			segit.HajoDisable += new HajoDisableHandler(segit_HajoDisable);
			segit.StartEnable += new StartEnableHandler(segit_StartEnable);
		}

		void segit_StartEnable() {
			TriggerStartOK();
		}

		void segit_HajoDisable() {
			Hajo = segit.Hajo;
			Hajoszam = segit.Hajoszam;
			HajoLeteve = segit.HajoLeteve;
			TriggerHajolLeszed();
		}
		
		void TriggerHajolLeszed() {
			if (HajoLeszed != null) {
				HajoLeszed();
			}
		}
		
		void TriggerStartOK() {
			if (StartOK != null) {
				StartOK();
			}
		}
		/*private void BoardControl_Paint(object sender, PaintEventArgs e) {
	int[] szam = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
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
}


