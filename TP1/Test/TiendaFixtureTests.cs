using Xunit;

public class TiendaFixtureTests : IClassFixture<TiendaFixture>
{
    private readonly TiendaFixture _fixture;

    public TiendaFixtureTests(TiendaFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void BuscarProducto_Existente_UsandoFixture()
    {
        var producto = _fixture.Tienda.BuscarProducto("Leche");
        Assert.NotNull(producto);
        Assert.Equal("Leche", producto.Nombre);
    }

    [Fact]
    public void AgregarProducto_UsandoFixture()
    {
        var nuevoProducto = new Producto("Queso", 80, "Lácteos");
        _fixture.Tienda.AgregarProducto(nuevoProducto);

        var buscado = _fixture.Tienda.BuscarProducto("Queso");
        Assert.NotNull(buscado);
        Assert.Equal(80, buscado.Precio);
    }
}

