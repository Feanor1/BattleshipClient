using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BattleshipClient
{
	[Serializable()]
	public class GameBoard : Entity
	{
		public int IdInDatabase
		{
			set;
			get;
		}

		public List<ShipPosition> ShipPositions
		{
			set;
			get;
		}

		public bool[][] PreviousHitsAlpha
		{
			set;
			get;
		}

		public string AlphaPlayer
		{
			set;
			get;
		}

		public bool[][] PreviousHitsBeta
		{
			set;
			get;
		}

		public string BetaPlayer
		{
			set;
			get;
		}

		private int sizex, sizey;

		public int sizeX
		{
			set
			{
				sizex = value;
				if (sizey != 0) createBoard();
			}
			get
			{
				return sizex;
			}
		}

		public int sizeY
		{
			set
			{
				sizey = value;
				if (sizex != 0) createBoard();
			}
			get
			{
				return sizey;
			}
		}

		public bool Finished
		{
			get
			{
				try
				{
					string s = WinnerPlayerName;
					return true;
				}
				catch
				{
					return false;
				}
			}
		}

		public string WinnerPlayerName
		{
			get
			{
				int alphacount = 0;
				int betacount = 0;
				foreach (ShipPosition current in ShipPositions)
				{
                    if (current.Sunk)
                    {
                        if (current.OwnerIsAlphaPlayer) alphacount++;
                        else betacount++;
                    }
				}

				if ((alphacount != 0) && (alphacount == ShipPositions.Count / 2))
					return BetaPlayer;
                if ((betacount != 0) && (betacount == ShipPositions.Count / 2))
					return AlphaPlayer;

				throw new Exception("The game is still on.");
			}
		}

		public bool activePlayerIsAlpha
		{
			get
			{
				int count = 0;
				foreach (bool[] hits in PreviousHitsAlpha)
					foreach (bool hit in hits)
						if (hit) count++;

				foreach (bool[] hits in PreviousHitsBeta)
					foreach (bool hit in hits)
						if (hit) count++;

				if (count / 2 * 2 == count) return true;

				return false;
			}
		}

		public bool activePlayerIsBeta
		{
			get
			{
				return !activePlayerIsAlpha;
			}
		}

		//NOTE: Don't use this client side
		private void createBoard()
		{
			PreviousHitsAlpha = new bool[sizex][];
			PreviousHitsBeta = new bool[sizex][];
			for (int i = 0; i < sizex; i++)
			{
				PreviousHitsAlpha[i] = new bool[sizey];
				PreviousHitsBeta[i] = new bool[sizey];
			}

			ShipPositions = new List<ShipPosition>();
		}

		//NOTE: Don't use this client side
		public bool SetShipPosition(ShipPosition shipposition)
		{
			try
			{
				ShipPositions.Add(shipposition);
				return true;
			}
			catch (Exception e) {
				MessageBox.Show("Hiba: " + e.ToString());
				return false;
			}
		}

		//NOTE: Don't use this client side
		public ShipPosition Shoot(int x, int y, bool shooterisalpha)
		{
			foreach (ShipPosition current in ShipPositions)
			{
				if (current.OwnerIsBetaPlayer == shooterisalpha)
				{
					if (current.Horizontal && current.Y == y && current.X + current.Size > x && current.X <= x)
					{
						current.Shoot(x - current.X);
						return current;
					}
					if (current.Vertical && current.X == x && current.Y + current.Size > y && current.Y <= y)
					{
						current.Shoot(y - current.Y);
						return current;
					}
				}
			}
			return null;

		}

		public GameBoard()
		{
		}

        public override string ToString()
        {
            return "(" + AlphaPlayer + ";" + BetaPlayer + "): " + "ID: " + IdInDatabase + " ; " + "X: " + sizex + " ; " + "Y: " + sizey;
        }
	}
}