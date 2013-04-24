using System;
using System.Collections.Generic;

namespace BattleshipClient
{
	[Serializable()]
	public class UserAccount : Entity
	{

		public string Name
		{
			get;
			set;
		}

		public string PasswordHash
		{
			get;
			set;
		}

		public bool Gamer
		{
			get;
			set;
		}

		public List<GameBoard> Gameboards
		{
			set;
			get;
		}

		public UserAccount()
		{
		}
	}
}

