using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EdicionNegocio
    {
        public List<Edicion> Listar()
        {
            List<Edicion> Lista = new List<Edicion>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("SELECT Id, Descripcion FROM TIPOSEDICION");
                Datos.ExecuteRead();
                while (Datos.lector.Read())
                {
                    Edicion AUX = new Edicion();
                    AUX.Id = (int)Datos.lector["Id"];
                    AUX.Descripcion = (string)Datos.lector["Descripcion"];
                    Lista.Add(AUX);
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.CloseConexion();
            }
        }
    }
}
