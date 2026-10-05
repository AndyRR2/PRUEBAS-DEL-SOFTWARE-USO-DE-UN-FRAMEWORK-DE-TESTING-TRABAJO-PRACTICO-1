Producto producto1 = new Producto("fideo", 1000, "alimentos");
Producto producto2 = new Producto("jugo", 2000, "bebidas");
Producto producto3 = new Producto("escoba", 2000, "limpieza");

Tienda tienda = new Tienda();
tienda.AgregarProducto(producto1);
tienda.AgregarProducto(producto2);
tienda.AgregarProducto(producto3);

tienda.MostrarInventario();

tienda.BuscarProducto("jugo");
tienda.EliminarProducto("escoba");

tienda.MostrarInventario();