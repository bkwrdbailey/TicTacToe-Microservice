using TicTacToeMS.Models;

namespace TicTacToeMS.Services;

public interface IGameBoardService
{
    Task<Board> updateBoardState(Board newBoard);
}