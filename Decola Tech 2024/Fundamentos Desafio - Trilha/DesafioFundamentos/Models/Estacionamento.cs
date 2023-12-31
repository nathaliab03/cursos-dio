using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamentoDesafio.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            if(placa != "")
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo com placa {placa} foi adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("Campo não pode ficar em branco");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora*horas; 

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for (int i = 0; i < veiculos.Count; i++)
                {
                    int count = i +1;
                    string text = $"Veículo {count}- {veiculos[i]} ";
                    Console.WriteLine(text);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}