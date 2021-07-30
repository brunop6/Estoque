using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Estoque.Model
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source="+Environment.MachineName.ToString()+"\\SQLEXPRESS01; Initial Catalog=Estoque; Integrated Security=True";
        }
        //Conectar ao banco de dados
        public SqlConnection Connect()
        {
            //Verifica se o estado da conexão é igual a fechado, então posso abrir.
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Desconectar do banco de dados
        public void Disconnect()
        {
            //Verifica se o estado da conexão é aberto, então fecho.
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
