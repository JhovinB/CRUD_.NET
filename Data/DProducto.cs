using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DProducto
    {
        public List<Producto> Listar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            List<Producto> productos = null;

            try
            {
                comandText = "USP_GetProducto";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idproducto", SqlDbType.Int);
                parameters[0].Value = producto.IdProducto;
                productos = new List<Producto>();
                using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.Connection, "USP_GetProducto",
                    CommandType.StoredProcedure, parameters))
                {
                    while (reader.Read())
                    {
                        productos.Add(new Producto
                        {
                            IdProducto = reader["Idproducto"] != null ? Convert.ToInt32(reader["Idproducto"]) : 0,
                            NombreProducto = reader["nombreproducto"] != null ? Convert.ToString(reader["nombreproducto"]) : string.Empty,
                            IdProveedor = reader["Idproveedor"] != null ? Convert.ToInt32(reader["Idproveedor"]) :0,
                            IdCategoria = reader["Idcategoria"]!=null?Convert.ToInt32(reader["Idcategoria"]):0,
                            CantidadPorUnidad = reader["cantidadporunidad"] != null ? Convert.ToString(reader["cantidadporunidad"]) : string.Empty,
                            PrecioUnidad = reader["preciounidad"] != null ? Convert.ToInt32(reader["preciounidad"]) :0,
                            UnidadesExistentes = reader["unidadesexistentes"] != null ? Convert.ToInt32(reader["unidadesenexistencia"]) :0,
                            UnidadesPedidas = reader["unidadespedidas"] != null ? Convert.ToInt32(reader["unidadesenpedido"]) :0,
                            NivelNuevoPedido = reader["nivelnuevopedido"] != null ? Convert.ToInt32(reader["nivelnuevopedido"]) :0,
                            Suspendido = reader["suspendido"] != null ? Convert.ToBoolean(reader["suspendido"]) :false,
                            CategoriaProducto = reader["categoriaproducto"] != null ? Convert.ToString(reader["categoriaproducto"]) : string.Empty

                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return productos;

        }
        public void Insertar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;

            try
            {
                comandText = "USP_InsProducto";
                parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@nombreproducto", SqlDbType.VarChar);
                parameters[0].Value = producto.NombreProducto;
                parameters[1] = new SqlParameter("@idproveedor", SqlDbType.Int);
                parameters[1].Value = producto.IdProveedor;
                parameters[2] = new SqlParameter("@idcategoria", SqlDbType.Int);
                parameters[2].Value = producto.IdCategoria;
                parameters[3] = new SqlParameter("@cantidadporunidad", SqlDbType.Text);
                parameters[3].Value = producto.CantidadPorUnidad;
                parameters[4] = new SqlParameter("@preciounidad", SqlDbType.Int);
                parameters[4].Value = producto.PrecioUnidad;
                parameters[5] = new SqlParameter("@unidadesenexistencia", SqlDbType.Int);
                parameters[5].Value = producto.UnidadesExistentes;
                parameters[6] = new SqlParameter("@unidadesenpedido", SqlDbType.Int);
                parameters[6].Value = producto.UnidadesPedidas;
                parameters[7] = new SqlParameter("@nivelnuevopedido", SqlDbType.Int);
                parameters[7].Value = producto.NivelNuevoPedido;
                parameters[8] = new SqlParameter("@suspendido", SqlDbType.Char);
                parameters[8].Value = producto.Suspendido;
                parameters[9] = new SqlParameter("@categoriaproducto", SqlDbType.Text);
                parameters[9].Value = producto.CategoriaProducto;
                SqlHelper.ExecuteNonQuery(SqlHelper.Connection, comandText, CommandType.StoredProcedure, parameters);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void Actualizar(Producto producto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;

            try
            {
                comandText = "USP_UpdProducto";
                parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@idproducto", SqlDbType.Int);
                parameters[0].Value = producto.IdProducto;
                parameters[1] = new SqlParameter("@nombreproducto", SqlDbType.VarChar);
                parameters[1].Value = producto.NombreProducto;
                parameters[2] = new SqlParameter("@idproveedor", SqlDbType.Int);
                parameters[2].Value = producto.IdProveedor;
                parameters[3] = new SqlParameter("@idcategoria", SqlDbType.Int);
                parameters[3].Value = producto.IdCategoria;
                parameters[4] = new SqlParameter("@cantidadporunidad", SqlDbType.Text);
                parameters[4].Value = producto.CantidadPorUnidad;
                parameters[5] = new SqlParameter("preciounidad", SqlDbType.Int);
                parameters[5].Value = producto.PrecioUnidad;
                parameters[6] = new SqlParameter("@unidadesenexistencia", SqlDbType.Int);
                parameters[6].Value = producto.UnidadesExistentes;
                parameters[7] = new SqlParameter("unidadesenpedido", SqlDbType.Int);
                parameters[7].Value = producto.UnidadesPedidas;
                parameters[8] = new SqlParameter("nivelnuevopedido", SqlDbType.Int);
                parameters[8].Value = producto.NivelNuevoPedido;
                parameters[9] = new SqlParameter("suspendido", SqlDbType.Char);
                parameters[9].Value = producto.Suspendido;
                parameters[10] = new SqlParameter("categoriaproducto", SqlDbType.Text);
                parameters[10].Value = producto.CategoriaProducto;
                SqlHelper.ExecuteNonQuery(SqlHelper.Connection, comandText, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(int IdProducto)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;

            try
            {
                comandText = "USP_DelProducto";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idproducto", SqlDbType.Int);
                parameters[0].Value = IdProducto;
                SqlHelper.ExecuteNonQuery(SqlHelper.Connection, comandText, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

