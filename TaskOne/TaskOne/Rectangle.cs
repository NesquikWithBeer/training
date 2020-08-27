using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using TaskOne;

internal class Rectangle
{

    public Rectangle()
    {

    }


    public void GetArea()
    {
      
        int firstSide = GetSideLenght();
        int secondSide = GetSideLenght();

        Console.WriteLine("Площадь прямоугольника: " + (firstSide * secondSide));
      
    }

    public int GetSideLenght()
    {
        Console.Write("Введите длину стороны: ");
        int lenght = int.Parse(Console.ReadLine());

        if(lenght <= 0)
        {
            Console.WriteLine("Только положительные числа отличные от нуля,попробуйте снова!");
            Environment.Exit(0);
        }

        return lenght;
    }
}
