using Microsoft.AspNetCore.Mvc;
using TicTacToe_Microservice.Services;

[ApiController]
public class GameBoardController : ControllerBase
{

    private readonly IGameBoardService _service;
    public GameBoardController(IGameBoardService service)
    {
        _service = service;
    }

    [HttpPut("gameboard")]
    public void CreateBoardState([FromBody] List<string> newBoard)
    {
        _service.updateBoardState(newBoard);
    }
}