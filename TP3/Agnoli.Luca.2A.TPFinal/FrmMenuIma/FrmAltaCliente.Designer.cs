
namespace FrmMenuIma
{
    partial class FrmAltaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltaCliente));
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefeno = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.gpxGenero = new System.Windows.Forms.GroupBox();
            this.gpxPlanElegido = new System.Windows.Forms.GroupBox();
            this.rdbPlanPlus = new System.Windows.Forms.RadioButton();
            this.rdbPlanPremiun = new System.Windows.Forms.RadioButton();
            this.rdbPlanClasico = new System.Windows.Forms.RadioButton();
            this.btnDarAlta = new System.Windows.Forms.Button();
            this.brnLimpiarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rtxDatosPlan = new System.Windows.Forms.RichTextBox();
            this.cmbGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.lblDatosPlan = new System.Windows.Forms.Label();
            this.lblDatoSangre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.gpxGenero.SuspendLayout();
            this.gpxPlanElegido.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(12, 29);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(32, 15);
            this.lblDni.TabIndex = 28;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(104, 21);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(81, 23);
            this.txtDni.TabIndex = 0;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.Location = new System.Drawing.Point(12, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 15);
            this.lblNombre.TabIndex = 29;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 55);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(104, 95);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 23);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Apellido:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(104, 217);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(180, 50);
            this.txtDireccion.TabIndex = 5;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(12, 217);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(63, 15);
            this.lblDireccion.TabIndex = 33;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(104, 285);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 23);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefeno
            // 
            this.lblTelefeno.AutoSize = true;
            this.lblTelefeno.Location = new System.Drawing.Point(9, 285);
            this.lblTelefeno.Name = "lblTelefeno";
            this.lblTelefeno.Size = new System.Drawing.Size(59, 15);
            this.lblTelefeno.TabIndex = 34;
            this.lblTelefeno.Text = "Telefono:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 174);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(36, 15);
            this.lblEdad.TabIndex = 32;
            this.lblEdad.Text = "Edad:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(104, 133);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(100, 23);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.Value = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNacimiento.Location = new System.Drawing.Point(9, 133);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(74, 15);
            this.lblNacimiento.TabIndex = 31;
            this.lblNacimiento.Text = "Nacimiento:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lblGrupoSanguineo);
            this.panel1.Controls.Add(this.lblDni);
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
            this.panel1.Size = new System.Drawing.Size(98, 397);
            this.panel1.TabIndex = 14;
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(9, 330);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(85, 15);
            this.lblGrupoSanguineo.TabIndex = 35;
            this.lblGrupoSanguineo.Text = "Factor sangre:";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(104, 174);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 23);
            this.nudEdad.TabIndex = 4;
            this.nudEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // gpxGenero
            // 
            this.gpxGenero.Controls.Add(this.rdbNoBinario);
            this.gpxGenero.Controls.Add(this.rdbMasculino);
            this.gpxGenero.Controls.Add(this.rdbFemenino);
            this.gpxGenero.Location = new System.Drawing.Point(299, 132);
            this.gpxGenero.Name = "gpxGenero";
            this.gpxGenero.Size = new System.Drawing.Size(200, 100);
            this.gpxGenero.TabIndex = 7;
            this.gpxGenero.TabStop = false;
            this.gpxGenero.Text = "Genero";
            // 
            // gpxPlanElegido
            // 
            this.gpxPlanElegido.Controls.Add(this.rdbPlanPlus);
            this.gpxPlanElegido.Controls.Add(this.rdbPlanPremiun);
            this.gpxPlanElegido.Controls.Add(this.rdbPlanClasico);
            this.gpxPlanElegido.Location = new System.Drawing.Point(299, 244);
            this.gpxPlanElegido.Name = "gpxPlanElegido";
            this.gpxPlanElegido.Size = new System.Drawing.Size(200, 100);
            this.gpxPlanElegido.TabIndex = 20;
            this.gpxPlanElegido.TabStop = false;
            this.gpxPlanElegido.Text = "Plan elegido";
            // 
            // rdbPlanPlus
            // 
            this.rdbPlanPlus.AutoSize = true;
            this.rdbPlanPlus.Location = new System.Drawing.Point(43, 46);
            this.rdbPlanPlus.Name = "rdbPlanPlus";
            this.rdbPlanPlus.Size = new System.Drawing.Size(73, 19);
            this.rdbPlanPlus.TabIndex = 22;
            this.rdbPlanPlus.Text = "Plan Plus";
            this.rdbPlanPlus.UseVisualStyleBackColor = true;
            this.rdbPlanPlus.CheckedChanged += new System.EventHandler(this.rdbPlanPlus_CheckedChanged);
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
            this.rdbPlanPremiun.CheckedChanged += new System.EventHandler(this.rdbPlanPremiun_CheckedChanged);
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
            // btnDarAlta
            // 
            this.btnDarAlta.Location = new System.Drawing.Point(43, 17);
            this.btnDarAlta.Name = "btnDarAlta";
            this.btnDarAlta.Size = new System.Drawing.Size(96, 34);
            this.btnDarAlta.TabIndex = 24;
            this.btnDarAlta.Text = "Cargar datos";
            this.btnDarAlta.UseVisualStyleBackColor = true;
            this.btnDarAlta.Click += new System.EventHandler(this.btnDarAlta_Click);
            // 
            // brnLimpiarDatos
            // 
            this.brnLimpiarDatos.Location = new System.Drawing.Point(43, 64);
            this.brnLimpiarDatos.Name = "brnLimpiarDatos";
            this.brnLimpiarDatos.Size = new System.Drawing.Size(96, 34);
            this.brnLimpiarDatos.TabIndex = 25;
            this.brnLimpiarDatos.Text = "Limpiar datos";
            this.brnLimpiarDatos.UseVisualStyleBackColor = true;
            this.brnLimpiarDatos.Click += new System.EventHandler(this.brnLimpiarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(43, 112);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 32);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // rtxDatosPlan
            // 
            this.rtxDatosPlan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rtxDatosPlan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtxDatosPlan.Location = new System.Drawing.Point(516, 191);
            this.rtxDatosPlan.Name = "rtxDatosPlan";
            this.rtxDatosPlan.ReadOnly = true;
            this.rtxDatosPlan.Size = new System.Drawing.Size(190, 199);
            this.rtxDatosPlan.TabIndex = 27;
            this.rtxDatosPlan.Text = "";
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
            this.cmbGrupoSanguineo.Location = new System.Drawing.Point(104, 327);
            this.cmbGrupoSanguineo.Name = "cmbGrupoSanguineo";
            this.cmbGrupoSanguineo.Size = new System.Drawing.Size(121, 23);
            this.cmbGrupoSanguineo.TabIndex = 28;
            this.cmbGrupoSanguineo.Text = "Tipo de sangre";
            // 
            // lblDatosPlan
            // 
            this.lblDatosPlan.AutoSize = true;
            this.lblDatosPlan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDatosPlan.Location = new System.Drawing.Point(516, 169);
            this.lblDatosPlan.Name = "lblDatosPlan";
            this.lblDatosPlan.Size = new System.Drawing.Size(100, 19);
            this.lblDatosPlan.TabIndex = 29;
            this.lblDatosPlan.Text = "Datos del plan:";
            // 
            // lblDatoSangre
            // 
            this.lblDatoSangre.AutoSize = true;
            this.lblDatoSangre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDatoSangre.Location = new System.Drawing.Point(104, 362);
            this.lblDatoSangre.Name = "lblDatoSangre";
            this.lblDatoSangre.Size = new System.Drawing.Size(308, 15);
            this.lblDatoSangre.TabIndex = 30;
            this.lblDatoSangre.Text = "*Si no selecciona un tipo, se asigna por defecto 0 negativo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnDarAlta);
            this.panel2.Controls.Add(this.brnLimpiarDatos);
            this.panel2.Location = new System.Drawing.Point(516, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 159);
            this.panel2.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 72);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAltaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 397);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblDatoSangre);
            this.Controls.Add(this.lblDatosPlan);
            this.Controls.Add(this.cmbGrupoSanguineo);
            this.Controls.Add(this.rtxDatosPlan);
            this.Controls.Add(this.gpxPlanElegido);
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
            this.Name = "FrmAltaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmAltaCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.gpxGenero.ResumeLayout(false);
            this.gpxGenero.PerformLayout();
            this.gpxPlanElegido.ResumeLayout(false);
            this.gpxPlanElegido.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefeno;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.GroupBox gpxGenero;
        private System.Windows.Forms.GroupBox gpxPlanElegido;
        private System.Windows.Forms.RadioButton rdbPlanPlus;
        private System.Windows.Forms.RadioButton rdbPlanPremiun;
        private System.Windows.Forms.RadioButton rdbPlanClasico;
        private System.Windows.Forms.Button btnDarAlta;
        private System.Windows.Forms.Button brnLimpiarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.RichTextBox rtxDatosPlan;
        private System.Windows.Forms.ComboBox cmbGrupoSanguineo;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.Label lblDatosPlan;
        private System.Windows.Forms.Label lblDatoSangre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}