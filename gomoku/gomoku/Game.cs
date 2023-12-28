using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gomoku
{
    internal class Game
    {
        private Board board = new Board();

        private PieceType currentPlayer = PieceType.BLACK;

        private PieceType winner = PieceType.NONE;
        public PieceType Winner { get { return winner; } }

        public bool CanBePlaced(int x, int y)
        {
            return board.CanBePlaced(x, y);
        }

        public Piece PlaceAPiece(int x, int y)
        {
            Piece piece = board.PlaceAPiece(x, y, currentPlayer);
            if (piece != null)
            {
                // 檢查是否現在下棋的人獲勝
                CheckWinner();

                // 交換選手
                if (currentPlayer == PieceType.BLACK)
                    currentPlayer = PieceType.WHITE;
                else if (currentPlayer == PieceType.WHITE)
                    currentPlayer = PieceType.BLACK;

                return piece;
            }

            return null;
        }

        private void CheckWinner()
        {
            int centerX = board.LastPlacedNode.X;
            int centerY = board.LastPlacedNode.Y;

            // 檢查八個方向
            for (int xDir = -1; xDir <= 1; xDir++)
            {
                for (int yDir = -1; yDir <= 1; yDir++)
                {
                    // 排除中心
                    if (xDir == 0 && yDir == 0)
                        continue;

                    int count = 0;

                    for (int i = 1; i < 5; i++)
                    {
                        int targetX = centerX + i * xDir;
                        int targetY = centerY + i * yDir;
                        
                        // 檢查顏色是否相同
                        if (targetX < 0 || targetX >= Board.NODE_COUNT ||
                            targetY < 0 || targetY >= Board.NODE_COUNT ||
                            board.GetPieceType(targetX, targetY) != currentPlayer)
                            break;
                        count++;
                    }

                    // 檢查反方向
                    for (int i = 1; i < 5; i++)
                    {
                        int targetX = centerX + i * (-1) * xDir;
                        int targetY = centerY + i * (-1) * yDir;

                        // 檢查顏色是否相同
                        if (targetX < 0 || targetX >= Board.NODE_COUNT ||
                            targetY < 0 || targetY >= Board.NODE_COUNT ||
                            board.GetPieceType(targetX, targetY) != currentPlayer)
                            break;
                        count++;
                    }

                    if (count >= 4)
                    {
                        winner = currentPlayer;
                        return;
                    }
                }
            }

        }
    }
}
