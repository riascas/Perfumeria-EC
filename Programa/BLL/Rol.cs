using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Rol
    {
		private int _idRol;

		public int IDRol
		{
			get { return _idRol; }
			set { _idRol = value; }
		}

		private string _descripcion;

		public string Descripcion
		{
			get { return _descripcion; }
			set { _descripcion = value; }
		}
		private string _fechaRegistro;

		public string FechaRegistro
		{
			get { return _fechaRegistro; }
			set { _fechaRegistro = value; }
		}

	}
}
