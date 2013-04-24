using System;

namespace BattleshipClient
{
	public interface IAuthenticator
	{
		UserAccount Login(string username, string passwordhash);
	}
}

