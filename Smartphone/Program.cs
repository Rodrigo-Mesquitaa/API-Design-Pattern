using Smartphone.ConcretesFactoy;
using Smartphone.Interfaces;
using System;

namespace Smartphone
{
  internal class Program
    {
        private static void Main(string[] args)
        {

            ITelemovel nokiaTelemovel = new Motorola();
            TelemovelClient nokiaClient = new TelemovelClient(nokiaTelemovel);

            Console.WriteLine("*************** MOTOROLA **************");
            Console.WriteLine(nokiaClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(nokiaClient.BuscarNormalPhoneModeloDetalhes());

            ITelemovel samsungTelemovel = new Samsung();
            TelemovelClient samsungClient = new TelemovelClient(samsungTelemovel);

            Console.WriteLine("*************** SAMSUNG ***************");
            Console.WriteLine(samsungClient.BuscarSmartPhoneModeloDetalhes());
            Console.WriteLine(samsungClient.BuscarNormalPhoneModeloDetalhes());

            Console.ReadKey();
        }
    }
}

