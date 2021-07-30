using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Estoque.Model
{
    class VendasDAO
    {
        public string msg { get; private set; }
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        public string Vender(Vendas vendas)
        {
            cmd.CommandText = "INSERT INTO Vendas VALUES (@funcID, @estoqueID, @quant, @dia)";
            cmd.Parameters.AddWithValue("funcID", vendas.funcionarioID);
            cmd.Parameters.AddWithValue("estoqueID", vendas.estoqueID);
            cmd.Parameters.AddWithValue("quant", vendas.quantVendida);
            cmd.Parameters.AddWithValue("dia", vendas.dia);
            try
            {
                cmd.Connection = con.Connect();
                cmd.ExecuteNonQuery();
                msg = "0";
            }
            catch (SqlException ex)
            {
                msg = ex.Message;
            }
            con.Disconnect();
            return msg;
        }
        public SqlDataReader PesquisarVendas(string diaInicial, string diaFinal, string funcionario, string order, string sentido)
        {

            cmd.CommandText = "EXECUTE VendasRealizadas '" + order + "', '" + funcionario + "', '" + diaInicial + "', '" + diaFinal + "', '" + sentido+"'";
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
        public SqlDataReader RetornarValorDia()
        {
            cmd.CommandText = "SELECT * FROM vwValorDia ORDER BY dia DESC";
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
        public SqlDataReader RetornarVendasDia(string dia)
        {
            cmd.CommandText = "EXECUTE VendasDia '"+dia+"'";
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
    }
}
