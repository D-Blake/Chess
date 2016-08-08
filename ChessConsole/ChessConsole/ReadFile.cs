using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ChessConsole
{
    public class ReadFile
    {
        char?[,] board = new char?[8,8];
        char piece;
        int x;
        int y;

        public char?[,] getCharArray()
        {
            return board;
        }

        public string DisplayLineMeaning()
        {
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader("test.txt");
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
                switch (input[1])
                {
                    case 'l':
                        Console.Write("White ");
                        break;
                    case 'd':
                        Console.Write("Black ");
                        break;
                    default:
                        Console.Write("Kek");
                        break;
                }
                switch (input[0])
                {
                    case 'K':
                        Console.Write("King ");
                        piece = 'K';
                        break;
                    case 'Q':
                        Console.Write("Queen ");
                        piece = 'Q';
                        break;
                    case 'B':
                        Console.Write("Bishop ");
                        piece = 'B';
                        break;
                    case 'N':
                        Console.Write("Knight ");
                        piece = 'N';
                        break;
                    case 'R':
                        Console.Write("Rook ");
                        piece = 'R';
                        break;
                    case 'P':
                        Console.Write("Pawn ");
                        piece = 'P';
                        break;
                    default:
                        Console.Write("Kek");
                        break;
                }
                Console.WriteLine("placed at " + input[2]+input[3]);
                PlaceInArray(input[2], input[3], piece);
            }
            else if (input.Length == 5 || input.Length == 6)
            {
                if (input.Length == 5)
                {
                    Console.WriteLine("Moves the piece at " + input[0] + input[1] + " to " + input[3] + input[4]);
                }
                else if(input.Length == 6)
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
        public void PlaceInArray(char letter, char number, char piece)
        {
            x = Int32.Parse((number.ToString()));
            x = x - 1;
            
            if(letter.Equals('a'))
            {
                y = 0;
            }
            else if (letter.Equals('b'))
            {
                y = 1;
            }
            else if (letter.Equals('c'))
            {
                y = 2;
            }
            else if (letter.Equals('d'))
            {
                y = 3;
            }
            else if (letter.Equals('e'))
            {
                y = 4;
            }
            else if (letter.Equals('f'))
            {
                y = 5;
            }
            else if (letter.Equals('g'))
            {
                y = 6;
            }
            else if (letter.Equals('h'))
            {
                y = 7;
            }
            board[y, x] = piece;
        }
    }

}
