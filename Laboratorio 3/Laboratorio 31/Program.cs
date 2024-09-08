
using Geometria;


    internal class CalculosMatematicos
    {
        private static void Main(string[] args)
        {
            int a, b;

            Console.Write("Introduce el primer número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());
            Calcular(a, b);

            double r;
            const double pi = 3.1419;

            Console.Write("Introduce el radio del círculo: ");
            r = Convert.ToDouble(Console.ReadLine());
            calculoArea.calculoArea(r, pi);
        }

        private static void Calcular(int a, int b)
        {
            int resultado = (a + b) * (a - b);
            Console.WriteLine("El resultado de la operación ({0} + {1}) * ({0} - {1}) es: {2}", a, b, resultado);
        }
    }

