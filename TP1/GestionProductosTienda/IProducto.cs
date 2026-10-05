public interface IProducto
{
    string Nombre { get; }
    decimal Precio { get; }
    void ActualizarPrecio(decimal nuevoPrecio);
}

