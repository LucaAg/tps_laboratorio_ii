
namespace FrmMenuIma
{
    partial class FrmInfoPlanes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInfoPlanes));
            this.lblTituloPlanes = new System.Windows.Forms.Label();
            this.btnPlanClasico = new System.Windows.Forms.Button();
            this.btnPlanPlus = new System.Windows.Forms.Button();
            this.btnPlanPremiun = new System.Windows.Forms.Button();
            this.rtbInfoPlanes = new System.Windows.Forms.RichTextBox();
            this.pnlCobertura = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlCobertura.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloPlanes
            // 
            this.lblTituloPlanes.AutoSize = true;
            this.lblTituloPlanes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPlanes.Location = new System.Drawing.Point(190, 9);
            this.lblTituloPlanes.Name = "lblTituloPlanes";
            this.lblTituloPlanes.Size = new System.Drawing.Size(225, 21);
            this.lblTituloPlanes.TabIndex = 3;
            this.lblTituloPlanes.Text = "COBERTURA DE LOS PLANES";
            // 
            // btnPlanClasico
            // 
            this.btnPlanClasico.Location = new System.Drawing.Point(3, 28);
            this.btnPlanClasico.Name = "btnPlanClasico";
            this.btnPlanClasico.Size = new System.Drawing.Size(100, 23);
            this.btnPlanClasico.TabIndex = 4;
            this.btnPlanClasico.Text = "Plan Clasico";
            this.btnPlanClasico.UseVisualStyleBackColor = true;
            this.btnPlanClasico.Click += new System.EventHandler(this.BtnPlanClasico_Click);
            // 
            // btnPlanPlus
            // 
            this.btnPlanPlus.Location = new System.Drawing.Point(3, 77);
            this.btnPlanPlus.Name = "btnPlanPlus";
            this.btnPlanPlus.Size = new System.Drawing.Size(100, 23);
            this.btnPlanPlus.TabIndex = 5;
            this.btnPlanPlus.Text = "Plan Plus";
            this.btnPlanPlus.UseVisualStyleBackColor = true;
            this.btnPlanPlus.Click += new System.EventHandler(this.btnPlanPlus_Click);
            // 
            // btnPlanPremiun
            // 
            this.btnPlanPremiun.Location = new System.Drawing.Point(3, 127);
            this.btnPlanPremiun.Name = "btnPlanPremiun";
            this.btnPlanPremiun.Size = new System.Drawing.Size(100, 23);
            this.btnPlanPremiun.TabIndex = 6;
            this.btnPlanPremiun.Text = "Plan Premium";
            this.btnPlanPremiun.UseVisualStyleBackColor = true;
            this.btnPlanPremiun.Click += new System.EventHandler(this.btnPlanPremiun_Click);
            // 
            // rtbInfoPlanes
            // 
            this.rtbInfoPlanes.Location = new System.Drawing.Point(129, 50);
            this.rtbInfoPlanes.Name = "rtbInfoPlanes";
            this.rtbInfoPlanes.ReadOnly = true;
            this.rtbInfoPlanes.Size = new System.Drawing.Size(461, 209);
            this.rtbInfoPlanes.TabIndex = 7;
            this.rtbInfoPlanes.Text = "";
            // 
            // pnlCobertura
            // 
            this.pnlCobertura.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlCobertura.Controls.Add(this.lblTituloPlanes);
            this.pnlCobertura.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCobertura.Location = new System.Drawing.Point(0, 0);
            this.pnlCobertura.Name = "pnlCobertura";
            this.pnlCobertura.Size = new System.Drawing.Size(602, 44);
            this.pnlCobertura.TabIndex = 8;
            // 
            // pnlBotones
            // 
            this.pnlBotones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.btnPlanPremiun);
            this.pnlBotones.Controls.Add(this.btnPlanClasico);
            this.pnlBotones.Controls.Add(this.btnPlanPlus);
            this.pnlBotones.Location = new System.Drawing.Point(0, 43);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(114, 227);
            this.pnlBotones.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(3, 179);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmInfoPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 271);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlCobertura);
            this.Controls.Add(this.rtbInfoPlanes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInfoPlanes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información de los planes";
            this.pnlCobertura.ResumeLayout(false);
            this.pnlCobertura.PerformLayout();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPlanes;
        private System.Windows.Forms.Button btnPlanClasico;
        private System.Windows.Forms.Button btnPlanPlus;
        private System.Windows.Forms.Button btnPlanPremiun;
        private System.Windows.Forms.RichTextBox rtbInfoPlanes;
        private System.Windows.Forms.Panel pnlCobertura;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnSalir;
    }
}