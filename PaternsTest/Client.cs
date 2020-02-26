using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsTest
{
    public class Client
    {

        public void Main()
        {
            Console.WriteLine("Client: Testing client code with the first factory type");
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the second factory type");
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            IAbstractProductA productA = factory.CreateProductA();
            IAbstractProductB productB = factory.CreateProductB();

            //Console.WriteLine(productB.UsefulFunctionB());
            //Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        }
    }

}
