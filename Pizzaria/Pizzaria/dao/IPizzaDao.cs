using Pizzaria.modelo;
using System;
namespace Pizzaria.dao
{
        public interface IPizzaDao
    {
        void Adicionar(Pizza pizza);
        void Atualizar(Pizza pizza);
        Pizza BuscarPorId(long id);
        System.Collections.Generic.List<Pizza> BuscarPorSabor(string sabor);
        System.Collections.Generic.List<Pizza> BuscarTodas();
        void Remover(Pizza pizza);
    }
}
