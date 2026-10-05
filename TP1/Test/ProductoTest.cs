using Xunit;

public class ProductoTests
{
    [Fact]
    public void Producto_Creacion_Correcta()
    {
        var producto = new Producto("Leche", 150, "Lácteos");
        Assert.Equal("Leche", producto.Nombre);
        Assert.Equal(150, producto.Precio);
        Assert.Equal("Lácteos", producto.Categoria);
    }
}

