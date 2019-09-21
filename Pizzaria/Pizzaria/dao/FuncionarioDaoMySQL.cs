using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Pizzaria.modelo;

namespace Pizzaria.dao
{
    public class FuncionarioDaoMySQL : IFuncionario
    {

        MySqlCommand cmd = new MySqlCommand();
        ConexaoDao conexao = new ConexaoDao();
        MySqlConnection mySqlConnection;
        ConexaoDao con = new ConexaoDao();

        public void Adicionar(Funcionario funcionario)
        {
            //Comando Sql: insert, update, delete

            cmd.CommandText = "INSERT INTO funcionario (nome, cpf, email, senha) " +
                "VALUES (@Nome, @Cpf, @Email, @Senha)";

            //Parametros
            cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
            cmd.Parameters.AddWithValue("@Cpf", funcionario.Cpf);
            cmd.Parameters.AddWithValue("@Email", funcionario.Email);
            cmd.Parameters.AddWithValue("@Senha", funcionario.Senha);


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
                MessageBox.Show(Convert.ToString(ex));
                throw ex;
            }

            finally
            {
                conexao.Desconectar();
            }
        }
        public void Atualizar(Funcionario funcionario)
        {

        }
        public Funcionario BuscarPorId(long id)
        {
            Funcionario funcionario = new Funcionario();
            return funcionario;
        }
        public List<Funcionario> BuscarPorNome(string nome)
        {
            List<Funcionario> listFuncionario = new List<Funcionario>();
            return listFuncionario;
        }
        public List<Funcionario> BuscarTodas()
        {
            List<modelo.Funcionario> funcionario = new List<modelo.Funcionario>();
            string sql1 = "SELECT id_funcionario, nome, cpf, email FROM funcionario;";
            cmd = new MySqlCommand(sql1.ToString(), mySqlConnection);
            //Conectar com o banco
            cmd.Connection = conexao.Conectar();
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    modelo.Funcionario f = new modelo.Funcionario()
                    {
                        IdFuncionario = Convert.ToInt64(rdr["id_funcionario"]),
                        Nome = Convert.ToString(rdr["nome"]),
                        Cpf = Convert.ToString(rdr["cpf"]),
                        Email = Convert.ToString(rdr["email"]),
                    };

                    funcionario.Add(f);
                }
            }
            cmd.Connection.Close();
            return funcionario;
        }
        public void Remover(Funcionario funcionario)
        {

        }
    }
}