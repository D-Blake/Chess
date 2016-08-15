using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.Pieces
{
    public class Pawn : Piece
    {
        char? key = 'P';
        char? lowerKey = 'p';
        public bool MatchesPawn(char? x)
        {
            return (x.Equals(key)||x.Equals(lowerKey));
        }

        public char? GetChar()
        {
            return key;
        }
        public List<string> PossibleMoves(int x, int y, string color)
        {
            List<string> output = new List<string>();
            if (color.Equals("white"))
            {
                //Moving Up
                output.Add((x).ToString() + " " + ((y - 1)).ToString());
                if (FirstMove)
                {
                    output.Add((x).ToString() + " " + ((y - 2)).ToString());
                }
            }
            else if (color.Equals("black"))
            {
                //Moving Down
                output.Add((x).ToString() + " " + ((y + 1)).ToString());
                if (FirstMove)
                {
                    output.Add((x).ToString() + " " + ((y + 2)).ToString());
                }
            }
            return output;
        }
        public bool FirstMove { get; set; } = true;
    }
}
