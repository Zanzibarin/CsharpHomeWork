using System;

namespace PracticeFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string chees_move = GetFromUser(); // Получаем от пользователя данные о направлении хода фигуры
            if (chees_move.Length == 5)
            {
                string start_move = chees_move.Substring(0, 2).ToLower();
                string finish_move = chees_move.Substring(3, 2).ToLower();

                char start_row = start_move.ToCharArray()[0];
                char start_col = start_move.ToCharArray()[1];
                int start_row_int = (int)start_row;
                int start_col_int = (int)start_col;

                char finish_row = finish_move.ToCharArray()[0];
                char finish_col = finish_move.ToCharArray()[1];
                int finish_row_int = (int)finish_row;
                int finish_col_int = (int)finish_col;

                //Расчёт правильности хода фигуры
                if (96 < start_row_int && start_row_int < 105 &&
                    96 < finish_row_int && finish_row_int < 105 &&
                    start_col_int > 48 && start_col_int < 57 &&
                    finish_col_int > 48 && finish_col_int < 57)
                {
                    if (start_row_int - finish_row_int == start_col_int - finish_col_int)
                    { Console.WriteLine("Ход верный"); }
                    else if (start_row_int == finish_row_int && start_col_int - finish_col_int != 0)
                    { Console.WriteLine("Ход верный"); }
                    else if (start_row_int - finish_row_int != 0 && start_col_int == finish_col_int)
                    { Console.WriteLine("Ход верный"); }
                    else { Mistake(0); }
                }
                else { Mistake(1); }



            }
            else { Mistake(2); }
        }
        static string GetFromUser() //Метод получения информаци о ходе фигуры от пользователя
        {
            Console.WriteLine("Ваш ход");
            string chees_move = Console.ReadLine();
            return chees_move;
        }
        static void Mistake(int n) { Console.WriteLine($"Ошибка ввода{n}"); } //Метод действий при ошибке
    }
}