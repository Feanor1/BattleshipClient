using System;

namespace BattleshipClient
{
	public interface IGame {

		/// 
		/// <param name="BoardSizeY"></param>
		/// <param name="BoardSizeX"></param>
		bool CreateGame(int BoardSizeY, int BoardSizeX);

		bool EnemyAddedShipPositions();

		/// 
		/// <param name="ShipPositions"></param>
		void SetShipPositions(ShipPosition ShipPositions);

		/// 
		/// <param name="gameId"></param>
		bool StartGame(int gameId);
	}//end IGame
}

