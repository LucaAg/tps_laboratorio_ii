
namespace FormsTP4
{
    partial class FrmSucursales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSucursales));
            this.lblSucursales = new System.Windows.Forms.Label();
            this.lblDatosSucursales = new System.Windows.Forms.Label();
            this.btnFiltrarId = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarSucursales = new System.Windows.Forms.Button();
            this.btnAgregarSucursal = new System.Windows.Forms.Button();
            this.dgvSucursales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSucursales
            // 
            this.lblSucursales.AutoSize = true;
            this.lblSucursales.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSucursales.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSucursales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSucursales.Location = new System.Drawing.Point(161, 28);
            this.lblSucursales.Name = "lblSucursales";
            this.lblSucursales.Size = new System.Drawing.Size(209, 28);
            this.lblSucursales.TabIndex = 0;
            this.lblSucursales.Text = "Sucursales adheridas";
            // 
            // lblDatosSucursales
            // 
            this.lblDatosSucursales.AutoSize = true;
            this.lblDatosSucursales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblDatosSucursales.Location = new System.Drawing.Point(36, 70);
            this.lblDatosSucursales.Name = "lblDatosSucursales";
            this.lblDatosSucursales.Size = new System.Drawing.Size(127, 21);
            this.lblDatosSucursales.TabIndex = 4;
            this.lblDatosSucursales.Text = "Datos sucursales:";
            // 
            // btnFiltrarId
            // 
            this.btnFiltrarId.Location = new System.Drawing.Point(527, 214);
            this.btnFiltrarId.Name = "btnFiltrarId";
            this.btnFiltrarId.Size = new System.Drawing.Size(121, 23);
            this.btnFiltrarId.TabIndex = 7;
            this.btnFiltrarId.Text = "Filtrar ID";
            this.btnFiltrarId.UseVisualStyleBackColor = true;
            this.btnFiltrarId.Click += new System.EventHandler(this.btnFiltrarId_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(527, 268);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMostrarSucursales
            // 
            this.btnMostrarSucursales.Location = new System.Drawing.Point(527, 104);
            this.btnMostrarSucursales.Name = "btnMostrarSucursales";
            this.btnMostrarSucursales.Size = new System.Drawing.Size(121, 43);
            this.btnMostrarSucursales.TabIndex = 9;
            this.btnMostrarSucursales.Text = "Mostrar/Actualizar sucursales";
            this.btnMostrarSucursales.UseVisualStyleBackColor = true;
            this.btnMostrarSucursales.Click += new System.EventHandler(this.btnMostrarSucursales_Click);
            // 
            // btnAgregarSucursal
            // 
            this.btnAgregarSucursal.Location = new System.Drawing.Point(527, 167);
            this.btnAgregarSucursal.Name = "btnAgregarSucursal";
            this.btnAgregarSucursal.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarSucursal.TabIndex = 10;
            this.btnAgregarSucursal.Text = "Agregar sucursal";
            this.btnAgregarSucursal.UseVisualStyleBackColor = true;
            this.btnAgregarSucursal.Click += new System.EventHandler(this.btnAgregarSucursal_Click);
            // 
            // dgvSucursales
            // 
            this.dgvSucursales.AllowUserToAddRows = false;
            this.dgvSucursales.AllowUserToDeleteRows = false;
            this.dgvSucursales.AllowUserToResizeColumns = false;
            this.dgvSucursales.AllowUserToResizeRows = false;
            this.dgvSucursales.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSucursales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSucursales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSucursales.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dgvSucursales.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSucursales.Location = new System.Drawing.Point(36, 104);
            this.dgvSucursales.Name = "dgvSucursales";
            this.dgvSucursales.RowTemplate.Height = 25;
            this.dgvSucursales.Size = new System.Drawing.Size(459, 187);
            this.dgvSucursales.TabIndex = 11;
            // 
            // FrmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 332);
            this.Controls.Add(this.dgvSucursales);
            this.Controls.Add(this.btnAgregarSucursal);
            this.Controls.Add(this.btnMostrarSucursales);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFiltrarId);
            this.Controls.Add(this.lblDatosSucursales);
            this.Controls.Add(this.lblSucursales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.frmSucursales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSucursales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucursales;
        private System.Windows.Forms.Label lblDatosSucursales;
        private System.Windows.Forms.Button btnFiltrarId;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarSucursales;
        private System.Windows.Forms.Button btnAgregarSucursal;
        private System.Windows.Forms.DataGridView dgvSucursales;
    }
}