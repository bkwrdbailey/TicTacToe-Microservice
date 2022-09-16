using TicTacToeMS.Models;
namespace TicTacToeMS.Services;

public class GameBoardService : IGameBoardService
{

    public GameBoardService()
    {

    }

    public async Task<Board> updateBoardState(Board newBoard)
    {
        Board updatedBoard = new Board();

        // Checks for a winner
        updatedBoard = HelperService.checkForWin(newBoard);
        
        // If no winner is found then the computer's turn will occur
        if (updatedBoard.winner == "")
        {
            HelperService.computerTurn(newBoard);
        }

        return updatedBoard;
    }
}