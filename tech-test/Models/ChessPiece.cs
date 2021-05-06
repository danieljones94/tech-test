using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test.Models
{
    public class ChessPiece
    {
        public bool CanMoveVertically { get; set; }
        public bool CanMoveHorizontally { get; set; }
        public bool CanMoveDiagonally { get; set; }
        public int[][] Paths { get; set; }
        public int[,] Moves { get; set; }
        
    }
}
