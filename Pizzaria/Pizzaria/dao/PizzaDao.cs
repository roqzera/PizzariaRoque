using Pizzaria.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.dao
{
    public class PizzaDao : IPizzaDao
    {
        private List<Pizza> listaDePizzas;
        private long proximoId;

        public PizzaDao()
        {
            listaDePizzas = new List<Pizza>();
            proximoId = 0;
        }

        public void Adicionar(Pizza pizza)
        {
            pizza.IdPizza = proximoId++;
            listaDePizzas.Add(pizza);
        }
        public void Remover(Pizza pizza)
        {
            listaDePizzas.Remove(pizza);
        }
        public void Atualizar(Pizza pizza) 
        {
            Pizza pcadastrada = BuscarPorId(pizza.IdPizza);
            pcadastrada.Sabor = pizza.Sabor;
            pcadastrada.Valor = pizza.Valor;
        }
        public List<Pizza> BuscarTodas()
        {
            return new List<Pizza>(listaDePizzas);
        }
        public List<Pizza> BuscarPorSabor(string sabor)
        {
            List<Pizza> listaPizzaDoSabor = new List<Pizza>();
            foreach (Pizza p in listaDePizzas)
            {
                if (p.Sabor.StartsWith(sabor))
                {
                    listaPizzaDoSabor.Add(p);
                }
            }
            return listaPizzaDoSabor;
        }
        public Pizza BuscarPorId(long id)
        {
            foreach (Pizza p in listaDePizzas)
            {
                if (p.IdPizza == id)
                    return p;
            }
            return null;
            
        }

    }
}
