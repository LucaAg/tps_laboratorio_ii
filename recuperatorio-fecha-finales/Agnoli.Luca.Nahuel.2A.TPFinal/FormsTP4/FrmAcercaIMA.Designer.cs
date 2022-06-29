
namespace FormsTP4
{
    partial class FrmAcercaIMA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcercaIMA));
            this.lblValores = new System.Windows.Forms.Label();
            this.lblMision = new System.Windows.Forms.Label();
            this.rtxValores = new System.Windows.Forms.RichTextBox();
            this.rtxMision = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValores.ForeColor = System.Drawing.Color.Blue;
            this.lblValores.Location = new System.Drawing.Point(49, 21);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(195, 37);
            this.lblValores.TabIndex = 0;
            this.lblValores.Text = "Valores de IMA";
            // 
            // lblMision
            // 
            this.lblMision.AutoSize = true;
            this.lblMision.BackColor = System.Drawing.Color.LightGray;
            this.lblMision.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMision.ForeColor = System.Drawing.Color.Blue;
            this.lblMision.Location = new System.Drawing.Point(49, 169);
            this.lblMision.Name = "lblMision";
            this.lblMision.Size = new System.Drawing.Size(97, 37);
            this.lblMision.TabIndex = 2;
            this.lblMision.Text = "Mision";
            // 
            // rtxValores
            // 
            this.rtxValores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtxValores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxValores.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rtxValores.Location = new System.Drawing.Point(49, 74);
            this.rtxValores.Name = "rtxValores";
            this.rtxValores.ReadOnly = true;
            this.rtxValores.Size = new System.Drawing.Size(674, 73);
            this.rtxValores.TabIndex = 4;
            this.rtxValores.Text = "";
            // 
            // rtxMision
            // 
            this.rtxMision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtxMision.ForeColor = System.Drawing.SystemColors.InfoText;
            this.rtxMision.Location = new System.Drawing.Point(49, 225);
            this.rtxMision.Name = "rtxMision";
            this.rtxMision.ReadOnly = true;
            this.rtxMision.Size = new System.Drawing.Size(674, 73);
            this.rtxMision.TabIndex = 5;
            this.rtxMision.Text = "";
            // 
            // FrmAcercaIMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 329);
            this.Controls.Add(this.rtxMision);
            this.Controls.Add(this.rtxValores);
            this.Controls.Add(this.lblMision);
            this.Controls.Add(this.lblValores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAcercaIMA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de IMA";
            this.Load += new System.EventHandler(this.FrmAcercaIMA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label lblMision;
        private System.Windows.Forms.RichTextBox rtxValores;
        private System.Windows.Forms.RichTextBox rtxMision;
    }
}