using System;

namespace BattleshipClient
{
	public interface IStatisticsViewer
	{
		GameBoardAndStatistic GetGameBoardsAndStatisticsForUser(string username);
		Statistic GetMyStatistics();
	}
}

