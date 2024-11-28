using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlCommand Comando;
        private SqlConnection Conexion;
        private SqlDataReader Lector;
        public SqlDataReader lector
        {
            get { return Lector; }
        }

        public AccesoDatos()
        {
            Conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");
            Comando = new SqlCommand();
        }

        public void SetQuery(string Consulta)
        {
            try
            {
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = Consulta; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExecuteRead()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Lector = Comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExecuteAction()
        {
            Comando.Connection = Conexion;
            try
            {
                Conexion.Open();
                Comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            if (Lector != null)
                Lector.Close();
            Conexion.Close();
        }

        public void SetParameters(string Nombre, object Valor)
        {
            Comando.Parameters.AddWithValue(Nombre, Valor);
        }
    }
}
