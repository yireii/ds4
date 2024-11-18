class Aleatorios
{
    private Random random = new Random();

    public int GenerarNumero(int min, int max)
    {
        return random.Next(min, max);
    }

    public int[] GenerarArreglo(int min, int max, int tamaño)
    {
        int[] arreglo = new int[tamaño];
        for (int i = 0; i < tamaño; i++)
        {
            arreglo[i] = random.Next(min, max);
        }
        return arreglo;
    }
}