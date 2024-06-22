using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public abstract class Usuario
    {
        private int _idUsuario;

        public int IDUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        private string _dni;

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _correo;

        public string Correo
        {
            get { return _correo; }
            set { _correo = value; }
        }
        private bool _estado;

        public bool Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        private string _fechaRegistro;

        public string FechaRegistro
        {
            get { return _fechaRegistro; }
            set { _fechaRegistro = value; }
        }

        
    }
}
