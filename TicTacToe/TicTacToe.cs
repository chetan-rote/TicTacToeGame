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
    }
}
