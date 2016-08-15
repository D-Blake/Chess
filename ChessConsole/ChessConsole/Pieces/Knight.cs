using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.Pieces
{
    public class Knight : Piece
    {
        char? key = 'N';
        char? lowerKey = 'n';
        public bool MatchesKnight(char? x)
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
            //Moving Up Right
            output.Add(((x + 1)).ToString() + " " + ((y - 1)).ToString());
            //Moving Up Left
            output.Add(((x - 1)).ToString() + " " + ((y - 1)).ToString());
            //Moving Right Up
            output.Add(((x + 1)).ToString() + " " + (y).ToString());
            //Moving Right Down
            output.Add(((x - 1)).ToString() + " " + (y).ToString());
            //Moving Down Right
            output.Add((x).ToString() + " " + ((y - 1)).ToString());
            //Moving Down Left
            output.Add((x).ToString() + " " + ((y - 1)).ToString());
            //Moving Left Up
            output.Add((x).ToString() + " " + ((y - 1)).ToString());
            //Moving Left Down
            output.Add((x).ToString() + " " + ((y - 1)).ToString());

            return output;
        }
        public bool FirstMove { get; set; }
        

    }
}
