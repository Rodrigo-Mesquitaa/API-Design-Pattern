using Smartphone.Interfaces;

namespace Smartphone
{
    /// <summary>
    /// ProdutoB1
    /// </summary>
    public class MotorolaEdge : INormalPhone
    {
        public string BuscarDetalhesModelo()
        {
            return "Modelo: Motorola Edge\nRAM: 12GB\nCamera 108MP\nMemoria interna: 512\nTV Digital: Sim\nNFC: Sim\nRadio: Sim\nCarregador: Mega Hyper carga completa em 15 minutos\nFone: Sem fio Bluetooth\n";
        }
    }
}
