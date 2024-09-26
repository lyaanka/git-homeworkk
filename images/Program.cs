using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Matrica matrica = new Matrica();
        matrica.Zapolnit();
        Console.WriteLine("1 массив:");
        matrica.Vivod(matrica.Massive1);

        Console.WriteLine("\n2 массив:");
        matrica.Vivod(matrica.Massive2);

        Console.WriteLine("\nУмноженный на 10 первый массив:");
        matrica.Umnozhit();

        Console.WriteLine("\nРезультат умножения матриц:");
        matrica.UmnozhitMatric();
        Console.ReadKey();
    }
}

class Matrica
{
    public const int A = 4, B = 5;
    public double[,] Massive1 { get; private set; } = new double[A, B];
    public double[,] Massive2 { get; private set; } = new double[A, B];
    public Random Rand { get; } = new Random();


    public void Zapolnit()
    {
        for (int i = 0; i < A; i++)
        {
            for (int j = 0; j < B; j++)
            {
                Massive1[i, j] = Rand.Next(1, 10) + Rand.NextDouble();
                Massive2[i, j] = Rand.Next(1, 10) + Rand.NextDouble();
            }
        }
    }

    public void Umnozhit()
    {
        for (int i = 0; i < A; i++)
        {
            for (int j = 0; j < B; j++)
            {
                Console.Write(Math.Round((Massive1[i, j] * 10), 2) + " ");
            }
            Console.WriteLine();
        }
    }

    public void Vivod(double[,] array)
    {
        for (int i = 0; i < A; i++)
        {
            for (int j = 0; j < B; j++)
            {
                Console.Write(Math.Round(array[i, j], 2) + " ");
            }
            Console.WriteLine();
        }
    }


    public void UmnozhitMatric()
    {
        double[,] result = new double[A, B];

        for (int i = 0; i < A; i++)
        {
            for (int j = 0; j < B; j++)
            {
                result[i, j] = Math.Round(Massive1[i, j] * Massive2[i, j], 2);
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}