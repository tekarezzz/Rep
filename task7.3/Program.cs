using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого короля (например, e4):");
            var whiteKingPosition = Console.ReadLine();
            if (!IsPositionCorrect(whiteKingPosition))
            {
                Console.WriteLine("Некорректная позиция белого короля");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию черного слона (например, c5):");
            var blackBishopPosition = Console.ReadLine();
            if (!IsPositionCorrect(blackBishopPosition) || whiteKingPosition == blackBishopPosition)
            {
                Console.WriteLine("Черный слон не должен стоять на той же клетке, что и белый король");
                Console.ReadKey();
                return;
            }

            if (IsUnderAttack(whiteKingPosition, blackBishopPosition))
            {
                Console.WriteLine("Белый король находится под атакой черного слона");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите позицию предполагаемого хода белого короля (например, e5):");
            var movePosition = Console.ReadLine();
            if (IsKingMoveValid(whiteKingPosition, movePosition) && !IsUnderAttack(movePosition, blackBishopPosition))
            {
                Console.WriteLine("Ход разрешен: белый король может переместиться на " + movePosition);
            }
            else
            {
                Console.WriteLine("Ход запрещен: белый король не может переместиться на " + movePosition);
            }

            Console.ReadKey();
        }

        static bool IsPositionCorrect(string position)
        {
            if (position.Length != 2)
                return false;

            int row;
            int column;
            DecodePosition(position, out column, out row);
            return column >= 1 && column <= 8 && row >= 1 && row <= 8;
        }

        static bool IsUnderAttack(string kingPosition, string bishopPosition)
        {
            int kr, kc, br, bc;
            DecodePosition(kingPosition, out kc, out kr);
            DecodePosition(bishopPosition, out bc, out br);

            return Math.Abs(kc - bc) == Math.Abs(kr - br);
        }

        static bool IsKingMoveValid(string startPosition, string movePosition)
        {
            if (!IsPositionCorrect(movePosition))
                return false;

            int startColumn, startRow, moveColumn, moveRow;
            DecodePosition(startPosition, out startColumn, out startRow);
            DecodePosition(movePosition, out moveColumn, out moveRow);

            return Math.Abs(startColumn - moveColumn) <= 1 && Math.Abs(startRow - moveRow) <= 1;
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = position[0] - 'a' + 1;
        }
    }
}
