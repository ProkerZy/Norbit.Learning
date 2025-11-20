namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Введите число: ");

            //int num = int.Parse(Console.ReadLine());
            //DrawHallowSquare(num);
            CheckGreeting();

            Console.ReadLine();
        }
        static int[] GetOddNumbers(int num)
        {
            Console.WriteLine("Нечетные числа: ");
            int[] array = new int[num];
            int index = 0;
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    array[index] = i;
                    index++;
                    Console.Write(i + " ");
                }
            }

            return array;
        }
        static void DrawHallowSquare(int length)
        {

            for (int i = 0; i < length; i++)
            {
                if (i == 0 || i == length - 1)
                {
                    for (int j = 0; j < length; j++)
                    {
                        Console.Write("X ");
                    }
                }
                else
                {
                    Console.Write("X ");
                    for (int j = 1; j <= length - 2; j++) // вычитаем по символу с краев
                    {
                        Console.Write("  ");
                    }
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        static void CheckGreeting()
        {
            Console.WriteLine("Поздоровайтесь!");
            string anyWord = Console.ReadLine();
            string neededWord = "hello";
            int index = 0;

            for (int i = 0; i < anyWord.Length; i++)
            {
                char current = anyWord[i];

                if (current == neededWord[index])
                {
                    index++;
                    if (index == 5)
                    {
                        break;
                    }
                }

            }
            if (index == 5)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
                
        }
    }
}
