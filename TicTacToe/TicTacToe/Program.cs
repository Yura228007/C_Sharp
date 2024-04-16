using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToe
{
    class Program
    {
        static char[,] board;
        static char currentPlayer;
        static bool gameover;
        static bool enemyIsBot = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру Крестики-нолики!");

            Console.Write("Введите желаемый символ для Игрока 1:");
            char player1Symbol = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите желаемый символ для Игрока 2:");
            char player2Symbol = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите какой игрок будет ходить первым: ");
            int choiceFirst = int.Parse(Console.ReadLine());

            Console.WriteLine("Вы хотите играть с роботом? \n1.Да\n2.Нет");
            int choiceBot = int.Parse(Console.ReadLine());
            if (choiceBot == 1) { enemyIsBot = true; }
            else { enemyIsBot = false; }


            // Инициализация поля
            board = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            // Определение текущего игрока
            if (choiceFirst == 1)
            {
                currentPlayer = player1Symbol;
            }
            else
            {
                currentPlayer = player2Symbol;
            }


            // Игровой цикл
            if (!enemyIsBot)
            {
                //для двух игроков
            }
            while (!gameover)
            {
                DrawBoard();
                if (currentPlayer == player2Symbol && enemyIsBot)
                {
                    Console.WriteLine("Ход бота...");
                    MakeMoveForBot(currentPlayer);
                }
                else { MakeMove(currentPlayer); }

                if (CheckWin(currentPlayer))
                {
                    DrawBoard();
                    Console.WriteLine("Игрок " + currentPlayer + " победил!");
                    gameover = true;
                }
                else if (CheckDraw())
                {
                    DrawBoard();
                    gameover = false;
                    break;
                }
                else
                {
                    currentPlayer = (currentPlayer == player1Symbol) ? player2Symbol : player1Symbol;
                }
            }
            if (gameover)
            {
                Console.WriteLine($"Игра окончена! Игрок {currentPlayer} победил!");
            }
            else
            {
                Console.WriteLine("Игра окончена! Ничья на поле!");
            }
            Console.ReadKey();
        }

        static void DrawBoard()
        {
            Console.WriteLine("-------------");
            for (int i = 2; i >= 0; i--)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " | ");
                }
                Console.WriteLine("\n-------------");
            }
        }

        static void MakeMove(char symbol)
        {
            bool validMove = false;
            while (!validMove)
            {
                Console.Write("Игрок " + symbol + ", выберите ячейку (1-9): ");
                int choice;
                bool f = int.TryParse(Console.ReadLine(), out choice);
                while (!f)
                {
                    Console.WriteLine("Неверное значение! Попробуй еще раз");
                    f = int.TryParse(Console.ReadLine(), out choice);
                }
                int row = (choice - 1) / 3;
                int col = (choice - 1) % 3;


                if (board[row, col] == ' ')
                {
                    board[row, col] = symbol;
                    validMove = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ход. Попробуйте еще раз.");
                }
            }
        }

        static void MakeMoveForBot(char symbol)
        {
            bool validMove = false;
            while (!validMove)
            {
                Random random = new Random();
                int choice = random.Next(1, 10);
                int row = (choice - 1) / 3;
                int col = (choice - 1) % 3;

                if (board[row, col] == ' ')
                {
                    board[row, col] = symbol;
                    validMove = true;
                }
            }
        }

        static bool CheckWin(char symbol)
        {
            // Проверка по горизонтали
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
                {
                    return true;
                }
            }

            // Проверка по вертикали
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol)
                {
                    return true;
                }
            }

            // Проверка по диагоналям
            if ((board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
                (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol))
            {
                return true;
            }

            return false;
        }

        static bool CheckDraw()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}