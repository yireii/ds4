internal class Program
{
    private static void Main(string[] args)
    {
        // Usar el método CalcularAreaCirculo desde CalculosMatematicos
        Console.Write("Introduce el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        double area = CalculosMatematicos.CalcularAreaCirculo(radio);

        Console.WriteLine("El área del círculo con radio {0} es: {1}", radio, area);
    }
}