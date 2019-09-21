using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pizzaria.modelo;

namespace Pizzaria.dao
{
    public interface IFuncionario
    {
        void Adicionar(Funcionario funcionario);
        void Atualizar(Funcionario funcionario);
        Funcionario BuscarPorId(long id);
        System.Collections.Generic.List<Funcionario> BuscarPorNome(string nome);
        System.Collections.Generic.List<Funcionario> BuscarTodas();
        void Remover(Funcionario funcionario);
    }
}
