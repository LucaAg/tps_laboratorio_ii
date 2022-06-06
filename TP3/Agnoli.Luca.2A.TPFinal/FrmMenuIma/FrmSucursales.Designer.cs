
namespace FrmMenuIma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSucursales));
            this.lblSucursales = new System.Windows.Forms.Label();
            this.rtxBernal = new System.Windows.Forms.RichTextBox();
            this.rtxBerazategui = new System.Windows.Forms.RichTextBox();
            this.rtxAvellaneda = new System.Windows.Forms.RichTextBox();
            this.lblAvellaneda = new System.Windows.Forms.Label();
            this.lblBernal = new System.Windows.Forms.Label();
            this.lblBerazategui = new System.Windows.Forms.Label();
            this.btnImprimirDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSucursales
            // 
            this.lblSucursales.AutoSize = true;
            this.lblSucursales.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblSucursales.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSucursales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSucursales.Location = new System.Drawing.Point(161, 20);
            this.lblSucursales.Name = "lblSucursales";
            this.lblSucursales.Size = new System.Drawing.Size(209, 28);
            this.lblSucursales.TabIndex = 0;
            this.lblSucursales.Text = "Sucursales adheridas";
            // 
            // rtxBernal
            // 
            this.rtxBernal.Location = new System.Drawing.Point(189, 93);
            this.rtxBernal.Name = "rtxBernal";
            this.rtxBernal.ReadOnly = true;
            this.rtxBernal.Size = new System.Drawing.Size(151, 215);
            this.rtxBernal.TabIndex = 1;
            this.rtxBernal.Text = "";
            // 
            // rtxBerazategui
            // 
            this.rtxBerazategui.Location = new System.Drawing.Point(374, 94);
            this.rtxBerazategui.Name = "rtxBerazategui";
            this.rtxBerazategui.ReadOnly = true;
            this.rtxBerazategui.Size = new System.Drawing.Size(151, 215);
            this.rtxBerazategui.TabIndex = 2;
            this.rtxBerazategui.Text = "";
            // 
            // rtxAvellaneda
            // 
            this.rtxAvellaneda.Location = new System.Drawing.Point(12, 94);
            this.rtxAvellaneda.Name = "rtxAvellaneda";
            this.rtxAvellaneda.ReadOnly = true;
            this.rtxAvellaneda.Size = new System.Drawing.Size(151, 215);
            this.rtxAvellaneda.TabIndex = 3;
            this.rtxAvellaneda.Text = "";
            // 
            // lblAvellaneda
            // 
            this.lblAvellaneda.AutoSize = true;
            this.lblAvellaneda.Location = new System.Drawing.Point(12, 76);
            this.lblAvellaneda.Name = "lblAvellaneda";
            this.lblAvellaneda.Size = new System.Drawing.Size(65, 15);
            this.lblAvellaneda.TabIndex = 4;
            this.lblAvellaneda.Text = "Avellaneda";
            // 
            // lblBernal
            // 
            this.lblBernal.AutoSize = true;
            this.lblBernal.Location = new System.Drawing.Point(194, 76);
            this.lblBernal.Name = "lblBernal";
            this.lblBernal.Size = new System.Drawing.Size(40, 15);
            this.lblBernal.TabIndex = 5;
            this.lblBernal.Text = "Bernal";
            // 
            // lblBerazategui
            // 
            this.lblBerazategui.AutoSize = true;
            this.lblBerazategui.Location = new System.Drawing.Point(374, 76);
            this.lblBerazategui.Name = "lblBerazategui";
            this.lblBerazategui.Size = new System.Drawing.Size(68, 15);
            this.lblBerazategui.TabIndex = 6;
            this.lblBerazategui.Text = "Berazategui";
            // 
            // btnImprimirDatos
            // 
            this.btnImprimirDatos.Location = new System.Drawing.Point(102, 330);
            this.btnImprimirDatos.Name = "btnImprimirDatos";
            this.btnImprimirDatos.Size = new System.Drawing.Size(121, 23);
            this.btnImprimirDatos.TabIndex = 7;
            this.btnImprimirDatos.Text = "Imprimir datos";
            this.btnImprimirDatos.UseVisualStyleBackColor = true;
            this.btnImprimirDatos.Click += new System.EventHandler(this.btnImprimirDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(292, 330);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(553, 365);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimirDatos);
            this.Controls.Add(this.lblBerazategui);
            this.Controls.Add(this.lblBernal);
            this.Controls.Add(this.lblAvellaneda);
            this.Controls.Add(this.rtxAvellaneda);
            this.Controls.Add(this.rtxBerazategui);
            this.Controls.Add(this.rtxBernal);
            this.Controls.Add(this.lblSucursales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sucursales";
            this.Load += new System.EventHandler(this.frmSucursales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSucursales;
        private System.Windows.Forms.RichTextBox rtxBernal;
        private System.Windows.Forms.RichTextBox rtxBerazategui;
        private System.Windows.Forms.RichTextBox rtxAvellaneda;
        private System.Windows.Forms.Label lblAvellaneda;
        private System.Windows.Forms.Label lblBernal;
        private System.Windows.Forms.Label lblBerazategui;
        private System.Windows.Forms.Button btnImprimirDatos;
        private System.Windows.Forms.Button btnSalir;
    }
}