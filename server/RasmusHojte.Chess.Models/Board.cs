using System;

namespace RasmusHojte.Chess.Models {
    public class Board {
        public Piece[][] PiecePositions { get; set; }
        public PieceColor SideToMove { get; set; }
        public void MovePiece(Move move) {
            
        }
    }
}