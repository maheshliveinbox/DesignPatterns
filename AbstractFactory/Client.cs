using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    // The client code works with factories and products only through abstract
    // types: AbstractFactory and AbstractProduct. This lets you pass any
    // factory or product subclass to the client code without breaking it.
    public class Client
    {
        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();

            Result = $"({productB.UsufulFunctionB()}) - ({productB.AnotherUsefulFunctionB(productA)})";
        }

        public string Result { get; private set; }
    }
}
