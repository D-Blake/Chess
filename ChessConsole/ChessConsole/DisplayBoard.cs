using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole
{
    public class DisplayBoard
    {
        char?[,] boardArray = new char?[8, 8];
        public DisplayBoard(char?[,] array)
        {
            boardArray = array;
        }

        public void PrintBoard()
        {
            int y = 0;
            for (int x = 0; x < 8; x++)
            {
                if (boardArray[x, y].Equals(null))
                {
                    Console.Write("-\t");
                }
                else
                {
                    Console.Write(boardArray[x, y] + "\t");
                }
                if (x == 7)
                {
                    x = -1;
                    y++;
                    Console.WriteLine("\n");
                }
                if (y == 8)
                {
                    x = 8;
                }

            }
        }
    }
}
