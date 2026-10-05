using System.Collections.Generic;

public class TiendaFixture
{
    public Tienda Tienda { get; private set; }

    public TiendaFixture()
    {
        Tienda = new Tienda();
        Tienda.AgregarProducto(new Producto("Pan", 50, "Alimentos"));
        Tienda.AgregarProducto(new Producto("Leche", 100, "Lácteos"));
        Tienda.AgregarProducto(new Producto("Jugo", 120, "Bebidas"));
    }
}

