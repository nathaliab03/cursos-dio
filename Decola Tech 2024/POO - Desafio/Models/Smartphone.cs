using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO___Desafio.Models
{
    public abstract class Smartphone
    {
        public string Number { get; set; }  
        private string Model { get; set; }  
        private string IMEI { get; set; }  
        private int SmartphoneMemory { get; set; }  

        public Smartphone(string number, string model, string imei, int memory)
        {
            Number = number;
            Model = model;
            IMEI = imei;
            SmartphoneMemory = memory;
        }
        public void Call()
        {
            Console.WriteLine("Digite o número para ligar: ");
            string number = Console.ReadLine();
            Console.WriteLine($"Ligando para o número: {number}");
        }
        public void RecievingCall()
        {
            Console.WriteLine("Recebendo Ligação");
        }
        public abstract void AppInstall(string nomeApp);
    }
}