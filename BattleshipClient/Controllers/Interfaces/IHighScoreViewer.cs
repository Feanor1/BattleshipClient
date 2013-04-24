using System;
using System.Collections.Generic;

namespace BattleshipClient
{
	public interface IHighScoreViewer
	{
		List<HighScore> GetHighScoreForUsers();
	}
}

