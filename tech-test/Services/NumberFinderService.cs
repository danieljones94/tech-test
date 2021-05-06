using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tech_test.Interfaces;
using tech_test.Models;

namespace tech_test.Services
{
    public class NumberFinderService : INumberFinderService
    {
        public int Solution(DialPad dialPad, PhoneNumber phoneNumber)
        {
           int height = dialPad.Height;
           int width = dialPad.Width;
           int numLength = phoneNumber.Length;
           int[,,] m = new int[numLength + 1, width, height];
           int numOfPaths = 0;
           for (int i = 0; i < dialPad.Width; i++)
            {
                for(int k = 0; k < dialPad.Height; i++)
                {
                    numOfPaths = (numOfPaths + FindNumbers(m, i, k, phoneNumber.Length));
                }
            }

            return numOfPaths;
        }

        private int FindNumbers(int[,,] m, int pointOnXAxis, int pointOnYAxis, int length)
        {
            Rook rook = new Rook();

            if (pointOnXAxis < 0 || pointOnYAxis < 0 || pointOnXAxis > 2 || pointOnYAxis > 3 || (pointOnYAxis == 3 && pointOnXAxis != 1))
            {
                return 0;
            }
            if (length == 1)
            {
                return 1;
            }
            if (m[length, pointOnXAxis, pointOnYAxis] > 0)
            {
                return m[length, pointOnXAxis, pointOnYAxis];
            }

            m[length, pointOnXAxis, pointOnYAxis] =
                FindNumbers(m, pointOnXAxis + rook.Moves[0, 1], pointOnYAxis + rook.Moves[0, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[1, 1], pointOnYAxis + rook.Moves[1, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[2, 1], pointOnYAxis + rook.Moves[2, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[3, 1], pointOnYAxis + rook.Moves[3, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[4, 1], pointOnYAxis + rook.Moves[4, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[5, 1], pointOnYAxis + rook.Moves[5, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[6, 1], pointOnYAxis + rook.Moves[6, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[7, 1], pointOnYAxis + rook.Moves[7, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[8, 1], pointOnYAxis + rook.Moves[8, 2], length - 1) +
                FindNumbers(m, pointOnXAxis + rook.Moves[9, 1], pointOnYAxis + rook.Moves[9, 2], length - 1);

            return m[length, pointOnXAxis, pointOnYAxis];
        }
    }
}
