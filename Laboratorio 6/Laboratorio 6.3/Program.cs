﻿using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Algo salio mal, valide el indice del arreglo");

        }
        finally
        {
            Console.WriteLine("Continuacion de la aplicacion, luego del bloque try/catch");
        }
    }
}