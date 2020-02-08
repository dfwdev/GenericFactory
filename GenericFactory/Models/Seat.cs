using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericFactory.Models
{
    public class Seat : ICar
    {
        public string Registraion { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

        public string SeatOnly()
        {
            return "I'm a Seat!";
        }
    }
}
