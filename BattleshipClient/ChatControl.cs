﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient {
	public partial class ChatControl : UserControl {
		UserAccount user;
        //public UserAccount user { get; set; }
    
    
		public ChatControl() {
			user = new UserAccount(); 
            user = CommonData.Instance.Felhasznalo;
            InitializeComponent();

            
		}
        private void button1_Click(object sender, EventArgs e)
        {
            user = CommonData.Instance.Felhasznalo;
            if (user != null) {
                listBox1.Items.Add(user.Name + ":" + textBox1.Text);
            }
            textBox1.Clear();
        }
	}
}
