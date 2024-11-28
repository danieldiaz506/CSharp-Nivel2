using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> ListaMarcas()
        {
            List<Marca> Lista = new List<Marca>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("SELECT Id, Descripcion FROM MARCAS");
                Datos.ExecuteRead();
                while (Datos.lector.Read())
                {
                    Marca Aux = new Marca();
                    Aux.Id = (int)Datos.lector["Id"];
                    Aux.Descripcion = (string)Datos.lector["Descripcion"];
                    Lista.Add(Aux);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.CloseConnection();    
            }
        }
    }
}
