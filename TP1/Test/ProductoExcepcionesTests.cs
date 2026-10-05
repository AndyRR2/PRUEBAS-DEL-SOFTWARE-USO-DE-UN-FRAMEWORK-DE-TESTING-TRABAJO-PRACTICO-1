using Xunit;

public class ProductoExcepcionesTests
{
    [Fact]
    public void ActualizarPrecio_Negativo_LanzaExcepcion()
    {
        var producto = new Producto("Leche", 100, "Lácteos");
        Assert.Throws<ArgumentException>(() => producto.ActualizarPrecio(-50));
    }
}

