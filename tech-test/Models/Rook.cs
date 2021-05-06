using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test.Models
{
    public class Rook : ChessPiece
    {
        
        public Rook()
        {
            //setting initial params for Rook piece, inherited starting positions and have set out potential first moves for each starting spot.
            this.CanMoveDiagonally = false;
            this.CanMoveHorizontally = true;
            this.CanMoveVertically = true;
            this.Paths = new int[][]
                        {
                        new int[] { 1, 3, 5, 8 , 0 },
                        new int[] { 1, 2, 6, 9 },
                        new int[] { 1, 5, 6, 7 },
                        new int[] { 2, 4, 6, 8},
                        new int[] { 3, 4, 5, 9},
                        new int[] {1, 4, 8, 9,},
                        new int[] {0, 2, 5, 7, 9},
                        new int[] {3, 6, 7, 8}
                        };
            this.Moves = new int[,] { { 1, 0 }, { 2, 0 }, { -1, 0 }, { -2, 0 }, { 0, -1 }, { 0, 1 }, { 0, 2 }, { 0, 2 }, { 0, 3 }, { 0, -3 } };
        }
    }
}
