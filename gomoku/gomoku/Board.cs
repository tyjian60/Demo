﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gomoku
{
    internal class Board
    {
        public static readonly int NODE_COUNT = 9;
        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);
        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DiSTANCE = 75;

        private Piece[,] pieces = new Piece[NODE_COUNT, NODE_COUNT];
        private Point lastPlacedNode = NO_MATCH_NODE;
        public Point LastPlacedNode { get { return lastPlacedNode; } }

        public PieceType GetPieceType(int nodeIdX, int nodeIdY)
        {
            if (pieces[nodeIdX, nodeIdY] == null)
                return PieceType.NONE;
            else
                return pieces[nodeIdX, nodeIdY].GetPieceType();
        }

        public bool CanBePlaced(int x, int y)
        {
            // TODO: 找出最近的節點(Node)
            Point nodeId = findTheCloseNode(x, y);

            // TODO: 如果沒有，回傳false
            if (nodeId == NO_MATCH_NODE)
                return false;

            // TODO: 如果有，檢查是否已有棋子
            if (pieces[nodeId.X, nodeId.Y] != null)
                return false;

            return true;

        }

        public Piece PlaceAPiece(int x, int y, PieceType type)
        {
            // TODO: 找出最近的節點(Node)
            Point nodeId = findTheCloseNode(x, y);

            // TODO: 如果沒有，回傳false
            if (nodeId == NO_MATCH_NODE)
                return null;

            // TODO: 如果有，檢查是否已有棋子
            if (pieces[nodeId.X, nodeId.Y] != null)
                return null;

            // TODO: 根據type產生對應棋子
            Point formPos = convertToFormPosition(nodeId);
            if (type == PieceType.BLACK)
                pieces[nodeId.X, nodeId.Y] = new BlackPiece(formPos.X, formPos.Y);
            else if (type == PieceType.WHITE)
                pieces[nodeId.X, nodeId.Y] = new WhitePiece(formPos.X, formPos.Y);

            // 紀錄最後下的位置
            lastPlacedNode = nodeId;
            
            return pieces[nodeId.X, nodeId.Y];
        }

        private Point convertToFormPosition(Point nodeId)
        {
            Point formPosition = new Point();
            formPosition.X = nodeId.X * NODE_DiSTANCE + OFFSET;
            formPosition.Y = nodeId.Y * NODE_DiSTANCE + OFFSET;
            return formPosition;
        }

        private Point findTheCloseNode(int x, int y)
        {
            int nodeIdX = findTheCloseNode(x);
            if (nodeIdX == -1 || nodeIdX >= NODE_COUNT)
                return NO_MATCH_NODE;

            int nodeIdY = findTheCloseNode(y);
            if (nodeIdY == -1 || nodeIdY >= NODE_COUNT)
                return NO_MATCH_NODE;

            return new Point(nodeIdX, nodeIdY);
        }


        private int findTheCloseNode(int pos)
        {
            if (pos < OFFSET - NODE_RADIUS)
                return -1;
            pos -= OFFSET;

            int quotient = pos / NODE_DiSTANCE;
            int remainder = pos % NODE_DiSTANCE;

            if (remainder <= NODE_RADIUS)
                return quotient;
            else if (remainder >= NODE_DiSTANCE - NODE_RADIUS)
                return quotient + 1;
            else
                return -1;
        }

    }
}
