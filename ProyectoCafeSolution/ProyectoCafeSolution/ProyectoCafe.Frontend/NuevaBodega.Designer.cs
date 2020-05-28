namespace ProyectoCafe.Frontend
{
    partial class NuevaBodega
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
            this.btnCancelBod = new System.Windows.Forms.Button();
            this.btnAgregarBod = new System.Windows.Forms.Button();
            this.txtNombreBod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelBod
            // 
            this.btnCancelBod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelBod.Location = new System.Drawing.Point(352, 129);
            this.btnCancelBod.Name = "btnCancelBod";
            this.btnCancelBod.Size = new System.Drawing.Size(82, 29);
            this.btnCancelBod.TabIndex = 11;
            this.btnCancelBod.Text = "Cancelar";
            this.btnCancelBod.UseVisualStyleBackColor = true;
            this.btnCancelBod.Click += new System.EventHandler(this.btnCancelBod_Click);
            // 
            // btnAgregarBod
            // 
            this.btnAgregarBod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarBod.Location = new System.Drawing.Point(211, 129);
            this.btnAgregarBod.Name = "btnAgregarBod";
            this.btnAgregarBod.Size = new System.Drawing.Size(82, 29);
            this.btnAgregarBod.TabIndex = 10;
            this.btnAgregarBod.Text = "Agregar";
            this.btnAgregarBod.UseVisualStyleBackColor = true;
            this.btnAgregarBod.Click += new System.EventHandler(this.btnAgregarBod_Click);
            // 
            // txtNombreBod
            // 
            this.txtNombreBod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreBod.Location = new System.Drawing.Point(134, 50);
            this.txtNombreBod.Name = "txtNombreBod";
            this.txtNombreBod.Size = new System.Drawing.Size(300, 26);
            this.txtNombreBod.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // NuevaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.btnCancelBod);
            this.Controls.Add(this.btnAgregarBod);
            this.Controls.Add(this.txtNombreBod);
            this.Controls.Add(this.label1);
            this.Name = "NuevaBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Bodega";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelBod;
        private System.Windows.Forms.Button btnAgregarBod;
        private System.Windows.Forms.TextBox txtNombreBod;
        private System.Windows.Forms.Label label1;
    }
}