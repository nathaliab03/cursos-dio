using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO___Desafio.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) : base(number, model, imei, memory){}

        public override void AppInstall(string nameApp)
        {
            Console.WriteLine($"Aplicativo {nameApp} instalado com sucesso no Nokia.");
        }
    }
}