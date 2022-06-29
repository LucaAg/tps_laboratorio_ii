
namespace FormsTP4
{
    partial class FrmSaludar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaludar));
            this.txtBienvenida = new System.Windows.Forms.TextBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblInicioHorario = new System.Windows.Forms.Label();
            this.txtHorarioBienvenida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBienvenida
            // 
            this.txtBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtBienvenida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBienvenida.Location = new System.Drawing.Point(12, 27);
            this.txtBienvenida.Name = "txtBienvenida";
            this.txtBienvenida.ReadOnly = true;
            this.txtBienvenida.Size = new System.Drawing.Size(391, 23);
            this.txtBienvenida.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(87, 15);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "BIENVENIDO/A";
            // 
            // lblInicioHorario
            // 
            this.lblInicioHorario.AutoSize = true;
            this.lblInicioHorario.Location = new System.Drawing.Point(13, 67);
            this.lblInicioHorario.Name = "lblInicioHorario";
            this.lblInicioHorario.Size = new System.Drawing.Size(115, 15);
            this.lblInicioHorario.TabIndex = 3;
            this.lblInicioHorario.Text = "INICIO DE JORNADA";
            // 
            // txtHorarioBienvenida
            // 
            this.txtHorarioBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtHorarioBienvenida.Location = new System.Drawing.Point(13, 88);
            this.txtHorarioBienvenida.Name = "txtHorarioBienvenida";
            this.txtHorarioBienvenida.ReadOnly = true;
            this.txtHorarioBienvenida.Size = new System.Drawing.Size(390, 23);
            this.txtHorarioBienvenida.TabIndex = 2;
            // 
            // FrmSaludar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(436, 123);
            this.Controls.Add(this.lblInicioHorario);
            this.Controls.Add(this.txtHorarioBienvenida);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.txtBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaludar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMA Inicio Jornada";
            this.Load += new System.EventHandler(this.frmSaludar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBienvenida;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblInicioHorario;
        private System.Windows.Forms.TextBox txtHorarioBienvenida;
    }
}