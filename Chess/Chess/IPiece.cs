﻿using System.Collections.Generic;

namespace Chess
{
    public interface IPiece
    {
        List<List<int>> GetPossibleMoves();
        void SetPosition(int row, int column);
    }
}