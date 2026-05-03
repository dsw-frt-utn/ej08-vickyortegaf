namespace Dsw2026Ej8
{
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Monto * 0.90m;
        }
    }
}
