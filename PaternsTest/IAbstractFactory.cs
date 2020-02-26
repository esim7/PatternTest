namespace PaternsTest
{
    public interface IAbstractFactory 
    {
        public IAbstractProductA CreateProductA();
        public IAbstractProductB CreateProductB();
    }
}