using System;

internal class Triangle
{

    public Triangle()
    {

    }

    public void ShowTriangle()
    {
        Console.Write("Введите количество строк: ");
        int height = int.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void ShowAnotherTriangle()
    {
        Console.Write("Введите количество строк: ");
        int height = int.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(height - i, i + 1);
            for (int j = 0; j <= i * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public void ShowMasTreeTriangle()
    {
        Console.Write("Введите количество строк: ");
        int height = int.Parse(Console.ReadLine());
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(height - i, i + 1);
            for (int j = 0; j <= i * 2; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}