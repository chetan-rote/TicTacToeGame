using System;

namespace TicTacToe
{
    class TicTacToe
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game.");
            char[] board = CreateBoard();
            char userLetter = ChooseLetter();
            DisplayBoard(board);
        }
        /// <summary>
        /// UC1-Creates the board.
        /// </summary>
        private static char[] CreateBoard()
        {
            char[] board = new char[10];
            for (int index = 0; index < board.Length; index++)
            {
                board[index] = ' ';
            }
            return board;
        }
        /// <summary>
        /// UC2- Allows user to Choose the letter.
        /// </summary>
        private static char ChooseLetter()
        {
            Console.WriteLine("Choose your letter.");
            string userLetter = Console.ReadLine();
            return char.ToUpper(userLetter[0]);
        }
        /// <summary>
        /// Display the board.
        /// </summary>
        /// <param name="board">The board.</param>
        private static void DisplayBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("-----------");
            Console.WriteLine(" " + board[7] + " | " + board[8] + " | " + board[9]);
        }
    }
}
