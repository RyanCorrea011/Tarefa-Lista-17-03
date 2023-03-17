using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite.Heranca
{
    public class Carro : Veiculo
    {
        public bool cintoSeguranca;
        public bool arCondicionado;
        public string marcaRadio;
        public string fabricante;

        public  string ExibirMarca()
        {
            return "O fabricante deste veiculo é: "+fabricante;
        }
    }
}
