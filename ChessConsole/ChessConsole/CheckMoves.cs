using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessConsole
{
    class CheckMoves
    {
        public List<string> PossibleMove(Piece currentPiece, List<string> moves, char?[,] board, Piece[,] pieces)
        {
            Piece p = currentPiece;
            List<string> output = new List<string>();
            int x = 0;
            int y = 0;
            moves.RemoveAll(item => item.Contains("-"));

            for (int z = 0; z < moves.Count(); z++)
            {
                x = Int32.Parse((moves[z])[0].ToString());
                if (moves[z].Length == 4)
                {
                    y = Int32.Parse((moves[z])[2].ToString() + (moves[z])[3].ToString());
                }
                else
                {
                    y = Int32.Parse((moves[z])[2].ToString());
                }
                if (x > -1 && y > -1 && x < 8 && y < 8)
                {
                    if (!board[x, y].Equals(null) && pieces[x, y] != null)
                    {
                        switch (pieces[x, y].Color)
                        {
                            case "white":
                                if (!p.Color.Equals("white"))
                                {
                                    output.Add(moves[z]);
                                }
                                break;
                            case "black":
                                if (!p.Color.Equals("black"))
                                {
                                    output.Add(moves[z]);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else if (board[x, y].Equals(null))
                    {
                        output.Add(moves[z]);
                    }
                }
            }

            return output;
        }
    }
}