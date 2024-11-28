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
        private SqlConnection Conexion;
        private SqlCommand Comando;
        private SqlDataReader Lector;
        public SqlDataReader lector
        {
            get { return Lector; }
        }

        public AccesoDatos()
        {
            Conexion = new SqlConnection("server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true");
            Comando = new SqlCommand();
        }

        public void SetQuery(string Query)
        {
            Comando.CommandType = System.Data.CommandType.Text;
            Comando.CommandText = (Query);
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

        public void CloseConexion()
        {
            if (Lector != null)
                Lector.Close();
            Conexion.Close();
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

                throw ex ;
            }
        }

        public void SetearParametros(string nombre, object valor)
        {
            Comando.Parameters.AddWithValue(nombre, valor);
        }
    }
}
