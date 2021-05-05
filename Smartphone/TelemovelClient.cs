using Smartphone.Interfaces;

namespace Smartphone
{
    /// <summary>
    /// Client
    /// </summary>
    public class TelemovelClient
    {
        ISmartPhone smartPhone;
        INormalPhone normalPhone;

        public TelemovelClient(ITelemovel telemovelfactory)
        {
            smartPhone = telemovelfactory.BuscarSmartPhone();
            normalPhone = telemovelfactory.BuscarNormalPhone();
        }

        public string BuscarSmartPhoneModeloDetalhes()
        {
            return smartPhone.BuscarDetalhesModelo();
        }

        public string BuscarNormalPhoneModeloDetalhes()
        {
            return normalPhone.BuscarDetalhesModelo();
        }



    }
}
