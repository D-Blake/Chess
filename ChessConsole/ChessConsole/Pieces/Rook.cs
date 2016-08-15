using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.Pieces
{
    public class Rook : Piece
    {
        char? key = 'R';
        char? lowerKey = 'r';

        public bool MatchesRook(char? x)
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
            output.Add((x).ToString() + " " + ((y - 2)).ToString());
            output.Add((x).ToString() + " " + ((y - 3)).ToString());
            output.Add((x).ToString() + " " + ((y - 4)).ToString());
            output.Add((x).ToString() + " " + ((y - 5)).ToString());
            output.Add((x).ToString() + " " + ((y - 6)).ToString());
            output.Add((x).ToString() + " " + ((y - 7)).ToString());
            //Moving Down
            output.Add((x).ToString() + " " + ((y + 1)).ToString());
            output.Add((x).ToString() + " " + ((y + 2)).ToString());
            output.Add((x).ToString() + " " + ((y + 3)).ToString());
            output.Add((x).ToString() + " " + ((y + 4)).ToString());
            output.Add((x).ToString() + " " + ((y + 5)).ToString());
            output.Add((x).ToString() + " " + ((y + 6)).ToString());
            output.Add((x).ToString() + " " + ((y + 7)).ToString());
            //Moving Right
            output.Add(((x + 1)).ToString() + " " + y.ToString());
            output.Add(((x + 2)).ToString() + " " + y.ToString());
            output.Add(((x + 3)).ToString() + " " + y.ToString());
            output.Add(((x + 4)).ToString() + " " + y.ToString());
            output.Add(((x + 5)).ToString() + " " + y.ToString());
            output.Add(((x + 6)).ToString() + " " + y.ToString());
            output.Add(((x + 7)).ToString() + " " + y.ToString());
            //Moving Left
            output.Add(((x - 1)).ToString() + " " + y.ToString());
            output.Add(((x - 2)).ToString() + " " + y.ToString());
            output.Add(((x - 3)).ToString() + " " + y.ToString());
            output.Add(((x - 4)).ToString() + " " + y.ToString());
            output.Add(((x - 5)).ToString() + " " + y.ToString());
            output.Add(((x - 6)).ToString() + " " + y.ToString());
            output.Add(((x - 7)).ToString() + " " + y.ToString());

            return output;
        }
    }
}
