using ChessConsole.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadFile readF = new ReadFile(args[0]);
            readF.DisplayLineMeaning();
            Board board = new Board(readF.getCharArray(), readF.getPiecesArray());
            board.PrintBoard();
            board.ReadMoves();
        }
    }
}
