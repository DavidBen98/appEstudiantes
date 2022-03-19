using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    class Estudiante:Persona
    {
        #region atributos
        private int legajo;
        private string carrera;
        #endregion

        #region propiedades
        public int LEGAJO
        {
            get
            {
                return legajo;
            }
            set
            {
                if (value > 0)
                    legajo = value;
                else
                    legajo = Math.Abs(value);
            }
        }
        public string CARRERA
        {
            get
            {
                return carrera;
            }
            set
            {
                if (value != "")
                    carrera = value;
            }
        }
        #endregion

        #region consultas
        public override string ToString()
        {
            return ($"Estudiante: {legajo.ToString()} - {carrera} - {base.ToString()}");
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
                Estudiante es = (Estudiante)obj;
                igual = (this.legajo == es.LEGAJO);
            }
            return igual;
        }
        public override int GetHashCode()
        {
            return legajo * 10;
        }
        #endregion

        #region constructores
        public Estudiante(string NOMBRE, DateTime FECHAN, int DNI, int LEGAJO, string CARRERA):base(NOMBRE,FECHAN,DNI)
        {
            carrera = CARRERA;
            if (LEGAJO > 0)
                legajo = LEGAJO;
            else
                legajo = Math.Abs(LEGAJO);
        }
        public Estudiante (int DNI, int LEGAJO) : base(DNI)
        {
            carrera = string.Empty;
            if (LEGAJO > 0)
                legajo = LEGAJO;
            else
                legajo = Math.Abs(LEGAJO);
        }
        #endregion
    }
}