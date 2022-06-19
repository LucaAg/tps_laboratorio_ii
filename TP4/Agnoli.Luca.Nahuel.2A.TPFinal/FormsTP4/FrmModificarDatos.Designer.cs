
namespace FormsTP4
{
    partial class FrmModificarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarDatos));
            this.btnSalir = new System.Windows.Forms.Button();
            this.brnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gpxPlanElegido = new System.Windows.Forms.GroupBox();
            this.rdbPlanPlus = new System.Windows.Forms.RadioButton();
            this.rdbPlanPremiun = new System.Windows.Forms.RadioButton();
            this.rdbPlanClasico = new System.Windows.Forms.RadioButton();
            this.gpxGenero = new System.Windows.Forms.GroupBox();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.pcbAltaCliente = new System.Windows.Forms.PictureBox();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefeno = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.gpxPlanElegido.SuspendLayout();
            this.gpxGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAltaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Location = new System.Drawing.Point(15, 282);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 32);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // brnLimpiarDatos
            // 
            this.brnLimpiarDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.brnLimpiarDatos.Location = new System.Drawing.Point(15, 152);
            this.brnLimpiarDatos.Name = "brnLimpiarDatos";
            this.brnLimpiarDatos.Size = new System.Drawing.Size(89, 34);
            this.brnLimpiarDatos.TabIndex = 41;
            this.brnLimpiarDatos.Text = "Limpiar datos";
            this.brnLimpiarDatos.UseVisualStyleBackColor = false;
            this.brnLimpiarDatos.Click += new System.EventHandler(this.brnLimpiarDatos_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmar.Location = new System.Drawing.Point(16, 42);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(91, 34);
            this.btnConfirmar.TabIndex = 40;
            this.btnConfirmar.Text = "Cargar datos";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gpxPlanElegido
            // 
            this.gpxPlanElegido.Controls.Add(this.rdbPlanPlus);
            this.gpxPlanElegido.Controls.Add(this.rdbPlanPremiun);
            this.gpxPlanElegido.Controls.Add(this.rdbPlanClasico);
            this.gpxPlanElegido.Location = new System.Drawing.Point(314, 248);
            this.gpxPlanElegido.Name = "gpxPlanElegido";
            this.gpxPlanElegido.Size = new System.Drawing.Size(200, 100);
            this.gpxPlanElegido.TabIndex = 39;
            this.gpxPlanElegido.TabStop = false;
            this.gpxPlanElegido.Text = "Plan elegido";
            // 
            // rdbPlanPlus
            // 
            this.rdbPlanPlus.AutoSize = true;
            this.rdbPlanPlus.Location = new System.Drawing.Point(43, 47);
            this.rdbPlanPlus.Name = "rdbPlanPlus";
            this.rdbPlanPlus.Size = new System.Drawing.Size(73, 19);
            this.rdbPlanPlus.TabIndex = 22;
            this.rdbPlanPlus.Text = "Plan Plus";
            this.rdbPlanPlus.UseVisualStyleBackColor = true;
            // 
            // rdbPlanPremiun
            // 
            this.rdbPlanPremiun.AutoSize = true;
            this.rdbPlanPremiun.Location = new System.Drawing.Point(43, 72);
            this.rdbPlanPremiun.Name = "rdbPlanPremiun";
            this.rdbPlanPremiun.Size = new System.Drawing.Size(96, 19);
            this.rdbPlanPremiun.TabIndex = 23;
            this.rdbPlanPremiun.Text = "Plan Premiun";
            this.rdbPlanPremiun.UseVisualStyleBackColor = true;
            // 
            // rdbPlanClasico
            // 
            this.rdbPlanClasico.AutoSize = true;
            this.rdbPlanClasico.Checked = true;
            this.rdbPlanClasico.Location = new System.Drawing.Point(43, 21);
            this.rdbPlanClasico.Name = "rdbPlanClasico";
            this.rdbPlanClasico.Size = new System.Drawing.Size(89, 19);
            this.rdbPlanClasico.TabIndex = 21;
            this.rdbPlanClasico.TabStop = true;
            this.rdbPlanClasico.Text = "Plan Clasico";
            this.rdbPlanClasico.UseVisualStyleBackColor = true;
            // 
            // gpxGenero
            // 
            this.gpxGenero.Controls.Add(this.rdbNoBinario);
            this.gpxGenero.Controls.Add(this.rdbMasculino);
            this.gpxGenero.Controls.Add(this.rdbFemenino);
            this.gpxGenero.Location = new System.Drawing.Point(314, 111);
            this.gpxGenero.Name = "gpxGenero";
            this.gpxGenero.Size = new System.Drawing.Size(200, 100);
            this.gpxGenero.TabIndex = 35;
            this.gpxGenero.TabStop = false;
            this.gpxGenero.Text = "Genero";
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Location = new System.Drawing.Point(17, 75);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdbNoBinario.TabIndex = 10;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Checked = true;
            this.rdbMasculino.Location = new System.Drawing.Point(17, 25);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(80, 19);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(17, 50);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(78, 19);
            this.rdbFemenino.TabIndex = 9;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // pcbAltaCliente
            // 
            this.pcbAltaCliente.Image = ((System.Drawing.Image)(resources.GetObject("pcbAltaCliente.Image")));
            this.pcbAltaCliente.Location = new System.Drawing.Point(314, 12);
            this.pcbAltaCliente.Name = "pcbAltaCliente";
            this.pcbAltaCliente.Size = new System.Drawing.Size(141, 72);
            this.pcbAltaCliente.TabIndex = 38;
            this.pcbAltaCliente.TabStop = false;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(108, 160);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 23);
            this.nudEdad.TabIndex = 32;
            this.nudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lblDni);
            this.panel1.Controls.Add(this.lblGrupoSanguineo);
            this.panel1.Controls.Add(this.lblNacimiento);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblTelefeno);
            this.panel1.Controls.Add(this.lblEdad);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(89, 369);
            this.panel1.TabIndex = 37;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(3, 24);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 15);
            this.lblDni.TabIndex = 28;
            this.lblDni.Text = "DNI:";
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(3, 320);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(85, 15);
            this.lblGrupoSanguineo.TabIndex = 46;
            this.lblGrupoSanguineo.Text = "Factor sangre:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNacimiento.Location = new System.Drawing.Point(3, 123);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(74, 15);
            this.lblNacimiento.TabIndex = 31;
            this.lblNacimiento.Text = "Nacimiento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(3, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTelefeno
            // 
            this.lblTelefeno.AutoSize = true;
            this.lblTelefeno.Location = new System.Drawing.Point(3, 272);
            this.lblTelefeno.Name = "lblTelefeno";
            this.lblTelefeno.Size = new System.Drawing.Size(59, 15);
            this.lblTelefeno.TabIndex = 34;
            this.lblTelefeno.Text = "Telefono:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(3, 163);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 32;
            this.lblEdad.Text = "Edad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Apellido:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(3, 202);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 15);
            this.lblDireccion.TabIndex = 33;
            this.lblDireccion.Text = "Direccion:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(108, 123);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(100, 23);
            this.dtpFechaNacimiento.TabIndex = 31;
            this.dtpFechaNacimiento.Value = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(108, 272);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 23);
            this.txtTelefono.TabIndex = 34;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(108, 202);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(180, 50);
            this.txtDireccion.TabIndex = 33;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(108, 90);
            this.txtApellido.MaxLength = 30;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 23);
            this.txtApellido.TabIndex = 30;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 53);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 23);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(108, 21);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(81, 23);
            this.txtDni.TabIndex = 28;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.brnLimpiarDatos);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(537, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(119, 369);
            this.panel2.TabIndex = 43;
            // 
            // cmbGrupoSanguineo
            // 
            this.cmbGrupoSanguineo.FormattingEnabled = true;
            this.cmbGrupoSanguineo.Items.AddRange(new object[] {
            "0 Negativo",
            "0 Positivo",
            "A Negativo",
            "A Positivo",
            "B Negativo",
            "B Positivo",
            "AB Negativo",
            "AB Positivo"});
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(108, 319);
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(121, 23);
            this.cmbGrupoSanguineo.TabIndex = 44;
            this.cmbGrupoSanguineo.Text = "Tipo de sangre";
            // 
            // FrmModificarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 369);
            this.Controls.Add(this.cmbGrupoSanguineo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gpxPlanElegido);
            this.Controls.Add(this.pcbAltaCliente);
            this.Controls.Add(this.gpxGenero);
            this.Controls.Add(this.nudEdad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmModificarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar datos";
            this.Load += new System.EventHandler(this.frmModificarDatos_Load);
            this.gpxPlanElegido.ResumeLayout(false);
            this.gpxPlanElegido.PerformLayout();
            this.gpxGenero.ResumeLayout(false);
            this.gpxGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAltaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button brnLimpiarDatos;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.GroupBox gpxPlanElegido;
        private System.Windows.Forms.RadioButton rdbPlanPlus;
        private System.Windows.Forms.RadioButton rdbPlanPremiun;
        private System.Windows.Forms.RadioButton rdbPlanClasico;
        private System.Windows.Forms.GroupBox gpxGenero;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.PictureBox pcbAltaCliente;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefeno;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.ComboBox cmbGrupoSanguineo;
    }
}