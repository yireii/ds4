interface iTemplate
{
    public void ponerVariables(string nombre, string var);
    public void verHtml(string template);
}

class Template : iTemplate
{
    public void ponerVariables(string nombre, string var)
    {
        Console.WriteLine("Metodo poner variable {nombre} : {var}");
    }

    public void verHtml(string template)
    {
        Console.WriteLine(template);
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Template temp1 = new Template();
        temp1.ponerVariables("var1", "Valor 1");
        temp1.ponerVariables("var2", "Valor 2");
        temp1.ponerVariables("var3", "Valor 3");
        temp1.verHtml("<br>Texto de Prueba</br>");
    }
}