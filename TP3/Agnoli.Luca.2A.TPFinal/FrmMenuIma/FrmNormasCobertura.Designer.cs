
namespace FrmMenuIma
{
    partial class FrmNormasCobertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNormasCobertura));
            this.pnlBotonesNormas = new System.Windows.Forms.Panel();
            this.btnInternacion = new System.Windows.Forms.Button();
            this.btnMedicamentos = new System.Windows.Forms.Button();
            this.btnAtencionMedicoAmbulatoria = new System.Windows.Forms.Button();
            this.btnOrientacion = new System.Windows.Forms.Button();
            this.btnSistemasAtencion = new System.Windows.Forms.Button();
            this.rtxDatosCobertura = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlBotonesNormas.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotonesNormas
            // 
            this.pnlBotonesNormas.BackColor = System.Drawing.Color.Navy;
            this.pnlBotonesNormas.Controls.Add(this.btnInternacion);
            this.pnlBotonesNormas.Controls.Add(this.btnMedicamentos);
            this.pnlBotonesNormas.Controls.Add(this.btnAtencionMedicoAmbulatoria);
            this.pnlBotonesNormas.Controls.Add(this.btnOrientacion);
            this.pnlBotonesNormas.Controls.Add(this.btnSistemasAtencion);
            this.pnlBotonesNormas.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBotonesNormas.Location = new System.Drawing.Point(0, 0);
            this.pnlBotonesNormas.Name = "pnlBotonesNormas";
            this.pnlBotonesNormas.Size = new System.Drawing.Size(168, 366);
            this.pnlBotonesNormas.TabIndex = 0;
            // 
            // btnInternacion
            // 
            this.btnInternacion.Location = new System.Drawing.Point(21, 294);
            this.btnInternacion.Name = "btnInternacion";
            this.btnInternacion.Size = new System.Drawing.Size(117, 53);
            this.btnInternacion.TabIndex = 8;
            this.btnInternacion.Text = "Internación";
            this.btnInternacion.UseVisualStyleBackColor = true;
            this.btnInternacion.Click += new System.EventHandler(this.btnInternacion_Click);
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.Location = new System.Drawing.Point(21, 226);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.Size = new System.Drawing.Size(117, 53);
            this.btnMedicamentos.TabIndex = 7;
            this.btnMedicamentos.Text = "Medicamentos";
            this.btnMedicamentos.UseVisualStyleBackColor = true;
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
            // 
            // btnAtencionMedicoAmbulatoria
            // 
            this.btnAtencionMedicoAmbulatoria.Location = new System.Drawing.Point(21, 153);
            this.btnAtencionMedicoAmbulatoria.Name = "btnAtencionMedicoAmbulatoria";
            this.btnAtencionMedicoAmbulatoria.Size = new System.Drawing.Size(117, 53);
            this.btnAtencionMedicoAmbulatoria.TabIndex = 6;
            this.btnAtencionMedicoAmbulatoria.Text = "Atención Médica Ambulatoria";
            this.btnAtencionMedicoAmbulatoria.UseVisualStyleBackColor = true;
            this.btnAtencionMedicoAmbulatoria.Click += new System.EventHandler(this.btnAtencionMedicoAmbulatoria_Click);
            // 
            // btnOrientacion
            // 
            this.btnOrientacion.Location = new System.Drawing.Point(21, 83);
            this.btnOrientacion.Name = "btnOrientacion";
            this.btnOrientacion.Size = new System.Drawing.Size(117, 53);
            this.btnOrientacion.TabIndex = 5;
            this.btnOrientacion.Text = "Orientacion";
            this.btnOrientacion.UseVisualStyleBackColor = true;
            this.btnOrientacion.Click += new System.EventHandler(this.btnOrientacion_Click);
            // 
            // btnSistemasAtencion
            // 
            this.btnSistemasAtencion.Location = new System.Drawing.Point(21, 12);
            this.btnSistemasAtencion.Name = "btnSistemasAtencion";
            this.btnSistemasAtencion.Size = new System.Drawing.Size(117, 53);
            this.btnSistemasAtencion.TabIndex = 0;
            this.btnSistemasAtencion.Text = "Sistemas de atención";
            this.btnSistemasAtencion.UseVisualStyleBackColor = true;
            this.btnSistemasAtencion.Click += new System.EventHandler(this.btnSistemasAtencion_Click);
            // 
            // rtxDatosCobertura
            // 
            this.rtxDatosCobertura.Location = new System.Drawing.Point(174, 67);
            this.rtxDatosCobertura.Name = "rtxDatosCobertura";
            this.rtxDatosCobertura.ReadOnly = true;
            this.rtxDatosCobertura.Size = new System.Drawing.Size(670, 289);
            this.rtxDatosCobertura.TabIndex = 1;
            this.rtxDatosCobertura.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Location = new System.Drawing.Point(166, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 61);
            this.panel1.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(112, 7);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 42);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir datos";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(302, 7);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 42);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(507, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmNormasCobertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(856, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxDatosCobertura);
            this.Controls.Add(this.pnlBotonesNormas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNormasCobertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Normas de cobertura";
            this.pnlBotonesNormas.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotonesNormas;
        private System.Windows.Forms.Button btnInternacion;
        private System.Windows.Forms.Button btnMedicamentos;
        private System.Windows.Forms.Button btnAtencionMedicoAmbulatoria;
        private System.Windows.Forms.Button btnOrientacion;
        private System.Windows.Forms.Button btnSistemasAtencion;
        private System.Windows.Forms.RichTextBox rtxDatosCobertura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}