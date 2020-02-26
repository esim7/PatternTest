namespace PaternsTest
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            throw new System.NotImplementedException();
        }

        public IAbstractProductB CreateProductB()
        {
            throw new System.NotImplementedException();
        }
    }
}