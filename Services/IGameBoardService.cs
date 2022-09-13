namespace TicTacToe_Microservice.Services;

public interface IGameBoardService
{
    void updateBoardState(List<string> newBoard);
}