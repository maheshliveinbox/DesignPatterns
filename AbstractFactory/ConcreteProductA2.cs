using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}
