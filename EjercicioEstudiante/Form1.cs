using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPersona
{
    public partial class fPersonas : Form
    {
        #region variables
        Persona[] aPersonas;
        int topePersonas;
        int ultimoPersonas;
        #endregion

        #region inicializacion
        public fPersonas()
        {
            InitializeComponent();
            topePersonas = 100;
            aPersonas = new Persona[topePersonas];
            ultimoPersonas = -1;
            cbFiltro.SelectedIndex = 0;
            cbCarrera.SelectedIndex = 0;
            mtDocumento.Focus();
            dtFechaNac.Value = DateTime.Today;
            dtFechaNac.MaxDate = DateTime.Today;
        }
        #endregion

        #region metodos
        private void limpiarCampos()
        {
            mtDocumento.Text = "";
            tNombre.Text = "";
            dtFechaNac.Value = DateTime.Today;
            mtLegajo.Text = "";
            cbCarrera.SelectedIndex = 0;
        }
        private bool ExistePersona(Persona[]arreglo, int ultimo, Persona actual, out int posicion)
        {
            int pos = 0;
            bool repetido = false;
            while ((pos<=ultimo) && (arreglo[pos].mayorIgualQue(actual)))
            {
                Persona arAuxiliar = arreglo[pos];
                if (arAuxiliar.GetType() != typeof(Persona))
                    arAuxiliar = new Persona(arAuxiliar.DNI);
                if (actual.Equals(arAuxiliar))
                    repetido = true;
                else
                    pos++;
            }
            posicion = pos;
            return repetido;
        }
        private bool ExisteLegajo(Persona[] arreglo, int ultimo, Persona actual, out int posicion)
        {//No se puede buscar ordenado porque se ordena en base a DNI, no en base a LEGAJO
            int pos = 0;
            while ((pos <= ultimo) && (!actual.Equals(arreglo[pos])))
            {
                pos++;
            }
            posicion = pos;
            return (pos <= ultimo);
        }
        private void InsertarPersonaOrdenada(ref Persona[] arreglo, ref int ultimo, Persona actual)
        {
            int i = ultimo;
            if (ultimo + 1 < topePersonas)
            {
                while ((i >= 0) && (!actual.mayorIgualQue(arreglo[i])))
                {
                    arreglo[i + 1] = arreglo[i];
                    i--;
                }
                arreglo[i + 1] = actual;
                ++ultimo;
            }
        }
        private void EliminarPersonaOrdenado(ref Persona[] arreglo, ref int ultimo, Persona actual)
        {
            bool esta = false;
            int i = 0;
            do
            {
                if (arreglo[i].Equals(actual))
                    esta = true;
                else
                    i++;
            }
            while (!esta && i<=ultimo);

            if (i <= ultimo)
            {
                for (int j = i; j < ultimo; j++)
                {
                    arreglo[j] = arreglo[j + 1];
                }
                --ultimo;
            }
        }
        private void actualizarListado()
        {
            lbPersonas.Items.Clear();
            if (cbFiltro.SelectedIndex == 0)
            {
                for (int i=0; i <= ultimoPersonas; i++)
                    lbPersonas.Items.Add(aPersonas[i].ToString());
            }
            else if (cbFiltro.SelectedIndex == 1)
            {
                for (int i = 0; i <= ultimoPersonas; i++)
                {
                    if (aPersonas[i].GetType() == typeof(Persona))
                        lbPersonas.Items.Add(aPersonas[i].ToString());
                }
            }
            else if (cbFiltro.SelectedIndex == 2)
            {
                for (int i = 0; i <= ultimoPersonas; i++)
                {
                    if (aPersonas[i].GetType() == typeof(Estudiante))
                        lbPersonas.Items.Add(aPersonas[i].ToString());
                }
            }
            else
            {
                for (int i = 0; i <= ultimoPersonas; i++)
                {
                    if (aPersonas[i].GetType() == typeof(Empleado))
                        lbPersonas.Items.Add(aPersonas[i].ToString());
                }

            }
            lCantidad.Text = $"Cantidad: {lbPersonas.Items.Count}";
        }
        #endregion

        #region botones
        private void bGuardar_Click(object sender, EventArgs e)
        {
            #region variables y atributos
            string nombre = tNombre.Text.Trim() != "" ? tNombre.Text.Trim() : string.Empty;
            int dni = mtDocumento.MaskFull ? Convert.ToInt32(mtDocumento.Text) : 0;
            DateTime fechaNac = new DateTime(dtFechaNac.Value.Year, dtFechaNac.Value.Month, dtFechaNac.Value.Day);
            int legajo = mtLegajo.MaskFull ? Convert.ToInt32(mtLegajo.Text) : 0;
            string carrera = cbCarrera.Text != "" ? cbCarrera.Text : string.Empty;
            string cargo = cbCarrera.Text != "" ? cbCarrera.Text : string.Empty;
            int posicion;
            int posicionEs;
            int posicionEm; //con posicionEs alcanza, pero sirve de guia diferenciar estud de empleado
            Persona personaActual = new Persona(nombre,fechaNac,dni);
            Estudiante estudianteActual = new Estudiante(nombre,fechaNac,dni, legajo,carrera);
            Empleado empleadoActual = new Empleado(nombre,fechaNac, dni, legajo,cargo);
            #endregion

            #region chequeos
            if (ultimoPersonas + 1 == topePersonas)
            {
                MessageBox.Show("No se pueden agregar mas personas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bGuardar.Enabled = false;
                limpiarCampos();
            }
            else if (!mtDocumento.MaskFull)
            {
                MessageBox.Show("Debe completar el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDocumento.Focus();
            }
            else if (!rbPersona.Checked && !mtLegajo.MaskFull)
            {
                MessageBox.Show("Debe completar el legajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtLegajo.Focus();
            }
            #endregion
            else if (ExistePersona(aPersonas,ultimoPersonas,personaActual, out posicion))
            { //existe alguien con ese dni
                DialogResult respuesta;
                respuesta = MessageBox.Show($"Existe una persona con ese DNI, estos son sus datos:\n{aPersonas[posicion].ToString()} ¿Desea actualizarlos?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    if (rbPersona.Checked)
                    {//si es persona
                        aPersonas[posicion] = personaActual;
                        MessageBox.Show($"Se ha actualizado correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (rbEstudiante.Checked)
                    {//si es estudiante
                        if (!ExisteLegajo(aPersonas, ultimoPersonas,estudianteActual, out posicionEs))
                        {//si no existe un estudiante con ese legajo
                            aPersonas[posicion] = estudianteActual;
                            MessageBox.Show($"Se ha actualizado correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            //2 posibilidades:
                            //1)Preguntarle si quiere actualizar aunque exista otro estudiante con ese legajo
                            //2)la siguiente:
                            if (posicion < posicionEs)
                            {
                                EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicionEs]); //elimina el estudiante que tenia el mismo legajo
                                EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicion]);
                            }
                            else
                            {
                                EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicion]);
                                EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicionEs]); //elimina el estudiante que tenia el mismo legajo
                            }
                            InsertarPersonaOrdenada(ref aPersonas, ref ultimoPersonas, estudianteActual);
                            //aPersonas[posicion] = estudianteActual;
                            MessageBox.Show("Se ha actualizado correctamente, ademas existia otro estudiante con ese legajo que ha sido eliminado","Actualizar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                    else
                    {//si es empleado
                        if (!ExisteLegajo(aPersonas,ultimoPersonas,empleadoActual, out posicionEm))
                        {//si no existe un empleado con ese legajo
                            aPersonas[posicion] = empleadoActual;
                            MessageBox.Show($"Se ha actualizado correctamente", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (posicion < posicionEm)
                            {
                                EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicionEm]); //elimina el estudiante que tenia el mismo legajo
                                EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicion]);
                            }
                            else
                            {
                                EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicion]);
                                EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicionEm]); //elimina el estudiante que tenia el mismo legajo
                            }
                            InsertarPersonaOrdenada(ref aPersonas, ref ultimoPersonas, empleadoActual);
                            MessageBox.Show("Se ha actualizado correctamente, ademas existia otro empleado con ese legajo que ha sido eliminado", "Actualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se han actualizado los datos","Actualizar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                limpiarCampos();
            }
            else
            {//si no existe alguien con ese dni
                if (rbPersona.Checked)
                {
                    InsertarPersonaOrdenada(ref aPersonas,ref ultimoPersonas,personaActual);
                    limpiarCampos();
                    MessageBox.Show($"Se ha agregado correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbEstudiante.Checked)
                {
                    if (!ExisteLegajo(aPersonas,ultimoPersonas,estudianteActual, out posicionEs))
                    {//si no existe ese legajo
                        InsertarPersonaOrdenada(ref aPersonas, ref ultimoPersonas, estudianteActual);
                        MessageBox.Show($"Se ha agregado correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult respuesta;
                        respuesta = MessageBox.Show($"Existe una persona con ese LEGAJO, estos son sus datos:\n{aPersonas[posicionEs].ToString()} ¿Desea actualizarlos?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicionEs]);
                            InsertarPersonaOrdenada(ref aPersonas, ref ultimoPersonas, estudianteActual);
                            MessageBox.Show($"Se ha agregado correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha generado ningun cambio","Actualizar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }
                else if (rbEmpleado.Checked)
                {
                    if (!ExisteLegajo(aPersonas,ultimoPersonas,empleadoActual, out posicionEm))
                    {//si no existe ese legajo
                        InsertarPersonaOrdenada(ref aPersonas, ref ultimoPersonas, empleadoActual);
                        MessageBox.Show($"Se ha agregado correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult respuesta;
                        respuesta = MessageBox.Show($"Existe una persona con ese LEGAJO, estos son sus datos:\n{aPersonas[posicionEm].ToString()} ¿Desea actualizarlos?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            EliminarPersonaOrdenado(ref aPersonas, ref ultimoPersonas, aPersonas[posicionEm]);
                            InsertarPersonaOrdenada(ref aPersonas, ref ultimoPersonas, empleadoActual);
                            MessageBox.Show($"Se ha agregado correctamente", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se ha generado ningun cambio","Actualizar",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                }
                limpiarCampos();
            }
            actualizarListado();
        }
        private void bMostrar_Click(object sender, EventArgs e)
        {
            int dni = mtDocumento.MaskFull ? Convert.ToInt32(mtDocumento.Text) : 0;
            int legajo = mtLegajo.MaskFull ? Convert.ToInt32(mtLegajo.Text) : 0;
            Persona personaActual = new Persona(dni);
            Estudiante estudianteActual = new Estudiante(dni, legajo);
            Empleado empleadoActual = new Empleado(dni, legajo);
            int posicion;

            if (!mtDocumento.MaskFull && !mtLegajo.MaskFull)
            {
                MessageBox.Show("Debe completar el documento o el legajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtDocumento.Focus();
            }
            //primero filtra por dni, se podria añadir que este completo solo legajo o solo dni
            else if (mtDocumento.MaskFull && ExistePersona(aPersonas,ultimoPersonas, personaActual, out posicion))
            {//existe alguien con ese dni
                tNombre.Text = aPersonas[posicion].NOMBRE.ToString();
                dtFechaNac.Value = aPersonas[posicion].FECHA;
                
                if (aPersonas[posicion].GetType() == typeof(Estudiante))
                {//si es estudiante
                    Estudiante estudianteNuevo = (Estudiante)aPersonas[posicion];
                    rbEstudiante.Checked = true;
                    mtLegajo.Text = estudianteNuevo.LEGAJO.ToString();
                    cbCarrera.Text = estudianteNuevo.CARRERA.ToString();
                }
                else if (aPersonas[posicion].GetType() == typeof(Empleado))
                {//si es empleado
                    rbEmpleado.Checked = true;
                    Empleado empleadoNuevo = (Empleado)aPersonas[posicion];
                    mtLegajo.Text = empleadoNuevo.LEGAJO.ToString();
                    cbCarrera.Text = empleadoNuevo.CARGO.ToString();
                }
                else
                {
                    rbPersona.Checked = true;
                }
            }
            else if (rbEstudiante.Checked && ExisteLegajo(aPersonas, ultimoPersonas, estudianteActual, out posicion))
            {
                 Estudiante estudianteNuevo = (Estudiante)aPersonas[posicion];
                 mtDocumento.Text = estudianteNuevo.DNI.ToString();
                 tNombre.Text = estudianteNuevo.NOMBRE.ToString();
                 dtFechaNac.Value = estudianteNuevo.FECHA;
                 cbCarrera.Text = estudianteNuevo.CARRERA.ToString();
            }
            else if (rbEmpleado.Checked && ExisteLegajo(aPersonas, ultimoPersonas, empleadoActual, out posicion))
            {
                 Empleado empleadoNuevo = (Empleado)aPersonas[posicion];
                 mtDocumento.Text = empleadoNuevo.DNI.ToString();
                 tNombre.Text = empleadoNuevo.NOMBRE.ToString();
                 dtFechaNac.Value = empleadoNuevo.FECHA;
                 cbCarrera.Text = empleadoNuevo.CARGO.ToString();
            }
            else
            {
                MessageBox.Show("No existe nadie registrado con los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Está seguro que desea cerrar la aplicacion?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (respuesta == DialogResult.Yes)
                Close();
        }
        #endregion

        #region cambio filtro
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarListado();
        }
        #endregion

        #region ErrorProvider
        private void mtDocumento_Validating(object sender, CancelEventArgs e)
        {
            if (!mtDocumento.MaskFull)
                epValidar.SetError(mtDocumento, "Campo incompleto");
            else
                epValidar.Clear();
        }
        private void mtLegajo_Validating(object sender, CancelEventArgs e)
        {
            if (!mtLegajo.MaskFull)
                epValidar.SetError(mtLegajo, "Campo incompleto");
            else
                epValidar.Clear();
        }
        #endregion

        #region Paneles
        private void rbPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPersona.Checked)
            {
                pEstudiantes.Visible = false;
            }
            else if (rbEstudiante.Checked)
            {
                pEstudiantes.Visible = true;
                pEstudiantes.BackColor = Color.FromArgb(192, 255, 192);
                lCarrera.Text = "Carrera:";
                cbCarrera.Items.Clear();
                cbCarrera.Items.Add("Contabilidad");
                cbCarrera.Items.Add("Derecho");
                cbCarrera.Items.Add("Informatica");
                cbCarrera.SelectedIndex = 0;
            }
            else if (rbEmpleado.Checked)
            {
                pEstudiantes.Visible = true;
                pEstudiantes.BackColor = Color.FromArgb(192, 192,255);
                lCarrera.Text = "Cargo:";
                cbCarrera.Items.Clear();
                cbCarrera.Items.Add("Director");
                cbCarrera.Items.Add("Gerente");
                cbCarrera.Items.Add("Tecnico");
                cbCarrera.SelectedIndex = 0;
            }
        }
        #endregion
    }
}