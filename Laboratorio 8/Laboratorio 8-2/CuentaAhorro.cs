public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }

    public override void CalcularInteres()
    {
        System.Console.WriteLine(
            "CuentaAhorro.CalcularInteres() efectuado para " +
            "la cuenta {0}", getIdCuenta() );
    }
}
