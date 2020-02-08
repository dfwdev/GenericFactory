using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericFactory.Models
{
    public class CarFactory
    {
        public T CreateCar<T>(int horsePower, string model, string registration) where T : ICar, new()
        {
            return new T { HorsePower = horsePower, Model = model, Registraion = registration };
        }
    }
}
