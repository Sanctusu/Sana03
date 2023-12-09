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

    static double minElement(double[] array)
    {
        double min = array[0];
        for (int i = 1; i < array.Length; i++) { 
        if (array[i] < min) min = array[i];
        }
        return min;
    }

    static int indexOfMaxElemeent(double[] array)
    {
        int indexMax = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[indexMax]) indexMax = i;
        }
        return indexMax;
    }

    static double maxAbsElement(double[] array)
    {
        int max = 0;
        for(int i = 1; i < array.Length;i++)
        {
            if (Math.Abs(array[i]) > Math.Abs(array[max])) max = i;
        }
        return array[max];
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Random random = new Random();

        Console.WriteLine("Введіть кількість елементів масиву:");
        int N = int.Parse(Console.ReadLine());

        double[] arr = new double[N];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(-100, 100);
            Console.WriteLine($"{i+1} - {arr[i]}");
        }

        double sumOfNegEl = sumOfNegativeElements(arr);
        Console.WriteLine($"Сума від'ємних елементів масиву = {sumOfNegEl}");
        double minEl = minElement(arr);
        Console.WriteLine($"Мінімальний елемент масиву = {minEl}");
        double indexMaxEl = indexOfMaxElemeent(arr);
        Console.WriteLine($"Індекс максимального елементу масиву = {indexMaxEl}");
        double maxAbsEl = maxAbsElement(arr);
        Console.WriteLine($"Максимальний за модулем елемент масиву = {maxAbsEl}");


    }
}