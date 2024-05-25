using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.interfaces;

namespace DesafioPOO.Models
{
    public abstract class Smartphone : ISmartphone
    {
       

        public string Numero { get; set; }
        public string Modelo { get; set; } // Propriedade para armazenar o modelo do smartphone
        public string IMEI { get; set; } // Propriedade para armazenar o número do imei do smartphone
        public int Memoria { get; set; } // Propriedade para armazenar a capacidade de armazenamento do smartphone
        public bool BateriaCarregada { get; set; } // Propriedade para indicar se a bateria está carregada

        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Memoria = memoria;
            IMEI = imei;
            BateriaCarregada = true; 
        }

       

        public void Ligar()
        {
            if (BateriaCarregada)
            {
                Console.WriteLine($"Efetuando chamada do {Modelo}...");
            }
            else
            {
                Console.WriteLine("Bateria fraca! Carregue o smartphone antes de ligar.");
            }
        }

        public void ReceberLigacao()
        {
            if (BateriaCarregada)
            {
                Console.WriteLine("Chamada recebida!");
            }
            else
            {
                Console.WriteLine("Bateria fraca! Carregue o smartphone antes de atender chamadas.");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public void CarregarBateria()
        {
            BateriaCarregada = true;
            Console.WriteLine("Bateria carregada!");
        }
    }
}