using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericFactory.Models
{
    public interface ICar
    {
        int HorsePower { get; set; }
        string Model { get; set; }
        string Registraion { get; set; }
    }
}
