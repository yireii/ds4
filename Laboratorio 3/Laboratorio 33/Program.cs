internal class Program
{
    private static void Main(string[] args)
    {
        int a,b;

        Console.Write("Introduce el largo del rectangulo: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el ancho del rectangulo: ");
        b = Convert.ToInt32(Console.ReadLine());

        calculoPerim(a, b);
    }
    private static void calculoPerim(int a, int b)
    {
        double resp = a + b + a + b;
        Console.WriteLine("El perimetro del recangulo es {0}", resp);
    }
}