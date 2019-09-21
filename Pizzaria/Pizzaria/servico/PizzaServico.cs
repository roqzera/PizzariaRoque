using Pizzaria.dao;
using Pizzaria.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.servico
{
    public class PizzaServico
    {
        private IPizzaDao pizzaDao;

        public PizzaServico(IPizzaDao pizzaDao)
        {
            this.pizzaDao = pizzaDao;
        }
        public void Adicionar(Pizza pizza)
        {
            pizzaDao.Adicionar(pizza);
        }
        public void Remover(Pizza pizza)
        {
            pizzaDao.Remover(pizza);
        }
        public void Atualizar(Pizza pizza)
        {
            pizzaDao.Atualizar(pizza);
        }
        public List<Pizza> BuscarTodas()
        {
            return pizzaDao.BuscarTodas();
        }
        public List<Pizza> BuscarPorSabor(string sabor)
        {
            return pizzaDao.BuscarPorSabor(sabor);
        }
        public Pizza BuscarPorId(long idPizza)
        {
            return pizzaDao.BuscarPorId(idPizza);
        }
    }
}
