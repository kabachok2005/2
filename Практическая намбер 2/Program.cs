namespace Практическая_намбер_2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            MyProject();
        }
     
        static void Cycle()
        {
            OutputMenu();
            int ChoiseMain = Convert.ToInt32(Console.ReadLine());
            if (ChoiseMain == 0)
            {
                ExitOutOfProgram();
            }
            else if (ChoiseMain > 3)
            {
                Console.WriteLine("Ошибка. Вы ввели неверное значение");
            }
            else if (ChoiseMain < 0)
            {
                Console.WriteLine("Ошибка. Вы ввели неверное значение");
            }
            else
            {
                Outcome(ChoiseMain);
            }

        }
   
        static int Outcome(int choise)
        {
            if (choise == 1)
            {
                int guess = 0;
                GuessTheNumber(guess);
            }
            else if (choise == 2)
            {
                MultiplicationTable();
            }
            else if (choise == 3)
            {
                NumberDivisors();
            }
            else if (choise == 0)
            {
                ExitOutOfProgram();
            }
            return choise;
        }

        static void OutputMenu()
        {
            Console.WriteLine("Выберите:");
            Console.WriteLine("1. Игра Угадай число");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");
        }

        static void GuessTheNumber(int guess)
        {
            Random Random_Number = new Random();
            int rnd = Random_Number.Next(101);
            while (guess != rnd)
            {
                Console.Write("Введите число: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == rnd)
                {
                    Console.WriteLine("Вы угадали");
                }
                else if (guess > rnd)
                {
                    Console.WriteLine("Загаданое число меньше");
                }
                else if (guess < rnd)
                {
                    Console.WriteLine("Загаданое число больше");
                }
            }
            Cycle();
        }
 
        static void MultiplicationTable()
        {
            Console.WriteLine(" ");
            int[,] tablica = new int[10, 10];
            for (int x = 0; x < 10; x++)
                for (int y = 0; y < 10; y++)
                {
                    tablica[x, y] = (y + 1) * (x + 1);
                    Console.Write(tablica[x, y]);

                    if (y < 9) Console.Write("\t");
                    else Console.WriteLine();
                }
            Cycle();
        }
 
        static void NumberDivisors()
        {
            Console.Write("Введите число: ");
            double Num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Делители числа: ");
            int i = 0;
            while (Num > i)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            Console.WriteLine(Num);
            Cycle();
        }
  
        static void ExitOutOfProgram()
        {
            Console.WriteLine("Вы вышли из программы");
        }

        static void MyProject()
        {
            Cycle();
        }
    }
}