namespace Dsw2026Ej8
{
    public class Sale
    {
        private decimal _monto;
        public decimal Monto
        {
            get
            {
                return _monto;
            }
            set
            {
                _monto = value;
            }
        }
        public virtual decimal CalculateTotal()
        {
            return Monto;
        }
    }
}
