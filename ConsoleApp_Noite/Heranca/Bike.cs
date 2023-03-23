using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Noite.Heranca
{
    public class Bike : Veiculo
    {
        public int velocidadeMaximaEmKmH;
        public string Nome;
        public string ExibirMarca(string Nome)
        {
            return "O fabricante deste veiculo é: " + Nome;
        }
    }
    
}
