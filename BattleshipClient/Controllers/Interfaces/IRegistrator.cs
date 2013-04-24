using System;

namespace BattleshipClient
{
	public interface IRegistrator
	{
		bool Register(string userName, string passwordHash, bool gamer);
	}
}

