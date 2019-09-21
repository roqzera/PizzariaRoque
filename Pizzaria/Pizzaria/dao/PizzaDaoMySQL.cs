using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Pizzaria.dao
{
    public class PizzaDaoMySQL : IPizzaDao
    {
        MySqlCommand cmd = new MySqlCommand();
        ConexaoDao conexao = new ConexaoDao();
        MySqlConnection mySqlConnection;
        ConexaoDao con = new ConexaoDao();

        public void Adicionar(modelo.Pizza pizza)
        {
            //Comando Sql: insert, update, delete

            cmd.CommandText = "INSERT INTO pizza (sabor, valor) " +
                "VALUES (@Sabor, @Valor)";

            //Parametros
            cmd.Parameters.AddWithValue("@Sabor", pizza.Sabor);
            cmd.Parameters.AddWithValue("@Valor", pizza.Valor);

            try
            {
                //Conectar com o banco
                cmd.Connection = conexao.Conectar();
                //Executar Comando
                cmd.ExecuteNonQuery();
                //Desconectar
                conexao.Desconectar();
                //Mostrar mensagem de sucesso/erro
                MessageBox.Show("Cadastro realizado com sucesso!");
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
                throw ex;
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public void Atualizar(modelo.Pizza pizza)
        {
            throw new NotImplementedException();
        }

        public modelo.Pizza BuscarPorId(long id)
        {
            throw new NotImplementedException();
        }

        public List<modelo.Pizza> BuscarPorSabor(string sabor)
        {
            throw new NotImplementedException();
        }

        public List<modelo.Pizza> BuscarTodas()
        {
            List<modelo.Pizza> pizza = new List<modelo.Pizza>();
            string sql1 = "SELECT * FROM pizza;";
            cmd = new MySqlCommand(sql1.ToString(), mySqlConnection);
            //Conectar com o banco
            cmd.Connection = conexao.Conectar();
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    modelo.Pizza p = new modelo.Pizza()
                    {
                        IdPizza = Convert.ToInt64(rdr["id_pizza"]),
                        Sabor = Convert.ToString(rdr["sabor"]),
                        Valor = Convert.ToDecimal(rdr["valor"]),
                        
                    };

                    pizza.Add(p);
                }
            }
            cmd.Connection.Close();
            return pizza;
        }

        public void Remover(modelo.Pizza pizza)
        {
            throw new NotImplementedException();
        }
    }
}
