
namespace FrmMenuIma
{
    partial class FrmMenuIma
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuIma));
            this.btnInfoIMA = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnCobertura = new System.Windows.Forms.Button();
            this.btnContacto = new System.Windows.Forms.Button();
            this.gbxDatosParaCliente = new System.Windows.Forms.GroupBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnMostrarClientesActivos = new System.Windows.Forms.Button();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarDatosUsuario = new System.Windows.Forms.Button();
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.gbxAccionesAlUsuario = new System.Windows.Forms.GroupBox();
            this.pcbContactos = new System.Windows.Forms.PictureBox();
            this.pnlAzul = new System.Windows.Forms.Panel();
            this.pcbProcoloCovid = new System.Windows.Forms.PictureBox();
            this.gbxDatosParaCliente.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxAccionesAlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbContactos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProcoloCovid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfoIMA
            // 
            this.btnInfoIMA.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInfoIMA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfoIMA.Location = new System.Drawing.Point(49, 28);
            this.btnInfoIMA.Name = "btnInfoIMA";
            this.btnInfoIMA.Size = new System.Drawing.Size(116, 49);
            this.btnInfoIMA.TabIndex = 1;
            this.btnInfoIMA.Text = "Acerca de IMA";
            this.btnInfoIMA.UseVisualStyleBackColor = false;
            this.btnInfoIMA.Click += new System.EventHandler(this.btnInfoIMA_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPlanes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlanes.Location = new System.Drawing.Point(231, 28);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(116, 49);
            this.btnPlanes.TabIndex = 2;
            this.btnPlanes.Text = "Planes";
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnCobertura
            // 
            this.btnCobertura.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCobertura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCobertura.Location = new System.Drawing.Point(417, 28);
            this.btnCobertura.Name = "btnCobertura";
            this.btnCobertura.Size = new System.Drawing.Size(116, 49);
            this.btnCobertura.TabIndex = 3;
            this.btnCobertura.Text = "Normas de cobertura";
            this.btnCobertura.UseVisualStyleBackColor = false;
            this.btnCobertura.Click += new System.EventHandler(this.btnCobertura_Click);
            // 
            // btnContacto
            // 
            this.btnContacto.BackColor = System.Drawing.Color.SkyBlue;
            this.btnContacto.Location = new System.Drawing.Point(6, 222);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(254, 37);
            this.btnContacto.TabIndex = 4;
            this.btnContacto.Text = "Acceder a contactos";
            this.btnContacto.UseVisualStyleBackColor = false;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // gbxDatosParaCliente
            // 
            this.gbxDatosParaCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.gbxDatosParaCliente.Controls.Add(this.btnInfoIMA);
            this.gbxDatosParaCliente.Controls.Add(this.btnPlanes);
            this.gbxDatosParaCliente.Controls.Add(this.btnCobertura);
            this.gbxDatosParaCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxDatosParaCliente.Location = new System.Drawing.Point(217, 40);
            this.gbxDatosParaCliente.Name = "gbxDatosParaCliente";
            this.gbxDatosParaCliente.Size = new System.Drawing.Size(591, 93);
            this.gbxDatosParaCliente.TabIndex = 5;
            this.gbxDatosParaCliente.TabStop = false;
            this.gbxDatosParaCliente.Text = "Datos para el usuario";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panelPrincipal.Controls.Add(this.btnMostrarClientesActivos);
            this.panelPrincipal.Controls.Add(this.btnBajaUsuario);
            this.panelPrincipal.Controls.Add(this.pictureBox1);
            this.panelPrincipal.Controls.Add(this.btnModificarDatosUsuario);
            this.panelPrincipal.Controls.Add(this.btnAltaUsuario);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(219, 416);
            this.panelPrincipal.TabIndex = 12;
            // 
            // btnMostrarClientesActivos
            // 
            this.btnMostrarClientesActivos.BackColor = System.Drawing.Color.SkyBlue;
            this.btnMostrarClientesActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarClientesActivos.Location = new System.Drawing.Point(33, 346);
            this.btnMostrarClientesActivos.Name = "btnMostrarClientesActivos";
            this.btnMostrarClientesActivos.Size = new System.Drawing.Size(134, 49);
            this.btnMostrarClientesActivos.TabIndex = 16;
            this.btnMostrarClientesActivos.Text = "Clientes activos";
            this.btnMostrarClientesActivos.UseVisualStyleBackColor = false;
            this.btnMostrarClientesActivos.Click += new System.EventHandler(this.btnMostrarClientesActivos_Click);
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBajaUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBajaUsuario.Location = new System.Drawing.Point(33, 269);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(134, 49);
            this.btnBajaUsuario.TabIndex = 14;
            this.btnBajaUsuario.Text = "Baja usuario";
            this.btnBajaUsuario.UseVisualStyleBackColor = false;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 93);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificarDatosUsuario
            // 
            this.btnModificarDatosUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.btnModificarDatosUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificarDatosUsuario.Location = new System.Drawing.Point(33, 193);
            this.btnModificarDatosUsuario.Name = "btnModificarDatosUsuario";
            this.btnModificarDatosUsuario.Size = new System.Drawing.Size(134, 51);
            this.btnModificarDatosUsuario.TabIndex = 15;
            this.btnModificarDatosUsuario.Text = "Modificar datos ";
            this.btnModificarDatosUsuario.UseVisualStyleBackColor = false;
            this.btnModificarDatosUsuario.Click += new System.EventHandler(this.btnModificarDatosUsuario_Click);
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAltaUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAltaUsuario.Location = new System.Drawing.Point(33, 116);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(134, 51);
            this.btnAltaUsuario.TabIndex = 13;
            this.btnAltaUsuario.Text = "Alta usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = false;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // gbxAccionesAlUsuario
            // 
            this.gbxAccionesAlUsuario.Controls.Add(this.pcbContactos);
            this.gbxAccionesAlUsuario.Controls.Add(this.btnContacto);
            this.gbxAccionesAlUsuario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxAccionesAlUsuario.Location = new System.Drawing.Point(253, 139);
            this.gbxAccionesAlUsuario.Name = "gbxAccionesAlUsuario";
            this.gbxAccionesAlUsuario.Size = new System.Drawing.Size(268, 265);
            this.gbxAccionesAlUsuario.TabIndex = 11;
            this.gbxAccionesAlUsuario.TabStop = false;
            this.gbxAccionesAlUsuario.Text = "Contactos";
            // 
            // pcbContactos
            // 
            this.pcbContactos.Image = ((System.Drawing.Image)(resources.GetObject("pcbContactos.Image")));
            this.pcbContactos.Location = new System.Drawing.Point(6, 30);
            this.pcbContactos.Name = "pcbContactos";
            this.pcbContactos.Size = new System.Drawing.Size(252, 186);
            this.pcbContactos.TabIndex = 0;
            this.pcbContactos.TabStop = false;
            // 
            // pnlAzul
            // 
            this.pnlAzul.BackColor = System.Drawing.Color.Navy;
            this.pnlAzul.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAzul.Location = new System.Drawing.Point(219, 0);
            this.pnlAzul.Name = "pnlAzul";
            this.pnlAzul.Size = new System.Drawing.Size(587, 40);
            this.pnlAzul.TabIndex = 13;
            // 
            // pcbProcoloCovid
            // 
            this.pcbProcoloCovid.Image = ((System.Drawing.Image)(resources.GetObject("pcbProcoloCovid.Image")));
            this.pcbProcoloCovid.Location = new System.Drawing.Point(558, 152);
            this.pcbProcoloCovid.Name = "pcbProcoloCovid";
            this.pcbProcoloCovid.Size = new System.Drawing.Size(226, 252);
            this.pcbProcoloCovid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProcoloCovid.TabIndex = 14;
            this.pcbProcoloCovid.TabStop = false;
            // 
            // FrmMenuIma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 416);
            this.Controls.Add(this.pcbProcoloCovid);
            this.Controls.Add(this.pnlAzul);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.gbxDatosParaCliente);
            this.Controls.Add(this.gbxAccionesAlUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuIma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMA";
            this.Load += new System.EventHandler(this.MenuIma_Load);
            this.gbxDatosParaCliente.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxAccionesAlUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbContactos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProcoloCovid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInfoIMA;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnContacto;
        private System.Windows.Forms.GroupBox gbxDatosParaCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxAccionesAlUsuario;
        private System.Windows.Forms.Button btnBajaUsuario;
        private System.Windows.Forms.PictureBox pcbContactos;
        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.Button btnModificarDatosUsuario;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel pnlAzul;
        private System.Windows.Forms.Button btnMostrarClientesActivos;
        private System.Windows.Forms.PictureBox pcbProcoloCovid;
        private System.Windows.Forms.Button btnCobertura;
    }
}

