namespace ProyectoCafe.Frontend
{
    partial class NuevaFormaPago
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
            this.btnCancelFP = new System.Windows.Forms.Button();
            this.btnAgregarFP = new System.Windows.Forms.Button();
            this.txtNombreFP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelFP
            // 
            this.btnCancelFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelFP.Location = new System.Drawing.Point(352, 129);
            this.btnCancelFP.Name = "btnCancelFP";
            this.btnCancelFP.Size = new System.Drawing.Size(82, 29);
            this.btnCancelFP.TabIndex = 19;
            this.btnCancelFP.Text = "Cancelar";
            this.btnCancelFP.UseVisualStyleBackColor = true;
            this.btnCancelFP.Click += new System.EventHandler(this.btnCancelFP_Click);
            // 
            // btnAgregarFP
            // 
            this.btnAgregarFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarFP.Location = new System.Drawing.Point(211, 129);
            this.btnAgregarFP.Name = "btnAgregarFP";
            this.btnAgregarFP.Size = new System.Drawing.Size(82, 29);
            this.btnAgregarFP.TabIndex = 18;
            this.btnAgregarFP.Text = "Agregar";
            this.btnAgregarFP.UseVisualStyleBackColor = true;
            this.btnAgregarFP.Click += new System.EventHandler(this.btnAgregarFP_Click);
            // 
            // txtNombreFP
            // 
            this.txtNombreFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreFP.Location = new System.Drawing.Point(134, 50);
            this.txtNombreFP.Name = "txtNombreFP";
            this.txtNombreFP.Size = new System.Drawing.Size(300, 26);
            this.txtNombreFP.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Descripción:";
            // 
            // NuevaFormaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btnCancelFP);
            this.Controls.Add(this.btnAgregarFP);
            this.Controls.Add(this.txtNombreFP);
            this.Controls.Add(this.label1);
            this.Name = "NuevaFormaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Forma De Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelFP;
        private System.Windows.Forms.Button btnAgregarFP;
        private System.Windows.Forms.TextBox txtNombreFP;
        private System.Windows.Forms.Label label1;
    }
}