using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BattleshipClient;

namespace BattleshipClient {
    public partial class Form1 : Form
    {
		UserAccount user;
		UserHandler uh;
		GameHandler gh;
		PortSender ps;
		GameField Game;
        public Form1()
        {
            InitializeComponent();
			ps = new PortSender();
			user = new UserAccount();
			uh = new UserHandler(ps);
			gh = new GameHandler(ps);
			//Game = new GameField(ps, user);
			
        }

        private void button1_Click(object sender, EventArgs e) {
			string nev;
			string pass;
			string ipcim;
			if (textUserName.Text == null) {
				MessageBox.Show("Üres felhasználónév mező!");
			} else if (textBoxPassword.Text == null) {
				MessageBox.Show("Üres jelszó mező!");
			} else if (textBox1.Text == null) {
				MessageBox.Show("Üres IP-cím mező!");
			}
			else{
				nev = textUserName.Text;
				pass = textBoxPassword.Text;
				ipcim = textBox1.Text;
				ps.Connect(ipcim);
				CommonData.Instance.Ps = ps;
				user = uh.Login(nev, pass);
				CommonData.Instance.Felhasznalo = user;
			}
						
			//Ellenőrízd, h ez null-e
			
			Game = new GameField(ps, user);
			Game.Alap = this;
			
			Game.Show();
			this.Hide();
			
			//MessageBox.Show("lol");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form reg = new Register();
            reg.Show();            
        }

		private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
			Application.Exit();
		}
    }
}
