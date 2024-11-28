using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EstiloNegocio
    {
        public List<Estilo> Listar()
        {
            List<Estilo> Lista = new List<Estilo>();    
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("SELECT Id, Descripcion FROM ESTILOS");
                Datos.ExecuteRead();
                while (Datos.lector.Read())
                {
                    Estilo AUX = new Estilo();
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
