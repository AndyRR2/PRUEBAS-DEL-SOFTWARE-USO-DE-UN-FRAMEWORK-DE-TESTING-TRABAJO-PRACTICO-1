using Xunit;

public class IntegracionTests : IClassFixture<TiendaFixture>
{
    private readonly TiendaFixture _fixture;

    public IntegracionTests(TiendaFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void CalcularTotalCarrito_AfterDescuentos()
    {
        var pan = _fixture.Tienda.BuscarProducto("Pan");
        var leche = _fixture.Tienda.BuscarProducto("Leche");
        _fixture.Tienda.AplicarDescuento(pan, 10);
        _fixture.Tienda.AplicarDescuento(leche, 20);

        var carrito = new List<string> { "Pan", "Leche" };
        decimal total = _fixture.Tienda.CalcularTotalCarrito(carrito);

        Assert.Equal(125, total);
    }
}

