using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace BattleshipClient
{
    class TableHit : Panel
    {
        PortSender ps;
        UserAccount ua;

        //leadott shootok
        List<int[]> lövések = new List<int[]>();



        public GameBoard gb { get; private set; }

        public int X { get; set; }
        public int Y { get; set; }
        public TableHit(int x, int y)
            : base()
        {

            ps = CommonData.Instance.Ps;
            ua = new UserAccount();
            ua = CommonData.Instance.Felhasznalo;


            this.BackgroundImage = BattleshipClient.Properties.Resources.water;
            X = x;
            Y = y;
            this.DoubleBuffered = true;
            this.MouseClick += new MouseEventHandler(Helper_MouseClick);
            this.Paint += new PaintEventHandler(Helper_Paint);

        }

        void Helper_Paint(object sender, PaintEventArgs e)
        {
            Graphics p1 = e.Graphics;
            Brush szin = new SolidBrush(Color.Black);
            Pen halo = new Pen(szin, 1);
            float segedX = ((float)this.Width / (float)X);
            float segedY = ((float)this.Height / (float)Y);
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    p1.DrawLine(halo, (segedX + segedX * i), 0, (segedX + segedX * i), (float)this.Height);
                    p1.DrawLine(halo, 0, (segedY + segedY * j), (float)this.Width, (float)(segedY + segedY * j));
                }
            }
        }
        void Helper_MouseClick(object sender, MouseEventArgs e)
        {

            if (this.Name.Equals("boardControl2"))
            {

                if (gb.AlphaPlayer.Equals(ua.Name) == gb.activePlayerIsAlpha)
                {

                    //hova lőtt
                    float segedX = ((float)this.Width / (float)X);
                    float segedY = ((float)this.Height / (float)Y);

                    Graphics p1em = this.CreateGraphics();

                    int kockaX = (int)((e.X) / segedX);
                    int kockaY = (int)((e.Y) / segedY);


                    //lövések ( valszeg nem kéne de...)
                    bool volte = false;
                    int i = 0;
                    while (i < lövések.Count && !volte)
                    {
                        if (kockaX == lövések[i][0] && kockaY == lövések[i][1])
                        {
                            volte = true;
                        }
                    }


                    // Volt-e már a lövés
                    if (volte)
                    {
                        lövések.Add(new int[] { kockaX, kockaY });

                        object[] args = new object[2];
                        args[0] = kockaX;
                        args[1] = kockaY;

                        gb = (GameBoard)ps.Send("hitdetector", "Shoot", args);


                        //Talált/Nem
                        if (true)
                        {
                            p1em.FillEllipse(new SolidBrush(Color.Red), segedX * kockaX, segedY * kockaY, segedX, segedY);
                        }
                        //else
                        //{
                        //    p1em.FillEllipse(new SolidBrush(Color.Green), segedX * kockaX, segedY * kockaY, segedX, segedY);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Ide már löttél");
                    }

                }
            }
        }
    }

}
