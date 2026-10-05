using Xunit;

public class TiendaExcepcionesTests
{
    [Fact]
    public void BuscarProducto_NoExistente_LanzaExcepcion()
    {
        var tienda = new Tienda();
        Assert.Throws<KeyNotFoundException>(() => tienda.BuscarProducto("Queso"));
    }

    [Fact]
    public void EliminarProducto_NoExistente_LanzaExcepcion()
    {
        var tienda = new Tienda();
        Assert.Throws<KeyNotFoundException>(() => tienda.EliminarProducto("Agua"));
    }
}

