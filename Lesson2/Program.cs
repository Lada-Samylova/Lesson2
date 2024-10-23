using System;
using System.Net.Sockets;

namespace GuessNumber
{
    class Program
    {
        static void Main()
        {
            Random random = new Random(); //Для определения рандомного числа 
            string temp;
            int i = random.Next(100) + 1; // '+1' для того, чтобы в диапазон рандомных чисел было включено число 100
            Console.WriteLine("Угадай число от 1 до 100. У тебя 10 попыток");
            for (int j = 10; j > 0; j--) //Счетный цикл попыток
            {
                Console.WriteLine("Осталось попыток: " + j + ". Введи число: ");
                temp = Console.ReadLine();
                if (!int.TryParse(temp, out int Num)) //Для случаев, если буду введены не корректные значения
                {
                    j++;
                    continue; //Предложение ввести корректное значение снова, начиная с начала, не уходя в конец 
                }
                if (Num == i) 
                {
                    Console.WriteLine("Поздравляю! Ты угадал с " + (10 - j) + " попытки");

                    Console.WriteLine("Нажмите любую клавишу для выхода");
                    Console.ReadKey();
                    return;
                }
                else if (Num > i)
                {
                    Console.WriteLine("Загаданное число меньше");
                }
                else
                {
                    Console.WriteLine("Загаданное число больше");
                }
            }
            Console.WriteLine("Попытки закончились. Было загадано число " + i + ".");
            Console.WriteLine("Нажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}



 

           