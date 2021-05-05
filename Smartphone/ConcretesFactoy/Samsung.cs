
using Smartphone.Interfaces;

namespace Smartphone.ConcretesFactoy
{
    /// <summary>
    /// ConcreteFactory2
    /// </summary>
    public class Samsung : ITelemovel
    {
        public INormalPhone BuscarNormalPhone()
        {
            return new SamsungG15();
        }

        public ISmartPhone BuscarSmartPhone()
        {
            return new SamsungGalaxyS22();
        }
    }
}
