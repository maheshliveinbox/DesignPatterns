﻿namespace AbstractFactory
{
    // Concrete Products are created by corresponding Concrete Factories.
    public class ConcreteProductB1 : IAbstractProductB
    {
        public string UsufulFunctionB()
        {
            return "The result of the product B1.";
        }

        // The variant, Product B1, is only able to work correctly with the
        // variant, Product A1. Nevertheless, it accepts any instance of
        // AbstractProductA as an argument.
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"the Result of th eBi collaborating with the ({result})";
        }
    }
}
