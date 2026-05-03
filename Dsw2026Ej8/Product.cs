namespace Dsw2026Ej8
{
    public class Product
    {
        private string _description = "";

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        public void ModifDescripcion(string nuevaDescription)
        {
            Description = nuevaDescription;
        }
    }
}
