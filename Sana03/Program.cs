using System.Text;

internal class Program
{
    static double sumOfNegativeElements(double[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0) sum += array[i];
        }
        return sum;
    }

    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Random random = new Random();

        int N = int.Parse(Console.ReadLine());

        double[] arr = new double[N];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(-100, 100);
            Console.WriteLine($"{i+1} - {arr[i]}");
        }

        double sumOfNegEl = sumOfNegativeElements(arr);
        Console.WriteLine($"Сума від'ємних елементів масиву = {sumOfNegEl}");

        Console.WriteLine($"");

    }
}