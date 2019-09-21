using Pizzaria.dao;
using Pizzaria.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.servico
{
    public class FuncionarioServico
    {
        private IFuncionario funcionarioDao;

        public FuncionarioServico(IFuncionario funcionarioDao)
        {
            this.funcionarioDao = funcionarioDao;
        }
        public void Adicionar(Funcionario funcionario)
        {
            funcionarioDao.Adicionar(funcionario);
        }
        public void Remover(Funcionario funcionario)
        {
            funcionarioDao.Remover(funcionario);
        }
        public void Atualizar(Funcionario funcionario)
        {
            funcionarioDao.Atualizar(funcionario);
        }
        public List<Funcionario> BuscarTodas()
        {
            return funcionarioDao.BuscarTodas();
        }
        public List<Funcionario> BuscarPorNome(string nome)
        {
            return funcionarioDao.BuscarPorNome(nome);
        }
        public Funcionario BuscarPorId(long idFuncionario)
        {
            return funcionarioDao.BuscarPorId(idFuncionario);
        }
    }
}
