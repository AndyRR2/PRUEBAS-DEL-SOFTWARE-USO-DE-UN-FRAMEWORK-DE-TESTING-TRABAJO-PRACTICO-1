public class Producto : IProducto
{
    string nombre = "";
    decimal precio;
    string? categoria;

    public string Nombre { get => nombre; set => nombre = value; }
    public decimal Precio { get => precio; set => precio = value; }
    public string? Categoria { get => categoria; set => categoria = value; }

    public Producto(string nombre, decimal precio, string categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Categoria = categoria;
    }

    public void ActualizarPrecio(decimal nuevoPrecio)
    {
        if (nuevoPrecio < 0)
            throw new ArgumentException("El precio no puede ser negativo.");

        Precio = nuevoPrecio;
    }
}

