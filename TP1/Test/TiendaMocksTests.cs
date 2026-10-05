using Xunit;
using Moq;

public class TiendaMocksTests
{
    [Fact]
    public void AplicarDescuento_LlamaActualizarPrecioConValorCorrecto()
    {
        var mockProducto = new Mock<IProducto>();
        mockProducto.SetupGet(p => p.Precio).Returns(200);

        var tienda = new Tienda();
        tienda.AplicarDescuento(mockProducto.Object, 25);

        mockProducto.Verify(p => p.ActualizarPrecio(150), Times.Once);
    }
}

