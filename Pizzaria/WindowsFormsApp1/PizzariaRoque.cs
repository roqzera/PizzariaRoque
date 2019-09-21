using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria.dao;
using Pizzaria.servico;
using WindowsFormsApp1;

namespace Pizzaria
{
    public partial class PizzariaRoque : Form
{
        PizzaDaoMySQL pizzaDao = new PizzaDaoMySQL();
        
        

    public PizzariaRoque()
    {
        InitializeComponent();
    }
        private void Limpar()
        {
            tbxSabor1.Clear();
            tbxValor.Clear();
        }
    private void BtnAdicionar_Click(object sender, EventArgs e)
    {
            modelo.Pizza pizza = new modelo.Pizza();
            servico.PizzaServico pizzaService = new servico.PizzaServico(pizzaDao);
            pizza.Sabor = Convert.ToString(tbxSabor1.Text);
            pizza.Valor = Convert.ToDecimal(tbxValor.Text);
            pizzaService.Adicionar(pizza);
            Limpar();
            dgwPizzas.DataSource = pizzaService.BuscarTodas();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            string idPizza;
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            servico.PizzaServico pizzaService = new servico.PizzaServico(pizzaDao);
            dgwPizzas.DataSource = pizzaService.BuscarTodas();

        }

        private void BtnFuncionarios_Click(object sender, EventArgs e)
        {
            FormFuncionario formFuncionario = new FormFuncionario();
            formFuncionario.Show();
        }
    }
}
