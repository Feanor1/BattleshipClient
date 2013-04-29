using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleshipClient
{
	public partial class GamesControl : UserControl	{
		PortSender ps;
		UserAccount ua;
        BoardControl PlayerControl = CommonData.Instance.Bcjoiner;
        BoardControl EnemyControl = CommonData.Instance.Bccreator;
		public GameBoard gb { get; private set; }
        public hajotipusok Hajo { get; set; }
        public int Hajoszam { get; set; }
        public bool HajoLeteve { get; set; }
        List<ShipPosition> Sp { get; set; }

		public GamesControl() {
			ps = CommonData.Instance.Ps;
			ua = CommonData.Instance.Felhasznalo;
			InitializeComponent();
			if (ua != null) {
				//listBox1.Items.Add(ua.Gameboards.ToString());
				
				List<GameBoard> a = ua.Gameboards;

				//listBox1.DataSource = ua.Gameboards;
				foreach (GameBoard item in a) {
					string id = item.IdInDatabase.ToString();
					string x = item.sizeX.ToString();
					string y = item.sizeY.ToString();
					string alfa = item.AlphaPlayer;
					string beta = item.BetaPlayer;
					if (!item.Finished) {
						listBox1.Items.Add(item);
					}
					 
				}
			}
			
		}

        void PlayerControl_HajoLeszed()
        {
            Hajo = PlayerControl.Hajo;
            Hajoszam = PlayerControl.Hajoszam;
            HajoLeteve = PlayerControl.HajoLeteve;
            CommonData.Instance.Hajotipus = Hajo;
            CommonData.Instance.Shipc.HajoLeteve = HajoLeteve;
            CommonData.Instance.Shipc.Hajoszam = Hajoszam;
            CommonData.Instance.Shipc.ShipControl_ShipRemove();
        }

        void PlayerControl_StartOK()
        {
            Sp = PlayerControl.SP;
            bool ellensegkesz = true; //false
            object[] args = new object[0];
            if (ellensegkesz)
            {
                CommonData.Instance.StartGomb.Enabled = true;
                EnemyControl.Visible = true;
                CommonData.Instance.Shipc.Visible = false;
            }
        }

		private void button1_Click(object sender, EventArgs e) {
            CommonData.Instance.GameCreator = false;
			gb = (GameBoard)listBox1.SelectedItem;

            if (CommonData.Instance.gh.StartGame(gb.IdInDatabase)) {
                
            /*    Button start = CommonData.Instance.StartGomb;
                EnemyControl = new BoardControl();
                EnemyControl.Location = new Point(556, 58);
                this.Controls.Add(EnemyControl);
                PlayerControl = new BoardControl();
                EnemyControl.Visible = false;
                PlayerControl.Location = new Point(10, 58);
                this.Controls.Add(PlayerControl);
                PlayerControl.Visible = false;
                this.PlayerControl.HajoLeszed += new HajoHandler(PlayerControl_HajoLeszed);
                this.PlayerControl.StartOK += new StartHandler(PlayerControl_StartOK);


       
                CommonData.Instance.Chatc.Visible = true;
                CommonData.Instance.Shipc.Visible = true;
                CommonData.Instance.PlayerLabel.Visible = true;
                EnemyControl.X = CommonData.Instance.X;
                EnemyControl.Y = CommonData.Instance.Y;
                EnemyControl.Visible = false;
                PlayerControl.X = CommonData.Instance.X;
                PlayerControl.Y = CommonData.Instance.Y;
                PlayerControl.Visible = true; //én
                start.Visible = true;
                this.Visible = false;*/
                CommonData.Instance.X = gb.sizeX;
                CommonData.Instance.Y = gb.sizeY;
                CommonData.Instance.GameCreator = false;

                CommonData.Instance.Createc.TriggerBezar();
            }
            else
            {
                MessageBox.Show("Valami történt.");
            }
			
		}
	}
}
