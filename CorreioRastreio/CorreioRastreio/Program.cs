using CorreioRastreio.Dto;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;

namespace CorreioRastreio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rastrear Encomenda");

            var cliente = new Rastreio.ServiceClient(Rastreio.ServiceClient.EndpointConfiguration.ServicePort);

            string[] objetos = { "LB067614337HK" };
            var resultado = cliente.buscaEventosListaAsync(Constante.Usuario, Constante.Senha, Constante.Lista, Constante.Todos, "101", objetos).Result;

            Console.ReadLine();
        }
    }
}
