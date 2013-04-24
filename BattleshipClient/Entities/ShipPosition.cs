using System;
using System.Xml.Serialization;

namespace BattleshipClient
{
	[Serializable()]
	public class ShipPosition : Entity
	{
		bool ownerIsAlphaPlayer, vertical;

		public bool OwnerIsAlphaPlayer
		{
			get
			{
				return ownerIsAlphaPlayer;
			}
			set
			{
				ownerIsAlphaPlayer = value;
			}
		}

		public bool OwnerIsBetaPlayer
		{
			get
			{
				return !ownerIsAlphaPlayer;
			}
			set
			{
				ownerIsAlphaPlayer = !value;
			}
		}

		public bool Vertical
		{
			get
			{
				return vertical;
			}
			set
			{
				vertical = value;
			}
		}

		public bool Horizontal
		{
			get
			{
				return !vertical;
			}
			set
			{
				vertical = !value;
			}
		}

		public bool[] Hits
		{
			set;
			get;
		}

		public int X
		{
			set;
			get;
		}

		public int Y
		{
			set;
			get;
		}

		[XmlIgnore()]
		public int Size
		{
			get
			{
				return Hits.Length;
			}
			set
			{
				Hits = new bool[value];
			}
		}

		public bool Sunk
		{
			get
			{
				foreach (bool hit in Hits)
				{
					if (!hit) return false;
				}
				return true;
			}
		}

		//NOTE: Don't use this client side
		public bool Shoot(int where)
		{
			try
			{
				Hits[where] = true;
				return true;
			}
			catch
			{
				return false;
			}
		}

		public ShipPosition()
		{
		}
	}
}
