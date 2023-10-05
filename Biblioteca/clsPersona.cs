using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class clsPersona
    {
        #region atributos
        private String _nombre;
        private String _apellidos;
        #endregion

        #region constructores
        public clsPersona()
        {
            _nombre = "";
            _apellidos = "";
        }
        public clsPersona(string nombre, string apellidos)
        {
            _nombre = nombre;
            _apellidos = apellidos;
        }

        #endregion

        #region propiedades
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public String Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }
        public String Direccion { get; set; }
        public String NombreCompleto
        {
            get { return $"Su nombre completo es {Nombre} {Apellidos}"; }
        }
        #endregion

        #region funciones y metodos

        #endregion

    }
}
