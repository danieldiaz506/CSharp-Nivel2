using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Deployment.Internal;

namespace Negocio
{
    public class DiscosNegocio
    {

        public List<Discos> Listar()

        {
            List<Discos> Lista = new List<Discos>();    
            SqlConnection Conexion = new SqlConnection();
            SqlCommand Comando = new SqlCommand();
            SqlDataReader Lector;

            try
            {
                Conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = "SELECT D.Id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion TipoEstilo, T.Descripcion TipoEdicion, D.IdEstilo, D.IdTipoEdicion FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id AND D.Activo = 1";
                Comando.Connection = Conexion;

                Conexion.Open();
                Lector = Comando.ExecuteReader();   

                while (Lector.Read())
                {
                    Discos AUX = new Discos();
                    AUX.Id = (int)Lector["Id"];
                    AUX.Titulo = (string)Lector["Titulo"];
                    if (!(Lector.IsDBNull(Lector.GetOrdinal("FechaLanzamiento"))))
                    {
                        AUX.FechaLanzamiento = (DateTime)Lector["FechaLanzamiento"];
                    }
                    AUX.CantidadCanciones = Lector.GetInt32(3);
                    if (!(Lector["UrlImagenTapa"] is DBNull))
                    {
                        AUX.UrlImagenTapa = (string)Lector["UrlImagenTapa"];                       
                    }
                    AUX.TipoEstilo = new Estilo();
                    AUX.TipoEstilo.Id = (int)(Lector["IdEstilo"]);
                    AUX.TipoEstilo.Descripcion = (string)Lector["TipoEstilo"];
                    AUX.TipoEdicion = new Edicion();
                    AUX.TipoEdicion.Id = (int)Lector["IdTipoEdicion"];
                    AUX.TipoEdicion.Descripcion = (string)Lector["TipoEdicion"];
                   
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
                Conexion.Close(); ;
            }
           
        }

        public void Agregar(Discos Nuevo)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("INSERT INTO DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion, Activo) VALUES (@titulo, @fechaLanzamiento, @cantidadCanciones, @urlImagenTapa, @idEstilo, @idTipoEdicion, 1)");
                Datos.SetearParametros("@titulo", Nuevo.Titulo);
                Datos.SetearParametros("@fechaLanzamiento", Nuevo.FechaLanzamiento);
                Datos.SetearParametros("@cantidadCanciones", Nuevo.CantidadCanciones);
                Datos.SetearParametros("@urlImagenTapa", Nuevo.UrlImagenTapa);
                Datos.SetearParametros("@idEstilo", Nuevo.TipoEstilo.Id);
                Datos.SetearParametros("@idTipoEdicion", Nuevo.TipoEdicion.Id);
                Datos.ExecuteAction();
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

        public void Modificar(Discos Disco)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("UPDATE DISCOS SET Titulo = @titulo, FechaLanzamiento = @fechaLanzamiento, CantidadCanciones = @cantidadCanciones, UrlImagenTapa = @urlImagen, IdEstilo = @idEstilo, IdTipoEdicion = @idTipoEdicion WHERE Id = @id");
                Datos.SetearParametros("@titulo", Disco.Titulo);
                Datos.SetearParametros("@fechaLanzamiento", Disco.FechaLanzamiento);
                Datos.SetearParametros("@cantidadCanciones", Disco.CantidadCanciones);
                Datos.SetearParametros("@urlImagen", Disco.UrlImagenTapa);
                Datos.SetearParametros("@idEstilo", Disco.TipoEstilo.Id);
                Datos.SetearParametros("@idTipoEdicion", Disco.TipoEdicion.Id);
                Datos.SetearParametros("@id", Disco.Id);
                Datos.ExecuteAction();
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

        public void EliminarFisico(int Id)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("DELETE FROM DISCOS WHERE Id = @id");
                Datos.SetearParametros("@id", Id);
                Datos.ExecuteAction();
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

        public void EliminarLogico(int Id)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("UPDATE DISCOS SET Activo = 0 WHERE Id = @id");
                Datos.SetearParametros("@id", Id);
                Datos.ExecuteAction();
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

        public List<Discos> Filtrar(string Campo, string Criterio, string Filtro)
        {
            List<Discos> Lista = new List<Discos>();
            AccesoDatos Datos = new AccesoDatos();
            string Consulta = "SELECT D.Id, D.Titulo, D.FechaLanzamiento, D.CantidadCanciones, D.UrlImagenTapa, E.Descripcion TipoEstilo, T.Descripcion TipoEdicion, D.IdEstilo, D.IdTipoEdicion FROM DISCOS D, ESTILOS E, TIPOSEDICION T WHERE D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id AND D.Activo = 1 AND ";
            switch (Campo)
            {
                case "Id":
                    switch (Criterio)
                    {
                        case "Mayor que":
                            Consulta += "D.Id > " + Filtro;
                            break;

                        case "Menor que":
                            Consulta += "D.Id < " + Filtro;
                            break;

                        default:
                            Consulta += "D.Id = " + Filtro;
                            break;
                    }
                    break;
                case "Título":
                    switch (Criterio)
                    {
                        case "Empieza por":
                            Consulta += "D.Titulo like '" + Filtro + "%'";
                            break;

                        case "Termina por":
                            Consulta += "D.Titulo like '%" + Filtro + "'";
                            break;
                                                                          
                        default:
                            Consulta += "D.Titulo like '%" + Filtro + "%'";
                            break;
                    }
                    break;
                default:
                    break;
            }
            if (Campo == "Tipo de estilo")
            {
                Consulta += "E.Descripcion = '" + Criterio + "'";
            }
            Datos.SetQuery(Consulta);
            Datos.ExecuteRead();
            while (Datos.lector.Read())
            {
                Discos AUX = new Discos();
                AUX.Id = (int)Datos.lector["Id"];
                AUX.Titulo = (string)Datos.lector["Titulo"];
                if (!(Datos.lector.IsDBNull(Datos.lector.GetOrdinal("FechaLanzamiento"))))
                {
                    AUX.FechaLanzamiento = (DateTime)Datos.lector["FechaLanzamiento"];
                }
                AUX.CantidadCanciones = Datos.lector.GetInt32(3);
                if (!(Datos.lector["UrlImagenTapa"] is DBNull))
                {
                    AUX.UrlImagenTapa = (string)Datos.lector["UrlImagenTapa"];
                }
                AUX.TipoEstilo = new Estilo();
                AUX.TipoEstilo.Id = (int)(Datos.lector["IdEstilo"]);
                AUX.TipoEstilo.Descripcion = (string)Datos.lector["TipoEstilo"];
                AUX.TipoEdicion = new Edicion();
                AUX.TipoEdicion.Id = (int)Datos.lector["IdTipoEdicion"];
                AUX.TipoEdicion.Descripcion = (string)Datos.lector["TipoEdicion"];

                Lista.Add(AUX);

            }
            return Lista;
        }
    }
}
