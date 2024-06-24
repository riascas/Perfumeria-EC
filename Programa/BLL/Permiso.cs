using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Permiso
    {
		private int _idPermiso;

		public int IdPermiso
		{
			get { return _idPermiso; }
			set { _idPermiso = value; }
		}
		private Rol _objRol;

		public Rol ObjRol
		{
			get { return _objRol; }
			set { _objRol = value; }
		}


		private string _nombreMenu;

		public string NombreMenu
		{
			get { return _nombreMenu; }
			set { _nombreMenu = value; }
		}
		private string _fechaRegistro;

		public string FechaRegistro
		{
			get { return _fechaRegistro; }
			set { _fechaRegistro = value; }
		}

        public List<Permiso> ListarPermisos(int idempleado)
        {
            List<Permiso> lista = new List<Permiso>();

            
            Conexion objConexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = objConexion.crearParametro("@IDEmpleado", idempleado);
            DataTable Emp;// = objConexion.LeerPorComando("select [FKRol], [NombreMenu] from [DBPerfumeria_Cosmos].[dbo].[Permiso]");
            Emp = objConexion.LeerPorStoreProcedure("ObtenerPermisosPorEmpleado", parametros);
			
            foreach (DataRow dato in Emp.Rows)
            {
                lista.Add(new Permiso()
                {
                    ObjRol = new Rol() { IDRol = Convert.ToInt32(dato["FKRol"])},
					NombreMenu = dato["NombreMenu"].ToString(),
                });
            }
            return lista;


        }
    }
}
