using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Program
{
    class ChessPiece
    {
        protected internal int x;
        protected internal int y;
        protected internal string label;

        public ChessPiece(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }

        public virtual bool CanAttack(ChessPiece target)
        {

            return false;
        }
    }

    class Pawn : ChessPiece
    {
        public Pawn(int x, int y, string label) : base(x, y, label) { }

        public override bool CanAttack(ChessPiece target)
        {

            if (Math.Abs(target.x - x) == 1 && Math.Abs(target.y - y) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Queen : ChessPiece
    {
        public Queen(int x, int y, string label) : base(x, y, label) { }

        public override bool CanAttack(ChessPiece target)
        {

            if (target.x == x || target.y == y || Math.Abs(target.x - x) == Math.Abs(target.y - y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Horse : ChessPiece
    {
        public Horse(int x, int y, string label) : base(x, y, label) { }

        public override bool CanAttack(ChessPiece target)
        {

            if ((Math.Abs(target.x - x) == 2 && Math.Abs(target.y - y) == 1) || (Math.Abs(target.x - x) == 1 && Math.Abs(target.y - y) == 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Выберите фигуру, которой вы будете ходить: 1. Пешка; 2. Конь; 3. Ферзь");
                int user_input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Задайте позицию фигуре, которую вы выбрали: ");

                ChessPiece selectedPiece = null;
                string selectedPieceLabel = "";

                if (user_input == 1)
                {
                    selectedPieceLabel = "Пешка";
                    selectedPiece = new Pawn(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), selectedPieceLabel);
                }
                else if (user_input == 2)
                {
                    selectedPieceLabel = "Конь";
                    selectedPiece = new Horse(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), selectedPieceLabel);
                }
                else if (user_input == 3)
                {
                    selectedPieceLabel = "Ферзь";
                    selectedPiece = new Queen(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), selectedPieceLabel);
                }

                Console.WriteLine($"Вы выбрали {selectedPieceLabel} на позиции ({selectedPiece.x}, {selectedPiece.y}).");

                Console.WriteLine("Введите позиции двух оставшихся фигур:");

                List<ChessPiece> allPieces = new List<ChessPiece>();
                allPieces.Add(selectedPiece);

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Введите позицию фигуры {i + 1}: ");
                    int pieceX = Convert.ToInt32(Console.ReadLine());
                    int pieceY = Convert.ToInt32(Console.ReadLine());
                    allPieces.Add(new ChessPiece(pieceX, pieceY, $"Фигура {i + 1}"));
                }

                Console.WriteLine("Список фигур, которые могут быть атакованы:");

                foreach (ChessPiece piece in allPieces)
                {
                    if (selectedPiece.CanAttack(piece))
                    {
                        Console.WriteLine($"{piece.label} на позиции ({piece.x}, {piece.y}) может быть атакована.");
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода!!!");
                Main();
            }

        }
    }
}
