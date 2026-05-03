namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            copia++;

            Product productoCopia = product;
            productoCopia.ModifDescripcion("Descripción del producto modificada");

            return $"{originalValue} - {copia} - {product.Description}";
        }
    }
}
