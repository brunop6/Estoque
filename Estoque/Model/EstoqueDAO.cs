using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Estoque.Model
{
    class EstoqueDAO
    {
        public string mensagem { get; private set; }
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public SqlDataReader RetornarEstoque()
        {
            cmd.CommandText = "SELECT * FROM Estoque";

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
        public string AddProduto(Estoque estoque)
        {
            cmd.CommandText = "INSERT INTO Estoque VALUES(@produto, @tamanho, @quantidade, @valor, @quantMin)";

            cmd.Parameters.AddWithValue("produto", estoque.produto);
            cmd.Parameters.AddWithValue("tamanho", estoque.tamanho);
            cmd.Parameters.AddWithValue("quantidade", estoque.quantidade);
            cmd.Parameters.AddWithValue("valor", estoque.valor);
            cmd.Parameters.AddWithValue("quantMin", estoque.quantMin);
            try
            {
                cmd.Connection = con.Connect();
                cmd.ExecuteNonQuery();
                mensagem = "Produto inserido com sucesso!";
            }
            catch(SqlException ex)
            {
                mensagem = ex.Message;
            }
            con.Disconnect();
            return mensagem;
        }
        public string EditarEstoque(Estoque estoque)
        {
            cmd.CommandText = "UPDATE Estoque SET produto = @prod, tamanho = @tam, quantidade = @quant, valor = @val, quantMin = @quantMin WHERE id = @i";
            cmd.Parameters.AddWithValue("i", estoque.id);
            cmd.Parameters.AddWithValue("prod", estoque.produto);
            cmd.Parameters.AddWithValue("tam", estoque.tamanho);
            cmd.Parameters.AddWithValue("quant", estoque.quantidade);
            cmd.Parameters.AddWithValue("val", estoque.valor);
            cmd.Parameters.AddWithValue("quantMin", estoque.quantMin);
            try
            {
                cmd.Connection = con.Connect();
                cmd.ExecuteNonQuery();
                mensagem = "Edição Salva!";
            }
            catch(SqlException ex)
            {
                mensagem = ex.Message;
            }
            con.Disconnect();
            return mensagem;
        }
        public SqlDataReader ConsultarId(int id)
        {
            cmd.CommandText = "SELECT * FROM Estoque WHERE id = "+id;
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
        public string Vender(int id, int quantVend, int quantEstoque)
        {
            int newQuant = quantEstoque - quantVend;
            cmd.CommandText = "UPDATE Estoque SET quantidade = " + newQuant + " WHERE id = " + id;

            try
            {
                cmd.Connection = con.Connect();
                cmd.ExecuteNonQuery();
                mensagem = "Operação Realizada!";
            }
            catch(SqlException ex)
            {
                mensagem = ex.Message;
            }
            con.Disconnect();
            return mensagem;
        }

        public SqlDataReader ConsultarProduto(string prodName)
        {
            cmd.CommandText = "SELECT * FROM Estoque WHERE produto LIKE '%"+prodName+"%'";
            try
            {
                cmd.Connection = con.Connect();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public string ExcluirItem(int id)
        {
            cmd.CommandText = "DELETE FROM Estoque WHERE id = "+ id;
            try
            {
                cmd.Connection = con.Connect();
                cmd.ExecuteNonQuery();
                mensagem = "Item excluído com sucesso!";
            }
            catch(SqlException ex)
            {
                mensagem = ex.Message;
            }
            return mensagem;
        }
        public SqlDataReader RetornarTotal()
        {
            cmd.CommandText = "SELECT SUM(valor*quantidade) FROM Estoque";
            try
            {
                cmd.Connection = con.Connect();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    return dr;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Disconnect();
            return null;
        }
        public SqlDataReader RetornarCountProdutos()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM Estoque";
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
        public SqlDataReader RetornarProdEmFalta()
        {
            cmd.CommandText = "SELECT id FROM Estoque WHERE quantidade <= quantMin";
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
        public SqlDataReader RetornarMaisVendidos(string diaInicial, string diaFinal)
        {
            cmd.CommandText = "MaisVendidos '" + diaInicial + "', '" + diaFinal + "'";
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
    }
}
