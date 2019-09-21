using Pizzaria.dao;
using Pizzaria.servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormFuncionario : Form
    {
        FuncionarioDaoMySQL funcionarioDao = new FuncionarioDaoMySQL();

        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            Pizzaria.modelo.Funcionario funcionario = new Pizzaria.modelo.Funcionario();
            FuncionarioServico funcionarioServico = new FuncionarioServico(funcionarioDao);

            funcionario.Nome = Convert.ToString(tbxNome.Text);
            funcionario.Cpf = Convert.ToString(tbxCpf.Text);
            funcionario.Email = Convert.ToString(tbxEmail.Text);
            funcionario.Senha = Convert.ToString(tbxSenha.Text);
            MessageBox.Show(funcionario.Nome);

            funcionarioServico.Adicionar(funcionario);
            Limpar();
            dgwFuncionarios.DataSource = funcionarioServico.BuscarTodas();

        }

        private void Limpar()
        {
            tbxNome.Clear();
            tbxCpf.Clear();
            tbxEmail.Clear();
            tbxSenha.Clear();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FuncionarioServico funcionarioServico = new FuncionarioServico(funcionarioDao);

            dgwFuncionarios.DataSource = funcionarioServico.BuscarTodas();
        }
    }
}
