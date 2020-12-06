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
            DisplayBoard(board);
            int userMove = GetUserMove(board);
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
        /// <summary>
        /// Gets the user move.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns></returns>
        private static int GetUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            while (true)
            {
                Console.WriteLine("What is your move between 1-9: ");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, element => element == index) != 0 && IsSpaceFree(board, index));
                return index;
            }
        }
        /// <summary>
        /// Determines whether space is free.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="index">The index.</param>
        /// <returns>
        ///   <c>true</c> if [is space free] [the specified board]; otherwise, <c>false</c>.
        /// </returns>
        private static bool IsSpaceFree(char[] board, int index)
        {
            return board[index] == ' ';
        }
    }
}
