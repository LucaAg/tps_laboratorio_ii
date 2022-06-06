
namespace FrmMenuIma
{
    partial class FrmClientesActivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesActivos));
            this.rtbClientesActivos = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtFiltrarDni = new System.Windows.Forms.TextBox();
            this.btnOrdenarPorDni = new System.Windows.Forms.Button();
            this.btnOrdenarPorApellido = new System.Windows.Forms.Button();
            this.btnBuscarPorDni = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbClientesActivos
            // 
            this.rtbClientesActivos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rtbClientesActivos.Dock = System.Windows.Forms.DockStyle.Left;
            this.rtbClientesActivos.Location = new System.Drawing.Point(0, 0);
            this.rtbClientesActivos.Name = "rtbClientesActivos";
            this.rtbClientesActivos.ReadOnly = true;
            this.rtbClientesActivos.Size = new System.Drawing.Size(329, 428);
            this.rtbClientesActivos.TabIndex = 0;
            this.rtbClientesActivos.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.txtFiltrarDni);
            this.panel1.Controls.Add(this.btnOrdenarPorDni);
            this.panel1.Controls.Add(this.btnOrdenarPorApellido);
            this.panel1.Controls.Add(this.btnBuscarPorDni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(329, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 428);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 56);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtFiltrarDni
            // 
            this.txtFiltrarDni.Location = new System.Drawing.Point(3, 94);
            this.txtFiltrarDni.MaxLength = 8;
            this.txtFiltrarDni.Name = "txtFiltrarDni";
            this.txtFiltrarDni.PlaceholderText = "Ingrese DNI a buscar";
            this.txtFiltrarDni.Size = new System.Drawing.Size(116, 23);
            this.txtFiltrarDni.TabIndex = 3;
            // 
            // btnOrdenarPorDni
            // 
            this.btnOrdenarPorDni.Location = new System.Drawing.Point(15, 244);
            this.btnOrdenarPorDni.Name = "btnOrdenarPorDni";
            this.btnOrdenarPorDni.Size = new System.Drawing.Size(92, 56);
            this.btnOrdenarPorDni.TabIndex = 2;
            this.btnOrdenarPorDni.Text = "Ordenar por DNI";
            this.btnOrdenarPorDni.UseVisualStyleBackColor = true;
            this.btnOrdenarPorDni.Click += new System.EventHandler(this.btnOrdenarPorDni_Click);
            // 
            // btnOrdenarPorApellido
            // 
            this.btnOrdenarPorApellido.Location = new System.Drawing.Point(15, 153);
            this.btnOrdenarPorApellido.Name = "btnOrdenarPorApellido";
            this.btnOrdenarPorApellido.Size = new System.Drawing.Size(92, 56);
            this.btnOrdenarPorApellido.TabIndex = 1;
            this.btnOrdenarPorApellido.Text = "Ordenar por Apellido";
            this.btnOrdenarPorApellido.UseVisualStyleBackColor = true;
            this.btnOrdenarPorApellido.Click += new System.EventHandler(this.btnOrdenarPorApellido_Click);
            // 
            // btnBuscarPorDni
            // 
            this.btnBuscarPorDni.Location = new System.Drawing.Point(15, 23);
            this.btnBuscarPorDni.Name = "btnBuscarPorDni";
            this.btnBuscarPorDni.Size = new System.Drawing.Size(92, 56);
            this.btnBuscarPorDni.TabIndex = 0;
            this.btnBuscarPorDni.Text = "Filtrar por DNI";
            this.btnBuscarPorDni.UseVisualStyleBackColor = true;
            this.btnBuscarPorDni.Click += new System.EventHandler(this.btnBuscarPorDni_Click);
            // 
            // FrmClientesActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 428);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtbClientesActivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientesActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes activos";
            this.Load += new System.EventHandler(this.frmClientesActivos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbClientesActivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrdenarPorDni;
        private System.Windows.Forms.Button btnOrdenarPorApellido;
        private System.Windows.Forms.Button btnBuscarPorDni;
        private System.Windows.Forms.TextBox txtFiltrarDni;
        private System.Windows.Forms.Button btnSalir;
    }
}