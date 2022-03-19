
namespace EjercicioPersona
{
    partial class fPersonas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pPersonas = new System.Windows.Forms.Panel();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.rbEstudiante = new System.Windows.Forms.RadioButton();
            this.rbPersona = new System.Windows.Forms.RadioButton();
            this.dtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.mtDocumento = new System.Windows.Forms.MaskedTextBox();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pEstudiantes = new System.Windows.Forms.Panel();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.lCarrera = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mtLegajo = new System.Windows.Forms.MaskedTextBox();
            this.bMostrar = new System.Windows.Forms.Button();
            this.bGuardar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.pListado = new System.Windows.Forms.Panel();
            this.lCantidad = new System.Windows.Forms.Label();
            this.lbPersonas = new System.Windows.Forms.ListBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.epValidar = new System.Windows.Forms.ErrorProvider(this.components);
            this.pPersonas.SuspendLayout();
            this.pEstudiantes.SuspendLayout();
            this.pListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).BeginInit();
            this.SuspendLayout();
            // 
            // pPersonas
            // 
            this.pPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pPersonas.Controls.Add(this.rbEmpleado);
            this.pPersonas.Controls.Add(this.rbEstudiante);
            this.pPersonas.Controls.Add(this.rbPersona);
            this.pPersonas.Controls.Add(this.dtFechaNac);
            this.pPersonas.Controls.Add(this.mtDocumento);
            this.pPersonas.Controls.Add(this.tNombre);
            this.pPersonas.Controls.Add(this.label4);
            this.pPersonas.Controls.Add(this.label3);
            this.pPersonas.Controls.Add(this.label1);
            this.pPersonas.Location = new System.Drawing.Point(13, 13);
            this.pPersonas.Name = "pPersonas";
            this.pPersonas.Size = new System.Drawing.Size(240, 159);
            this.pPersonas.TabIndex = 0;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Location = new System.Drawing.Point(160, 130);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(72, 17);
            this.rbEmpleado.TabIndex = 10;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            this.rbEmpleado.CheckedChanged += new System.EventHandler(this.rbPersona_CheckedChanged);
            // 
            // rbEstudiante
            // 
            this.rbEstudiante.AutoSize = true;
            this.rbEstudiante.Location = new System.Drawing.Point(79, 130);
            this.rbEstudiante.Name = "rbEstudiante";
            this.rbEstudiante.Size = new System.Drawing.Size(75, 17);
            this.rbEstudiante.TabIndex = 9;
            this.rbEstudiante.Text = "Estudiante";
            this.rbEstudiante.UseVisualStyleBackColor = true;
            this.rbEstudiante.CheckedChanged += new System.EventHandler(this.rbPersona_CheckedChanged);
            // 
            // rbPersona
            // 
            this.rbPersona.AutoSize = true;
            this.rbPersona.Checked = true;
            this.rbPersona.Location = new System.Drawing.Point(9, 130);
            this.rbPersona.Name = "rbPersona";
            this.rbPersona.Size = new System.Drawing.Size(64, 17);
            this.rbPersona.TabIndex = 8;
            this.rbPersona.TabStop = true;
            this.rbPersona.Text = "Persona";
            this.rbPersona.UseVisualStyleBackColor = true;
            this.rbPersona.CheckedChanged += new System.EventHandler(this.rbPersona_CheckedChanged);
            // 
            // dtFechaNac
            // 
            this.dtFechaNac.CustomFormat = "dd/MM/yyyy";
            this.dtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaNac.Location = new System.Drawing.Point(95, 99);
            this.dtFechaNac.Name = "dtFechaNac";
            this.dtFechaNac.Size = new System.Drawing.Size(83, 20);
            this.dtFechaNac.TabIndex = 7;
            this.dtFechaNac.Value = new System.DateTime(2021, 6, 23, 0, 0, 0, 0);
            // 
            // mtDocumento
            // 
            this.mtDocumento.Location = new System.Drawing.Point(95, 28);
            this.mtDocumento.Mask = "99999999";
            this.mtDocumento.Name = "mtDocumento";
            this.mtDocumento.Size = new System.Drawing.Size(118, 20);
            this.mtDocumento.TabIndex = 6;
            this.mtDocumento.ValidatingType = typeof(int);
            this.mtDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.mtDocumento_Validating);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(95, 64);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(118, 20);
            this.tNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nac.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // pEstudiantes
            // 
            this.pEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pEstudiantes.Controls.Add(this.cbCarrera);
            this.pEstudiantes.Controls.Add(this.lCarrera);
            this.pEstudiantes.Controls.Add(this.label5);
            this.pEstudiantes.Controls.Add(this.mtLegajo);
            this.pEstudiantes.Location = new System.Drawing.Point(13, 178);
            this.pEstudiantes.Name = "pEstudiantes";
            this.pEstudiantes.Size = new System.Drawing.Size(240, 117);
            this.pEstudiantes.TabIndex = 1;
            this.pEstudiantes.Visible = false;
            // 
            // cbCarrera
            // 
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Items.AddRange(new object[] {
            "Contabilidad",
            "Derecho",
            "Informatica"});
            this.cbCarrera.Location = new System.Drawing.Point(95, 48);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(121, 21);
            this.cbCarrera.TabIndex = 3;
            // 
            // lCarrera
            // 
            this.lCarrera.AutoSize = true;
            this.lCarrera.Location = new System.Drawing.Point(40, 57);
            this.lCarrera.Name = "lCarrera";
            this.lCarrera.Size = new System.Drawing.Size(44, 13);
            this.lCarrera.TabIndex = 2;
            this.lCarrera.Text = "Carrera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Legajo:";
            // 
            // mtLegajo
            // 
            this.mtLegajo.Location = new System.Drawing.Point(95, 19);
            this.mtLegajo.Mask = "99999";
            this.mtLegajo.Name = "mtLegajo";
            this.mtLegajo.Size = new System.Drawing.Size(100, 20);
            this.mtLegajo.TabIndex = 0;
            this.mtLegajo.ValidatingType = typeof(int);
            // 
            // bMostrar
            // 
            this.bMostrar.Location = new System.Drawing.Point(22, 301);
            this.bMostrar.Name = "bMostrar";
            this.bMostrar.Size = new System.Drawing.Size(75, 23);
            this.bMostrar.TabIndex = 2;
            this.bMostrar.Text = "&Mostrar";
            this.bMostrar.UseVisualStyleBackColor = true;
            this.bMostrar.Click += new System.EventHandler(this.bMostrar_Click);
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(279, 301);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 3;
            this.bGuardar.Text = "&Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(580, 301);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 4;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // pListado
            // 
            this.pListado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pListado.Controls.Add(this.lCantidad);
            this.pListado.Controls.Add(this.lbPersonas);
            this.pListado.Controls.Add(this.cbFiltro);
            this.pListado.Controls.Add(this.label8);
            this.pListado.Location = new System.Drawing.Point(259, 13);
            this.pListado.Name = "pListado";
            this.pListado.Size = new System.Drawing.Size(396, 282);
            this.pListado.TabIndex = 5;
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(17, 256);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(52, 13);
            this.lCantidad.TabIndex = 3;
            this.lCantidad.Text = "Cantidad:";
            // 
            // lbPersonas
            // 
            this.lbPersonas.FormattingEnabled = true;
            this.lbPersonas.HorizontalExtent = 900;
            this.lbPersonas.HorizontalScrollbar = true;
            this.lbPersonas.Location = new System.Drawing.Point(20, 54);
            this.lbPersonas.Name = "lbPersonas";
            this.lbPersonas.ScrollAlwaysVisible = true;
            this.lbPersonas.Size = new System.Drawing.Size(363, 199);
            this.lbPersonas.TabIndex = 2;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "TODO",
            "PERSONAS",
            "ESTUDIANTES",
            "EMPLEADOS"});
            this.cbFiltro.Location = new System.Drawing.Point(20, 27);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 1;
            this.cbFiltro.SelectedIndexChanged += new System.EventHandler(this.cbFiltro_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Filtro";
            // 
            // epValidar
            // 
            this.epValidar.ContainerControl = this;
            // 
            // fPersonas
            // 
            this.AcceptButton = this.bGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(667, 331);
            this.Controls.Add(this.pListado);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.bMostrar);
            this.Controls.Add(this.pEstudiantes);
            this.Controls.Add(this.pPersonas);
            this.Name = "fPersonas";
            this.Text = "Personas";
            this.pPersonas.ResumeLayout(false);
            this.pPersonas.PerformLayout();
            this.pEstudiantes.ResumeLayout(false);
            this.pEstudiantes.PerformLayout();
            this.pListado.ResumeLayout(false);
            this.pListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epValidar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pPersonas;
        private System.Windows.Forms.DateTimePicker dtFechaNac;
        private System.Windows.Forms.MaskedTextBox mtDocumento;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pEstudiantes;
        private System.Windows.Forms.Label lCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtLegajo;
        private System.Windows.Forms.Button bMostrar;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Panel pListado;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.ListBox lbPersonas;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider epValidar;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.RadioButton rbEstudiante;
        private System.Windows.Forms.RadioButton rbPersona;
        private System.Windows.Forms.ComboBox cbCarrera;
    }
}

