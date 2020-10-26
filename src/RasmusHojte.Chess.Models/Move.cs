namespace RasmusHojte.Chess.Models {
    public class Move {
        public string OriginalSquare { get; set; }
        public string NewSquare { get; set; }
        public MoveType MoveType { get; set; }
    }
}