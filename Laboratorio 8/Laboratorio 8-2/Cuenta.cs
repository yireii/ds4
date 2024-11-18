public class Cuenta
{
    private string idCuenta;

    public Cuenta(string prmtIdCuenta)
    {
        this.idCuenta = prmtIdCuenta;
        System.Console.WriteLine(
            "Constructor Clase Base para cuenta {0}", prmtIdCuenta);
    }
    
    public virtual void CalcularInteres()
    {
        System.Console.WriteLine(
            "Cuenta.CalcularInteres() efectuado para la cuenta {0}",
            this.idCuenta);
    }

    public string getIdCuenta()
    {
        return this.idCuenta;
    }
}
