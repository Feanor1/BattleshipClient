using System;
using System.Collections.Generic;
namespace BattleshipClient
{
	public interface IChatSystem
	{
		void SendMsg(string message);
		List<String> GetNewMsgs();
		
	}
}

