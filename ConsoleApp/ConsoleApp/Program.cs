internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введіть перше число:");
        if (double.TryParse(Console.ReadLine(), out double a))
        {

            Console.WriteLine("Введіть друге число:");
            if (double.TryParse(Console.ReadLine(), out double b))
            {

                double sum = a + b;

                Console.WriteLine($"Сума чисел {a} + {b} дорівнює {sum}");
            }
            else
            {
                Console.WriteLine("Помилка введення для другого числа");
            }
        }
        else
        {
            Console.WriteLine("Помилка введення для першого числа");
        }

        Console.ReadLine();
    }

}