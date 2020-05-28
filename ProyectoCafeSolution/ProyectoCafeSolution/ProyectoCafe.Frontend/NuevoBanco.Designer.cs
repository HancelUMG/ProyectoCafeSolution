namespace ProyectoCafe.Frontend
{
    partial class NuevoBanco
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
            this.btnCancelBanco = new System.Windows.Forms.Button();
            this.btnAgregarBanco = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtNombreBanco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelBanco
            // 
            this.btnCancelBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelBanco.Location = new System.Drawing.Point(397, 183);
            this.btnCancelBanco.Name = "btnCancelBanco";
            this.btnCancelBanco.Size = new System.Drawing.Size(82, 29);
            this.btnCancelBanco.TabIndex = 11;
            this.btnCancelBanco.Text = "Cancelar";
            this.btnCancelBanco.UseVisualStyleBackColor = true;
            // 
            // btnAgregarBanco
            // 
            this.btnAgregarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAgregarBanco.Location = new System.Drawing.Point(254, 183);
            this.btnAgregarBanco.Name = "btnAgregarBanco";
            this.btnAgregarBanco.Size = new System.Drawing.Size(82, 29);
            this.btnAgregarBanco.TabIndex = 10;
            this.btnAgregarBanco.Text = "Agregar";
            this.btnAgregarBanco.UseVisualStyleBackColor = true;
            this.btnAgregarBanco.Click += new System.EventHandler(this.btnAgregarBanco_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCuenta.Location = new System.Drawing.Point(179, 123);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(300, 26);
            this.txtCuenta.TabIndex = 9;
            // 
            // txtNombreBanco
            // 
            this.txtNombreBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombreBanco.Location = new System.Drawing.Point(179, 65);
            this.txtNombreBanco.Name = "txtNombreBanco";
            this.txtNombreBanco.Size = new System.Drawing.Size(300, 26);
            this.txtNombreBanco.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "No. Cuenta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre:";
            // 
            // NuevoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 292);
            this.Controls.Add(this.btnCancelBanco);
            this.Controls.Add(this.btnAgregarBanco);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtNombreBanco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Banco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelBanco;
        private System.Windows.Forms.Button btnAgregarBanco;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtNombreBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}