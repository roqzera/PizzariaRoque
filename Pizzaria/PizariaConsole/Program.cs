using Pizzaria.dao;
using Pizzaria.modelo;
using Pizzaria.servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizariaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string sabor;
            decimal valor;

            Console.Write("Entre com o sabor da pizza: ");
            sabor = Console.ReadLine();

            Console.Write("\n\nEntre com o valor da pizza: ");
            valor = Convert.ToDecimal(Console.ReadLine());

            Pizza p = new Pizza()
            {
                Sabor = sabor,
                Valor = valor
            };

            PizzaServico pizzaServico = new PizzaServico(new PizzaDaoMySQL());
            pizzaServico.Adicionar(p);

            foreach (Pizza pizza in pizzaServico.BuscarTodas())
            {
                Console.WriteLine("Pizza: {0} \tValor: R${1}",
                    pizza.Sabor, pizza.Valor);
            }
            Console.ReadKey();
        }
    }
}
