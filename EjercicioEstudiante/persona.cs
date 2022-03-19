using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    class Persona
    {
        #region atributos
        protected int dni;
        private string nombre;
        private DateTime fechaNacim;
        #endregion

        #region propiedades
        public string NOMBRE
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value != "")
                    nombre = value;
            }
        }
        public DateTime FECHA
        {
            get
            {
                return fechaNacim;
            }
            set
            {
                fechaNacim = value;
            }
        }
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                //si value es 0 entonces dni = 0
                if (value > 0)
                    dni = value;
                else
                    dni = Math.Abs(value);
            }
        }
        #endregion

        #region consultas
        public override string ToString()
        {
            return $"DNI {dni.ToString()} - {nombre} - {fechaNacim.ToString("dd/MM/yyyy")}";
        }
        public override bool Equals(Object obj)
        {
            bool igual;
            if (obj == null)
                igual = (this == null);
            else if (this.GetType() != obj.GetType())
                igual = false;
            else
            {
                Persona p = (Persona)obj;
                igual = (this.dni == p.dni);
            }
            return igual;
        }
        public override int GetHashCode()
        {
            return dni * 10;
        }
        public bool mayorIgualQue(Persona actual)
        {
            return (dni.CompareTo(actual.DNI)>=0);
        }
        #endregion 

        #region constructores
        public Persona(int DNI)
        {
            nombre = string.Empty;
            fechaNacim = new DateTime(1900,1,1);
            if (DNI > 0)
                dni = DNI;
            else
                dni = Math.Abs(DNI);
        }
        public Persona(string NOMBRE, DateTime fecha, int DNI)
        {
            nombre = NOMBRE;
            fechaNacim = fecha;
            if (DNI > 0)
                dni = DNI;
            else
                dni = Math.Abs(DNI);
        }
        #endregion
    }
}