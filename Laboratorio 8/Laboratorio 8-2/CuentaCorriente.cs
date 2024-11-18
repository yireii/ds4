public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }

    public override void CalcularInteres()
    {
        System.Console.WriteLine(
            "CuentaCorriente.CalcularInteres() efectuado para " +
            "la cuenta {0}", getIdCuenta());
    }
}
