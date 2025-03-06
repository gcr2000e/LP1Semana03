using System;

namespace RoPaSci
{
    enum GameStatus
    {
        Draw = 1 << 0,
        Player1Wins = 1 << 1,
        Player2Wins = 1 << 2 
    }
}