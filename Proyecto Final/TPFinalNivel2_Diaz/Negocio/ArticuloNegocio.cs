using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> Lista = new List<Articulo>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.ImagenUrl, A.Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                Datos.ExecuteRead();
                while (Datos.lector.Read())
                {
                    Articulo Aux = new Articulo();
                    Aux.Id = (int)Datos.lector["Id"];
                    Aux.Codigo = (string)Datos.lector["Codigo"];
                    Aux.Nombre = (string)Datos.lector["Nombre"];
                    Aux.Descripcion = (string)Datos.lector["Descripcion"];
                    Aux.Marca = new Marca();
                    Aux.Marca.Id = (int)Datos.lector["IdMarca"];
                    Aux.Marca.Descripcion = (string)Datos.lector["Marca"];
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Id = (int)Datos.lector["IdCategoria"];
                    Aux.Categoria.Descripcion = (string)Datos.lector["Categoria"];
                    Aux.Imagen = (string)Datos.lector["ImagenUrl"];
                    Aux.Precio = (decimal)Datos.lector["Precio"];

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

        public void Agregar(Articulo Nuevo)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagenUrl, @precio)");
                Datos.SetParameters("@codigo", Nuevo.Codigo);
                Datos.SetParameters("@nombre", Nuevo.Nombre);
                Datos.SetParameters("@descripcion", Nuevo.Descripcion);
                Datos.SetParameters("@idMarca", Nuevo.Marca.Id);
                Datos.SetParameters("@idCategoria", Nuevo.Categoria.Id);
                Datos.SetParameters("@imagenUrl", Nuevo.Imagen);
                Datos.SetParameters("@precio", Nuevo.Precio);
                Datos.ExecuteAction();
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

        public void Modificar(Articulo ArticuloM)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio WHERE Id = @id");
                Datos.SetParameters("@codigo", ArticuloM.Codigo);
                Datos.SetParameters("@nombre", ArticuloM.Nombre);
                Datos.SetParameters("@descripcion", ArticuloM.Descripcion);
                Datos.SetParameters("@idMarca", ArticuloM.Marca.Id);
                Datos.SetParameters("@idCategoria", ArticuloM.Categoria.Id);
                Datos.SetParameters("@imagenUrl", ArticuloM.Imagen);
                Datos.SetParameters("@precio", ArticuloM.Precio);
                Datos.SetParameters("@id", ArticuloM.Id);
                Datos.ExecuteAction();
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

        public void Eliminar(int Id)
        {
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                Datos.SetQuery("DELETE FROM ARTICULOS WHERE Id = @id");
                Datos.SetParameters("@id", Id);
                Datos.ExecuteAction();
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

        public List<Articulo> FiltroAvanzado(string Campo, string Criterio, string Filtro)
        {
            List<Articulo> Lista = new List<Articulo>();
            AccesoDatos Datos = new AccesoDatos();
            try
            {
                string Consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, M.Descripcion Marca, A.IdCategoria, C.Descripcion Categoria, A.ImagenUrl, A.Precio FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND ";
                if (Campo == "Id")
                {
                    switch (Criterio)
                    {
                        case "Mayor a":
                            Consulta += "A.Id > " + Filtro;
                            break;

                        case "Menor a":
                            Consulta += "A.Id < " + Filtro;
                            break;

                        default:
                            Consulta += "A.Id = " + Filtro;
                            break;
                    }
                }
                else if (Campo == "Código")
                {
                    Consulta += "A.Codigo = '" + Filtro + "'";
                }
                else if (Campo == "Nombre")
                {
                    switch (Criterio)
                    {
                        case "Empieza con":
                            Consulta += "A.Nombre like '" + Filtro + "%'";
                            break;

                        case "Termina con":
                            Consulta += "A.Nombre like '%" + Filtro + "'";
                            break;

                        default:
                            Consulta += "A.Nombre like '%" + Filtro + "%'";
                            break;
                    }
                }
                else if (Campo == "Marca")
                {
                    Consulta += "M.Descripcion = '" + Criterio + "'";
                }
                else
                {
                    Consulta += "C.Descripcion = '" + Criterio + "'";
                }
                Datos.SetQuery(Consulta);
                Datos.ExecuteRead();
                while (Datos.lector.Read())
                {
                    Articulo Aux = new Articulo();
                    Aux.Id = (int)Datos.lector["Id"];
                    Aux.Codigo = (string)Datos.lector["Codigo"];
                    Aux.Nombre = (string)Datos.lector["Nombre"];
                    Aux.Descripcion = (string)Datos.lector["Descripcion"];
                    Aux.Marca = new Marca();
                    Aux.Marca.Id = (int)Datos.lector["IdMarca"];
                    Aux.Marca.Descripcion = (string)Datos.lector["Marca"];
                    Aux.Categoria = new Categoria();
                    Aux.Categoria.Id = (int)Datos.lector["IdCategoria"];
                    Aux.Categoria.Descripcion = (string)Datos.lector["Categoria"];
                    Aux.Imagen = (string)Datos.lector["ImagenUrl"];
                    Aux.Precio = (decimal)Datos.lector["Precio"];

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
