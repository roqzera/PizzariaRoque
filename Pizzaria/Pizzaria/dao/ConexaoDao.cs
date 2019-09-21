using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.dao
{
    public class ConexaoDao
    {
            MySqlConnection con = new MySqlConnection();

            public ConexaoDao()
            {
                con.ConnectionString = @"Server=127.0.0.1;Database=pizzaria;Userid=root;Password=password;";
            }

            public MySqlConnection Conectar()
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Open();
                }

                return con;
            }

            public void Desconectar()
            {
                if (con.State == System.Data.ConnectionState.Closed)
                {
                    con.Close();
                }
            }
        }

    }

