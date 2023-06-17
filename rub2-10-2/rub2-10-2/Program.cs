using static System.Reflection.Metadata.BlobBuilder;

namespace rub2_10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите длины сторон треугольника:");
            double[] part = new double[3];
            while (true)
            {
                for (int i = 0; i < part.Length; i++)
                {
                    if (!Double.TryParse(Console.ReadLine(), out part[i]) || part[i] <= 0)
                    {
                        Console.WriteLine("Ошибка: введите положительное число");
                        i--;
                    }
                }
                if (part[0] + part[1] > part[2])
                {
                    Console.WriteLine("Ошибка: данный треугольник не может существовать");
                }
                else break;
            }

            Triangle triangle = new Triangle(part);
            while(true)
            {
                Console.WriteLine("1:Вычисления площади. \n" +
                    "2:Вычисления периметра. \n" +
                    "3:Вычисления точки пересечения медиан \n" +
                    "4:Выйти из меню");
                int a = Convert.ToInt32(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.WriteLine($"Периметр:");
                        Console.WriteLine($"{triangle.Perimeter()}");
                        ; break;
                    case 2:
                        triangle.Squares();
                        break;
                    case 3:
                        triangle.MedianIntersectionPoint();
                        break;
                    case 4:; return;
                }
            }
        }
    }
}