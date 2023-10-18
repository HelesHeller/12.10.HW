using System;
using System.Linq;

interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

class ArrayCalculator : ICalc
{
    private int[] array;

    public ArrayCalculator(int[] array)
    {
        this.array = array;
    }

    public int Less(int valueToCompare)
    {
        return array.Count(num => num < valueToCompare);
    }

    public int Greater(int valueToCompare)
    {
        return array.Count(num => num > valueToCompare);
    }
}

interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

class ArrayOutput : IOutput2
{
    private int[] array;

    public ArrayOutput(int[] array)
    {
        this.array = array;
    }

    public void ShowEven()
    {
        Console.WriteLine("Парні елементи:");
        foreach (var num in array)
        {
            if (num % 2 == 0)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }

    public void ShowOdd()
    {
        Console.WriteLine("Непарні елементи:");
        foreach (var num in array)
        {
            if (num % 2 != 0)
            {
                Console.Write(num + " ");
            }
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        ArrayCalculator calculator = new ArrayCalculator(numbers);
        ArrayOutput output = new ArrayOutput(numbers);

        int lessCount = calculator.Less(6);
        int greaterCount = calculator.Greater(6);

        Console.WriteLine($"Кількість елементів менших за 6: {lessCount}");
        Console.WriteLine($"Кількість елементів більших за 6: {greaterCount}");

        output.ShowEven();
        output.ShowOdd();
    }
}
