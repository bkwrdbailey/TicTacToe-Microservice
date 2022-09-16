using TicTacToeMS.Models;

namespace TicTacToeMS.Services;

public static class HelperService
{
    public static Board checkForWin(Board currBoard)
    {
        // Top Row
        if (currBoard.state[0] == currBoard.state[1] && currBoard.state[1] == currBoard.state[2])
        {
            if (currBoard.state[0] == "X")
            {
                currBoard.winner = currBoard.playerOne;
            }
            else if (currBoard.state[0] == "O")
            {
                currBoard.winner = currBoard.playerTwo;
            }
        }
        // Middle Row
        else if (currBoard.state[3] == currBoard.state[4] && currBoard.state[4] == currBoard.state[5])
        {
            if (currBoard.state[3] == "X")
            {
                currBoard.winner = currBoard.playerOne;
            }
            else if (currBoard.state[3] == "O")
            {
                currBoard.winner = currBoard.playerTwo;
            }
        }
        // Bottom Row
        else if (currBoard.state[6] == currBoard.state[7] && currBoard.state[7] == currBoard.state[8])
        {
            if (currBoard.state[6] == "X")
            {
                currBoard.winner = currBoard.playerOne;
            }
            else if (currBoard.state[6] == "O")
            {
                currBoard.winner = currBoard.playerTwo;
            }
        }
        // Left Column
        else if (currBoard.state[0] == currBoard.state[3] && currBoard.state[3] == currBoard.state[6])
        {
            if (currBoard.state[0] == "X")
            {
                currBoard.winner = currBoard.playerOne;
            }
            else if (currBoard.state[0] == "O")
            {
                currBoard.winner = currBoard.playerTwo;
            }
        }
        // Middle Column
        else if (currBoard.state[1] == currBoard.state[4] && currBoard.state[4] == currBoard.state[7])
        {
            if (currBoard.state[1] == "X")
            {
                currBoard.winner = currBoard.playerOne;
            }
            else if (currBoard.state[1] == "O")
            {
                currBoard.winner = currBoard.playerTwo;
            }
        }
        // Right Column
        else if (currBoard.state[2] == currBoard.state[5] && currBoard.state[5] == currBoard.state[8])
        {
            if (currBoard.state[2] == "X")
            {
                currBoard.winner = currBoard.playerOne;
            }
            else if (currBoard.state[2] == "O")
            {
                currBoard.winner = currBoard.playerTwo;
            }
        }
        // Left To Right Diagonal
        else if (currBoard.state[0] == currBoard.state[4] && currBoard.state[4] == currBoard.state[8])
        {
            if (currBoard.state[0] == "X")
            {
                currBoard.winner = currBoard.playerOne;
            }
            else if (currBoard.state[0] == "O")
            {
                currBoard.winner = currBoard.playerTwo;
            }
        }
        // Right To Left Diagonal
        else if (currBoard.state[2] == currBoard.state[4] && currBoard.state[4] == currBoard.state[6])
        {
            if (currBoard.state[2] == "X")
            {
                currBoard.winner = currBoard.playerOne;
            }
            else if (currBoard.state[2] == "O")
            {
                currBoard.winner = currBoard.playerTwo;
            }
        }
        // Declares a 'Draw' if no one has won and there are no moves left to play
        else if (!currBoard.state.Contains(""))
        {
            currBoard.winner = "draw";
        }

        return currBoard;
    }

    public static Board computerTurn(Board currBoard)
    {
        bool invalidPlacement = true;
        Random computerMove = new Random();

        while (invalidPlacement)
        {
            int move = computerMove.Next(0, 9);

            if (currBoard.state[move] == "")
            {
                currBoard.state[move] = "O";
                invalidPlacement = false;
            }
        }

        currBoard = checkForWin(currBoard);

        return currBoard;
    }
}