using ChessConsole.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChessConsole
{
    public class Board
    {
        Queen Q = new Queen();
        Bishop B = new Bishop();
        Rook R = new Rook();
        King K = new King();
        Pawn P = new Pawn();
        Knight N = new Knight();


        char?[,] boardArray = new char?[8, 8];
        Piece[,] pieceArray = new Piece[8, 8];
        public Board(char?[,] array, Piece[,] pieces)
        {
            boardArray = array;
            pieceArray = pieces;
        }

        public void PrintBoard()
        {
            int y = 0;
            for (int x = 0; x < 8; x++)
            {
                if (boardArray[x, y].Equals(null))
                {
                    Console.Write("[" + x + "|" + y + "]" + "\t");
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

        public void ReadMoves()
        {
            List<string> moves = new List<string>();
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("testMove.txt");
            CheckMoves check = new CheckMoves();

            string pattern3 = @"[a-z][0-9][\s][a-z][0-9]";
            Match match;

            try
            {
                while ((line = file.ReadLine()) != null)
                {
                    match = Regex.Match(line, pattern3);
                    if (match.Success)
                    {
                        int x1;
                        int y1;
                        int x2;
                        int y2;

                        x1 = LetterConvert(line[0]);
                        y1 = NumberConvert(line[1]);
                        x2 = LetterConvert(line[3]);
                        y2 = NumberConvert(line[4]);

                        Console.WriteLine("-------------------------------------------------------");

                        if (Q.MatchesQueen(boardArray[x1, y1]))
                        {
                            moves = check.PossibleMove(pieceArray[x1, y1], Q.PossibleMoves(x1, y1), boardArray, pieceArray);
                            moves.RemoveAll(item => item.Contains("-"));
                            if (moves.Contains(x2 + " " + y2))
                            {
                                boardArray[x1, y1] = null;
                                if (pieceArray[x1, y1].Color.Equals("white"))
                                {
                                    boardArray[x2, y2] = 'Q';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                else
                                {
                                    boardArray[x2, y2] = 'q';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                PrintBoard();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move");
                            }
                        }
                        else if (K.MatchesKing(boardArray[x1, y1]))
                        {
                            moves = check.PossibleMove(pieceArray[x1, y1], K.PossibleMoves(x1, y1), boardArray, pieceArray);
                            moves.RemoveAll(item => item.Contains("-"));
                            if (moves.Contains(x2 + " " + y2))
                            {
                                boardArray[x1, y1] = null;
                                if (pieceArray[x1, y1].Color.Equals("white"))
                                {
                                    boardArray[x2, y2] = 'K';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                else
                                {
                                    boardArray[x2, y2] = 'k';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                PrintBoard();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move");
                            }
                        }
                        else if (R.MatchesRook(boardArray[x1, y1]))
                        {
                            moves = check.PossibleMove(pieceArray[x1, y1], R.PossibleMoves(x1, y1), boardArray, pieceArray);
                            moves.RemoveAll(item => item.Contains("-"));
                            if (moves.Contains(x2 + " " + y2))
                            {
                                boardArray[x1, y1] = null;
                                if (pieceArray[x1, y1].Color.Equals("white"))
                                {
                                    boardArray[x2, y2] = 'R';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                else
                                {
                                    boardArray[x2, y2] = 'r';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                PrintBoard();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move");
                            }
                        }
                        else if (B.MatchesBishop(boardArray[x1, y1]))
                        {
                            moves = check.PossibleMove(pieceArray[x1, y1], B.PossibleMoves(x1, y1), boardArray, pieceArray);
                            moves.RemoveAll(item => item.Contains("-"));
                            if (moves.Contains(x2 + " " + y2))
                            {
                                boardArray[x1, y1] = null;
                                if (pieceArray[x1, y1].Color.Equals("white"))
                                {
                                    boardArray[x2, y2] = 'B';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                else
                                {
                                    boardArray[x2, y2] = 'b';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                PrintBoard();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move");
                            }
                        }
                        else if (N.MatchesKnight(boardArray[x1, y1]))
                        {
                            moves = check.PossibleMove(pieceArray[x1, y1], N.PossibleMoves(x1, y1), boardArray, pieceArray);
                            moves.RemoveAll(item => item.Contains("-"));
                            if (moves.Contains(x2 + " " + y2))
                            {
                                boardArray[x1, y1] = null;
                                if (pieceArray[x1, y1].Color.Equals("white"))
                                {
                                    boardArray[x2, y2] = 'N';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                else
                                {
                                    boardArray[x2, y2] = 'n';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                PrintBoard();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move");
                            }
                        }
                        else if (P.MatchesPawn(boardArray[x1, y1]))
                        {
                            moves = check.PossibleMove(pieceArray[x1, y1], P.PossibleMoves(x1, y1, pieceArray[x1, y1].Color), boardArray, pieceArray);
                            moves.RemoveAll(item => item.Contains("-"));

                            if (moves.Contains(x2 + " " + y2))
                            {
                                boardArray[x1, y1] = null;
                                if (pieceArray[x1, y1].Color.Equals("white"))
                                {
                                    boardArray[x2, y2] = 'P';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                else
                                {
                                    boardArray[x2, y2] = 'p';
                                    pieceArray[x2, y2] = pieceArray[x1, y1];
                                    pieceArray[x1, y1] = null;
                                }
                                PrintBoard();
                            }
                            else
                            {
                                Console.WriteLine("Invalid Move");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error: Bad Move");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
        }

        public int LetterConvert(char x)
        {
            int output = 0;
            if (x.Equals('a'))
            {
                output = 0;
            }
            else if (x.Equals('b'))
            {
                output = 1;
            }
            else if (x.Equals('c'))
            {
                output = 2;
            }
            else if (x.Equals('d'))
            {
                output = 3;
            }
            else if (x.Equals('e'))
            {
                output = 4;
            }
            else if (x.Equals('f'))
            {
                output = 5;
            }
            else if (x.Equals('g'))
            {
                output = 6;
            }
            else if (x.Equals('h'))
            {
                output = 7;
            }

            return output;
        }


        public int NumberConvert(char number)
        {
            int x = Int32.Parse((number.ToString()));

            if (x == 8)
            {
                x = 0;
            }
            else if (x == 7)
            {
                x = 1;
            }
            else if (x == 6)
            {
                x = 2;
            }
            else if (x == 5)
            {
                x = 3;
            }
            else if (x == 4)
            {
                x = 4;
            }
            else if (x == 3)
            {
                x = 5;
            }
            else if (x == 2)
            {
                x = 6;
            }
            else if (x == 1)
            {
                x = 7;
            }
            return x;
        }

        public char?[,] GetBoard()
        {
            return boardArray;
        }

    }
}
