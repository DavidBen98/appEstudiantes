using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPersona
{
    class Empleado:Persona
    {
            #region atributos
            protected int legajo;
            private string cargo;
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
            public string CARGO
            {
                get
                {
                    return cargo;
                }
                set
                {
                    if (value != "")
                        cargo = value;
                }
            }
            #endregion

            #region consultas
            public override string ToString()
            {
                return ($"Empleado: {legajo.ToString()} - {cargo} - {base.ToString()}");
            }
            public override bool Equals(object obj)
            {
                bool igual;
                if (obj == null)
                    igual = (this == null);
                else if (this.GetType() != obj.GetType())
                    igual = false;
                else
                {
                    Empleado em = (Empleado)obj;
                    igual = (this.legajo == em.LEGAJO);
                }
                return igual;
            }
            public override int GetHashCode()
            {
                return (legajo * dni) / 10;
            }
            #endregion

            #region constructores
            public Empleado(string NOMBRE, DateTime FECHAN, int DNI, int LEGAJO, string CARGO) : base(NOMBRE, FECHAN, DNI)
            {
                cargo = CARGO;
                if (LEGAJO > 0)
                    legajo = LEGAJO;
                else
                    legajo = Math.Abs(LEGAJO);
            }
            public Empleado(int DNI, int LEGAJO) : base(DNI)
            {
                cargo = string.Empty;
                if (LEGAJO > 0)
                    legajo = LEGAJO;
                else
                    legajo = Math.Abs(LEGAJO);
            }
            #endregion
    }
}