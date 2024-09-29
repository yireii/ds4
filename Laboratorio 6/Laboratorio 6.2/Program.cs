﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el numero deseado");

        try
        {
            num = Int16.Parse(Console.ReadLine());

        }
        catch (FormatException ex)
        {
            Console.WriteLine("No se ha introducido");

            num = -1;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("El numero es muy grande");
            num = -1;

        }

        Console.WriteLine(num);
    }
}