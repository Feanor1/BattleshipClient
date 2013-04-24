using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient
{
    public partial class Register : Form
    {
		bool tipus;
		bool valasz = false;

        public Register()
        {
            InitializeComponent();
			Port.SelectedIndex = 0;
			PortSender ps = new PortSender();
			UserHandler uh = new UserHandler(ps);
			
			
			string nev;
			string pass;
			
			nev = textUserName.Text;
			pass = textPass.Text;

			
        }

		private void comboAccountType_SelectedValueChanged(object sender, EventArgs e) {
			switch (comboAccountType.SelectedItem.ToString()) {
				case "Player":
					tipus = true;
					break;
				case "Spectator":
					tipus = false;
					break;
				default:
					tipus = false;
					break;
			}
		}

		private void buttonOk_Click(object sender, EventArgs e) {
			if (textPass.Text.Equals(textVerify.Text)) {
				//valasz = uh.Register(nev, pass, tipus);
			} else {
				MessageBox.Show("Nem egyezik a jelszó!");
			}

			if (valasz) {
				MessageBox.Show("Sikeres regisztráció!");
				Close();
			} else {
				MessageBox.Show("Sikertelen regisztráció!");
				comboAccountType.SelectedIndex = 0;
				Port.SelectedIndex = 0;
				textUserName.Text = "";
				textPass.Text = "";
				textVerify.Text = "";
			}
		}
    }
}
