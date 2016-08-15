using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.Pieces
{
    public class King : Piece
    {
        char? key = 'K';
        char? lowerKey = 'k';
        public bool MatchesKing(char? x)
        {
            return (x.Equals(key)||x.Equals(lowerKey));
        }

        public char? GetChar()
        {
            return key;
        }

        public List<string> PossibleMoves(int x, int y)
        {
            List<string> output = new List<string>();
            //Moving Up
            output.Add((x).ToString() + " " + ((y - 1)).ToString());
            //Moving Down
            output.Add((x).ToString() + " " + ((y + 1)).ToString());
            //Moving Right
            output.Add(((x + 1)).ToString() + " " + y.ToString());
            //Moving Left
            output.Add(((x - 1)).ToString() + " " + y.ToString());

            return output;
        }
        public bool FirstMove { get; set; } = true;
    }
}
