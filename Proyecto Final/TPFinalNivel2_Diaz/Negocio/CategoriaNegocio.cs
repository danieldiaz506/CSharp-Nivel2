using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListaCategorias()
        {
            List<Categoria> Lista = new List<Categoria>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("SELECT Id, Descripcion FROM CATEGORIAS");
                Datos.ExecuteRead();
                while (Datos.lector.Read())
                {
                    Categoria Aux = new Categoria();
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
