namespace ProyectoCafe.Frontend
{
    partial class NuevoCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreClie = new System.Windows.Forms.TextBox();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.btnAgregarClie = new System.Windows.Forms.Button();
            this.btnCancelClie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "DPI:";
            // 
            // txtNombreClie
            // 
            this.txtNombreClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreClie.Location = new System.Drawing.Point(179, 65);
            this.txtNombreClie.Name = "txtNombreClie";
            this.txtNombreClie.Size = new System.Drawing.Size(300, 26);
            this.txtNombreClie.TabIndex = 2;
            // 
            // txtDPI
            // 
            this.txtDPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDPI.Location = new System.Drawing.Point(179, 123);
            this.txtDPI.Name = "txtDPI";
            this.txtDPI.Size = new System.Drawing.Size(150, 26);
            this.txtDPI.TabIndex = 3;
            this.txtDPI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDPI_KeyPress);
            // 
            // btnAgregarClie
            // 
            this.btnAgregarClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarClie.Location = new System.Drawing.Point(254, 183);
            this.btnAgregarClie.Name = "btnAgregarClie";
            this.btnAgregarClie.Size = new System.Drawing.Size(82, 29);
            this.btnAgregarClie.TabIndex = 4;
            this.btnAgregarClie.Text = "Agregar";
            this.btnAgregarClie.UseVisualStyleBackColor = true;
            this.btnAgregarClie.Click += new System.EventHandler(this.btnAgregarClie_Click);
            // 
            // btnCancelClie
            // 
            this.btnCancelClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelClie.Location = new System.Drawing.Point(397, 183);
            this.btnCancelClie.Name = "btnCancelClie";
            this.btnCancelClie.Size = new System.Drawing.Size(82, 29);
            this.btnCancelClie.TabIndex = 5;
            this.btnCancelClie.Text = "Cancelar";
            this.btnCancelClie.UseVisualStyleBackColor = true;
            this.btnCancelClie.Click += new System.EventHandler(this.btnCancelClie_Click);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 292);
            this.Controls.Add(this.btnCancelClie);
            this.Controls.Add(this.btnAgregarClie);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.txtNombreClie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreClie;
        private System.Windows.Forms.TextBox txtDPI;
        private System.Windows.Forms.Button btnAgregarClie;
        private System.Windows.Forms.Button btnCancelClie;
    }
}