
internal class CalculosMatematicos
{
    private static void Main(string[] args)
    {
        int a, b;

        Console.Write("Introduce el primer numero: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo numero: ");
        b = Convert.ToInt32(Console.ReadLine());
        Calcular(a, b);
    }

        private static void Calcular(int a, int b)
    {
        int resultado = (a + b) * (a - b);
        Console.WriteLine("El resultado de la operación ({0} + {1}) * ({0} - {1}) es: {2}", a, b, resultado);
    }
}
