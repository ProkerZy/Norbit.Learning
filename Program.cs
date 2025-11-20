namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число: ");

            int num = int.Parse(Console.ReadLine());
            DrawSquare(num);
            Console.WriteLine();
            GetOddNumbers(num);
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
        static void DrawSquare(int length)
        {

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }
        }
    }
}
