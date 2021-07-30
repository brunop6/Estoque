using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Estoque.Model
{
    class FuncionarioDAO
    {
        public string msg { get; private set; }
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public string CadastrarFunc(Funcionario func)
        {
            cmd.CommandText = "INSERT INTO Funcionario VALUES(@nome, @senha, @contato, @contato2)";
            cmd.Parameters.AddWithValue("nome", func.nome);
            cmd.Parameters.AddWithValue("senha", func.senha);
            cmd.Parameters.AddWithValue("contato", func.contato);
            cmd.Parameters.AddWithValue("contato2", func.contato2);
            try
            {
                cmd.Connection = con.Connect();
                cmd.ExecuteNonQuery();
                msg = "Cadastro realizado!";
            }
            catch(SqlException ex)
            {
                msg = ex.Message;
            }
            con.Disconnect();
            return msg;
        }
        public SqlDataReader RetornarFuncionarios()
        {
            cmd.CommandText = "SELECT * FROM Funcionario";
            try
            {
                cmd.Connection = con.Connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Disconnect();
            return null;
        }
        public SqlDataReader ConsultarFunc(string nome)
        {
            cmd.CommandText = "SELECT * FROM Funcionario WHERE nome like '%" + nome + "%'";
            try
            {
                cmd.Connection = con.Connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Disconnect();
            return null;
        }
        public SqlDataReader AutenticarFunc(int id, string senha)
        {
            cmd.CommandText = "SELECT * FROM Funcionario WHERE id = " + id + " AND senha = '" + senha + "'";
            try
            {
                cmd.Connection = con.Connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Disconnect();
            return null;
        }
        public string EditarFuncionario(int id, string nome, string senha, string contato, string contato2)
        {
            cmd.CommandText = "UPDATE Funcionario SET nome = '"+nome+"', senha = '"+senha+"', contato1 = '"+contato+"', contato2 = '"+contato2+"' WHERE id = "+id;
            try
            {
                cmd.Connection = con.Connect();
                cmd.ExecuteNonQuery();
                msg = "Edição realizada!";
            }
            catch(SqlException ex)
            {
                msg = ex.Message;
            }
            con.Disconnect();
            return msg;
        }
    }
}
