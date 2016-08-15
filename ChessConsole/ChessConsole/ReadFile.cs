using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ChessConsole.Pieces;

namespace ChessConsole
{
    public class ReadFile
    {
        char?[,] board = new char?[8, 8];
        Piece[,] pieces = new Piece[8, 8];
        char piece;
        string fileName;
        int x;
        int y;



        public ReadFile(string s)
        {
            fileName = s;
        }

        public char?[,] getCharArray()
        {
            return board;
        }
        public Piece[,] getPiecesArray()
        {
            return pieces;
        }

        public string DisplayLineMeaning()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
            string pattern1 = @"[A-Z][a-z][a-z][0-9]";
            string pattern2 = @"[a-z][0-9][\s][a-z][0-9][\s][a-z][0-9][\s][a-z][0-9]";
            string pattern3 = @"[a-z][0-9][\s][a-z][0-9]";
            Match match;

            try
            {
                while ((line = file.ReadLine()) != null)
                {

                    match = Regex.Match(line, pattern1);
                    if (match.Success)
                    {
                        Console.Write(match.ToString() + "= ");
                        MatchAndPrintSpot(line.Trim());
                    }

                    match = Regex.Match(line, pattern2);
                    if (match.Success)
                    {
                        Console.Write(match.ToString() + "= ");
                        MatchAndPrintSpot(line.Trim());
                    }
                    else
                    {
                        match = Regex.Match(line, pattern3);
                        if (match.Success)
                        {
                            Console.Write(match.ToString() + "= ");
                            MatchAndPrintSpot(line.Trim());
                        }

                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);
            }
            return "";
        }

        public void MatchAndPrintSpot(string input)
        {
            if (input.Length == 4)
            {
                switch (input[0])
                {
                    case 'K':
                        Console.Write("King ");
                        King k = new King();
                        if (input[1].Equals('l'))
                        {
                            k.Color = "white";
                            piece = 'K';
                        }
                        else if (input[1].Equals('d'))
                        {
                            k.Color = "black";
                            piece = 'k';
                        }
                        x = getXCoord(input[2]);
                        y = getYCoord(input[3]);
                        pieces[x, y] = k;
                        break;
                    case 'Q':
                        Console.Write("Queen ");
                        Queen q = new Queen();
                        if (input[1].Equals('l'))
                        {
                            q.Color = "white";
                            piece = 'Q';
                        }
                        else if (input[1].Equals('d'))
                        {
                            q.Color = "black";
                            piece = 'q';
                        }
                        x = getXCoord(input[2]);
                        y = getYCoord(input[3]);
                        pieces[x, y] = q;
                        break;
                    case 'B':
                        Console.Write("Bishop ");
                        Bishop b = new Bishop();
                        if (input[1].Equals('l'))
                        {
                            b.Color = "white";
                            piece = 'B';
                        }
                        else if (input[1].Equals('d'))
                        {
                            b.Color = "black";
                            piece = 'b';
                        }
                        x = getXCoord(input[2]);
                        y = getYCoord(input[3]);
                        pieces[x, y] = b;
                        break;
                    case 'N':
                        Console.Write("Knight ");
                        Knight n = new Knight();
                        if (input[1].Equals('l'))
                        {
                            n.Color = "white";
                            piece = 'N';
                        }
                        else if (input[1].Equals('d'))
                        {
                            n.Color = "black";
                            piece = 'n';
                        }
                        x = getXCoord(input[2]);
                        y = getYCoord(input[3]);
                        pieces[x, y] = n;
                        break;
                    case 'R':
                        Console.Write("Rook ");
                        Rook r = new Rook();
                        if (input[1].Equals('l'))
                        {
                            r.Color = "white";
                            piece = 'R';
                        }
                        else if (input[1].Equals('d'))
                        {
                            r.Color = "black";
                            piece = 'r';
                        }
                        x = getXCoord(input[2]);
                        y = getYCoord(input[3]);
                        pieces[x, y] = r;
                        break;
                    case 'P':
                        Console.Write("Pawn ");
                        Pawn p = new Pawn();
                        if (input[1].Equals('l'))
                        {
                            p.Color = "white";
                            piece = 'P';
                        }
                        else if (input[1].Equals('d'))
                        {
                            p.Color = "black";
                            piece = 'p';
                        }
                        x = getXCoord(input[2]);
                        y = getYCoord(input[3]);
                        pieces[x, y] = p;
                        break;
                    default:
                        Console.Write("Kek");
                        break;
                }
                Console.WriteLine("placed at " + input[2] + input[3]);
                PlaceInArray(input[2], input[3], piece);
            }
            else if (input.Length == 5 || input.Length == 6)
            {
                if (input.Length == 5)
                {
                    Console.WriteLine("Moves the piece at " + input[0] + input[1] + " to " + input[3] + input[4]);

                }
                else if (input.Length == 6)
                {
                    Console.WriteLine("Moves the piece at " + input[0] + input[1] + " to " + input[3] + input[4] + " and captures the piece at " + input[3] + input[4]);
                }
            }
            else if (input.Length == 11)
            {
                Console.Write("Moves the piece at " + input[0] + input[1] + " to " + input[3] + input[4]);
                Console.WriteLine(" and then moves the piece at " + input[6] + input[7] + " to " + input[9] + input[10]);
            }
        }
        public int getXCoord(char letter)
        {
            if (letter.Equals('a'))
            {
                x = 0;
            }
            else if (letter.Equals('b'))
            {
                x = 1;
            }
            else if (letter.Equals('c'))
            {
                x = 2;
            }
            else if (letter.Equals('d'))
            {
               x = 3;
            }
            else if (letter.Equals('e'))
            {
                x = 4;
            }
            else if (letter.Equals('f'))
            {
                x = 5;
            }
            else if (letter.Equals('g'))
            {
                x = 6;
            }
            else if (letter.Equals('h'))
            {
                x = 7;
            }
            return x;
        }
        public int getYCoord(char number)
        {
            y = Int32.Parse((number.ToString()));

            if (y == 8)
            {
                y = 0;
            }
            else if (y == 7)
            {
                y = 1;
            }
            else if (y == 6)
            {
                y = 2;
            }
            else if (y == 5)
            {
                y = 3;
            }
            else if (y == 4)
            {
                y = 4;
            }
            else if (y == 3)
            {
                y = 5;
            }
            else if (y == 2)
            {
                y = 6;
            }
            else if (y == 1)
            {
                y = 7;
            }
            return y;
        }
        public void PlaceInArray(char letter, char number, char piece)
        {
            y = getYCoord(number);
            x = getXCoord(letter);

            
            board[x, y] = piece;
        }
    }

}
