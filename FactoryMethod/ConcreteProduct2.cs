using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    // Concrete Products provide various implementations of the Product
    // interface.
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
