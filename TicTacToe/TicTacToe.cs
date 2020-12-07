﻿using System;

namespace TicTacToe
{
    class TicTacToe
    {
        public const int HEAD = 0;
        public const int TAILS = 1;
        public enum Player { USER, COMPUTER };
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game.");
            char[] board = CreateBoard();            
            int userMove = GetUserMove(board);
            Player player = GetWhoStartFirst();
            char userLetter = ChooseLetter();
            Console.WriteLine("Check if won " + IsWinner(board, userLetter));
            char computerLetter = (userLetter == 'X') ? 'O' : 'X';
            int computerMove = GetComputerMove(board, computerLetter);
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
        /// UC3-Display the board.
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
        /// UC4-Gets the user move.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <returns></returns>
        private static int GetUserMove(char[] board)
        {
            int[] validCells = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("What is your move between 1-9: ");
                int index = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(validCells, element => element == index) != 0 && IsSpaceFree(board, index)) ;
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
        /// <summary>
        /// UC5-Makes the move.
        /// </summary>
        /// <param name="board">The board.</param>
        /// <param name="index">The index.</param>
        /// <param name="letter">The letter.</param>
        private static void MakeMove(char[] board, int index, char letter)
        {
            bool spaceFree = IsSpaceFree(board, index);
            if (spaceFree) board[index] = letter;
        }
        /// <summary>
        /// UC6 Gets the who start first.
        /// </summary>
        /// <returns></returns>
        private static Player GetWhoStartFirst()
        {
            int toss = GetOneFromRandomChoices(2);
            return (toss == HEAD) ? Player.USER : Player.COMPUTER;
        }
        /// <summary>
        /// Gets the one from random choices.
        /// </summary>
        /// <param name="choices">The choices.</param>
        /// <returns></returns>
        private static int GetOneFromRandomChoices(int choices)
        {
            Random random = new Random();
            return (int)(random.Next() * 10) % choices;
        }
        /// <summary>
        /// UC7 Checks which on board user wins.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="ch"></param>
        /// <returns></returns>
        private static bool IsWinner(char[] b, char ch)
        { 
            return ((b[1] == ch && b[2] == ch && b[3] == ch) ||
                (b[4] == ch && b[5] == ch && b[6] == ch) ||
                (b[7] == ch && b[8] == ch && b[9] == ch ||
                b[1] == ch && b[5] == ch && b[9] == ch ||
                b[3] == ch && b[5] == ch && b[7] == ch ||
                b[1] == ch && b[4] == ch && b[7] == ch ||
                b[2] == ch && b[5] == ch && b[8] == ch ||
                b[3] == ch && b[6] == ch && b[9] == ch));
        }
        /// <summary>
        /// UC8 - Gets Computer move.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="computerLetter"></param>
        /// <returns></returns>
        private static int GetComputerMove(char[] board, char computerLetter)
        {
            int winningMove = GetWinningMove(board, computerLetter);
            if (winningMove != 0) return winningMove;
            return 0;
        }
        /// <summary>
        /// Gets Winning Move.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="letter"></param>
        /// <returns></returns>
        private static int GetWinningMove(char [] board, char letter)
        {
            for (int index = 0; index < board.Length; index++)
            {
                char[] copyofBoard = GetCopyOfBoard(board);
                if (IsSpaceFree(copyofBoard, index))
                {
                    MakeMove(copyofBoard, index, letter);
                    if (IsWinner(copyofBoard, letter))
                        return index;
                }
            }
            return 0;
        }
        private static char [] GetCopyOfBoard(char [] board)
        {
            char[] boardCopy = new char[10];
            Array.Copy(board, 0, boardCopy, 0, board.Length);
            return boardCopy;
        }
    }
}

