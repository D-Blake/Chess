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
            ReadFile readF = new ReadFile();
            readF.DisplayLineMeaning();
            DisplayBoard display = new DisplayBoard(readF.getCharArray());
            display.PrintBoard();
        }
    }
}
