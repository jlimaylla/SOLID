using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabiltyPrinciple;

public class Item
{
    public Producto Producto { get; set; }
    public int Cantidad { get; set; }

    public Item(Producto producto, int cantidad)
    {
        Producto = producto;
        Cantidad = cantidad;
    }

    public double SubTotal()
    {
        return Producto.Precio * Cantidad;
    }
}