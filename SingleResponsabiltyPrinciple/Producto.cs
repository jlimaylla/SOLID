using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabiltyPrinciple;

public class Producto
{
    public string Descripcion { get; set; }
    public double Precio { get; set; }

    public Producto(string descripcion, double precio)
    {
        Descripcion = descripcion;
        Precio = precio;
    }
}