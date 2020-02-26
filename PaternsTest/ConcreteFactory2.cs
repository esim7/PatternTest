namespace PaternsTest
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}