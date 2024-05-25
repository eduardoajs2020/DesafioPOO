using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.interfaces
{
    public interface ISmartphone
    {
        string Numero { get; set; }
        void Ligar();
        void ReceberLigacao();
        void InstalarAplicativo(string nomeApp);
    }
}