namespace TicTacToeMS.Models;

public class Board
{
    public List<string>? state { get; set; }
    public string? playerOne { get; set; }
    public string? playerTwo { get; set; }
    public string? winner { get; set; }
}