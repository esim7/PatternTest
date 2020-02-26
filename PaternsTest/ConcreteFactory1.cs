namespace PaternsTest
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            //throw new System.NotImplementedException();
            return new ProductA();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}