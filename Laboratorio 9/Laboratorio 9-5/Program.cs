class Program
{
    static void Main()
    {
        Aleatorios aleatorios = new Aleatorios();
        int min = 1;
        int max = 100;
        int tamaño = 10;

        List<int> numerosUnicos = new List<int>();
        while (numerosUnicos.Count < tamaño)
        {
            int numero = aleatorios.GenerarNumero(min, max);
            if (!numerosUnicos.Contains(numero))
            {
                numerosUnicos.Add(numero);
            }
        }

        Console.WriteLine("Arreglo de números no repetidos:");
        foreach (int numero in numerosUnicos)
        {
            Console.WriteLine(numero);
        }
    }
}