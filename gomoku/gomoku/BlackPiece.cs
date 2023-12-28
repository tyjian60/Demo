﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gomoku
{
    internal class BlackPiece : Piece
    {
        public BlackPiece(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.black;
        }

        public override PieceType GetPieceType()
        {
            return PieceType.BLACK;
        }
    }
}
