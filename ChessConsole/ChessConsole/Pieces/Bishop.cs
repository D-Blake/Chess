using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole.Pieces
{
    public class Bishop : Piece
    {
        char? key = 'B';
        char? lowerKey = 'b';
        public bool MatchesBishop(char? x)
        {
            return (x.Equals(key)|| x.Equals(lowerKey));
        }

        public char? GetChar()
        {
            return key;
        }

        public List<string> PossibleMoves(int x, int y)
        {
            List<string> output = new List<string>();
            //Moving Diagonal Up Right
            output.Add(((x + 1)).ToString() + " " + ((y-1)).ToString());
            output.Add(((x + 2)).ToString() + " " + ((y-2)).ToString());
            output.Add(((x + 3)).ToString() + " " + ((y - 3)).ToString());
            output.Add(((x + 4)).ToString() + " " + ((y - 4)).ToString());
            output.Add(((x + 5)).ToString() + " " + ((y - 5)).ToString());
            output.Add(((x + 6)).ToString() + " " + ((y - 6)).ToString());
            output.Add(((x + 7)).ToString() + " " + ((y - 7)).ToString());
            //Moving Diagonal Up Left
            output.Add(((x - 1)).ToString() + " " + ((y - 1)).ToString());
            output.Add(((x - 2)).ToString() + " " + ((y - 2)).ToString());
            output.Add(((x - 3)).ToString() + " " + ((y - 3)).ToString());
            output.Add(((x - 4)).ToString() + " " + ((y - 4)).ToString());
            output.Add(((x - 5)).ToString() + " " + ((y - 5)).ToString());
            output.Add(((x - 6)).ToString() + " " + ((y - 6)).ToString());
            output.Add(((x - 7)).ToString() + " " + ((y - 7)).ToString());
            //Moving Diagonal Down Right
            output.Add(((x + 1)).ToString() + " " + ((y + 1)).ToString());
            output.Add(((x + 2)).ToString() + " " + ((y + 2)).ToString());
            output.Add(((x + 3)).ToString() + " " + ((y + 3)).ToString());
            output.Add(((x + 4)).ToString() + " " + ((y + 4)).ToString());
            output.Add(((x + 5)).ToString() + " " + ((y + 5)).ToString());
            output.Add(((x + 6)).ToString() + " " + ((y + 6)).ToString());
            output.Add(((x + 7)).ToString() + " " + ((y + 7)).ToString());
            //Moving Diagonal Down Left
            output.Add(((x - 1)).ToString() + " " + ((y + 1)).ToString());
            output.Add(((x - 2)).ToString() + " " + ((y + 2)).ToString());
            output.Add(((x - 3)).ToString() + " " + ((y + 3)).ToString());
            output.Add(((x - 4)).ToString() + " " + ((y + 4)).ToString());
            output.Add(((x - 5)).ToString() + " " + ((y + 5)).ToString());
            output.Add(((x - 6)).ToString() + " " + ((y + 6)).ToString());
            output.Add(((x - 7)).ToString() + " " + ((y + 7)).ToString());

            return output;
        }
    }
}
