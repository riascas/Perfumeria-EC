using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Empleado : Usuario
    {
        private int _idEmpleado;

        public int IDEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private Usuario _fkUsuario;

        public Usuario oUsuario
        {
            get { return _fkUsuario; }
            set { _fkUsuario = value; }
        }
        private Rol _fkRol;

        public Rol oRol
        {
            get { return _fkRol; }
            set { _fkRol = value; }
        }

        private string _nombreUsuario;

        public string NombreUsuario
        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }
        private string _clave;

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }
        /*public Empleado(int idEmpleado, Usuario oUsuario, Rol oRol, string nombreUsuario, string clave)
        {

        }*/

        public List<Empleado> Listado()
        {
            List<Empleado> lista = new List<Empleado>();

            Conexion objConexion = new Conexion();

            DataTable Emp = objConexion.LeerPorComando("select [IDEmpleado], [NombreUsuario], [Clave] from [DBPerfumeria_Cosmos].[dbo].[Empleado]");

            foreach (DataRow dato in Emp.Rows) 
            {
                lista.Add(new Empleado()
                {
                    IDEmpleado = Convert.ToInt32(dato["IDEmpleado"]),
                    NombreUsuario = dato["NombreUsuario"].ToString(),
                    Clave = dato["Clave"].ToString(),
                });
            }
            return lista;

        }

        /*public List<Empleado> IniciarSesion()
        {

        }*/
       
        }
    
    }
