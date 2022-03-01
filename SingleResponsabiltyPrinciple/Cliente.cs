using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsabiltyPrinciple;

public class Cliente
{
    public string Apellido { get; set; }
    public string Nombre { get; set; }

    public Cliente(string apellido, string nombre)
    {
        Apellido = apellido;
        Nombre = nombre;

    }
}

