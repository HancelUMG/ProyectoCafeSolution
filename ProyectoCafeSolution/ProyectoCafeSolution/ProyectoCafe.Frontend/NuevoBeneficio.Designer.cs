namespace ProyectoCafe.Frontend
{
    partial class NuevoBeneficio
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
            this.btnCancelBen = new System.Windows.Forms.Button();
            this.btnAgregarBen = new System.Windows.Forms.Button();
            this.txtNombreBen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelBen
            // 
            this.btnCancelBen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelBen.Location = new System.Drawing.Point(352, 129);
            this.btnCancelBen.Name = "btnCancelBen";
            this.btnCancelBen.Size = new System.Drawing.Size(82, 29);
            this.btnCancelBen.TabIndex = 15;
            this.btnCancelBen.Text = "Cancelar";
            this.btnCancelBen.UseVisualStyleBackColor = true;
            // 
            // btnAgregarBen
            // 
            this.btnAgregarBen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarBen.Location = new System.Drawing.Point(211, 129);
            this.btnAgregarBen.Name = "btnAgregarBen";
            this.btnAgregarBen.Size = new System.Drawing.Size(82, 29);
            this.btnAgregarBen.TabIndex = 14;
            this.btnAgregarBen.Text = "Agregar";
            this.btnAgregarBen.UseVisualStyleBackColor = true;
            this.btnAgregarBen.Click += new System.EventHandler(this.btnAgregarBen_Click);
            // 
            // txtNombreBen
            // 
            this.txtNombreBen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreBen.Location = new System.Drawing.Point(134, 50);
            this.txtNombreBen.Name = "txtNombreBen";
            this.txtNombreBen.Size = new System.Drawing.Size(300, 26);
            this.txtNombreBen.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // NuevoBeneficio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btnCancelBen);
            this.Controls.Add(this.btnAgregarBen);
            this.Controls.Add(this.txtNombreBen);
            this.Controls.Add(this.label1);
            this.Name = "NuevoBeneficio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NuevoBeneficio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelBen;
        private System.Windows.Forms.Button btnAgregarBen;
        private System.Windows.Forms.TextBox txtNombreBen;
        private System.Windows.Forms.Label label1;
    }
}