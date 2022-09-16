using Microsoft.AspNetCore.Mvc;
using TicTacToeMS.Services;
using TicTacToeMS.Models;

[ApiController]
public class GameBoardController : ControllerBase
{
    private readonly IGameBoardService _service;
    public GameBoardController(IGameBoardService service)
    {
        _service = service;
    }

    [HttpPut("gameboard")]
    public async Task<Board> UpdateBoardState(Board newBoard)
    {
        return await _service.updateBoardState(newBoard);
    }
}