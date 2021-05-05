using Smartphone.Interfaces;

namespace Smartphone.ConcretesFactoy
{
    /// <summary>
    /// ConcreteFactory1
    /// </summary>
    public class Motorola : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new MotorolaEdge();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new MotorolaAlien();
        }
    }
}
