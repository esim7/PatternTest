namespace PaternsTest
{
    public class ConcreteFactory1 : IAbstractFactory
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