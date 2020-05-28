namespace ProyectoCafe.Frontend
{
    partial class ClientesRegistrados
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
            this.btnTodosCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.ColNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColDPI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAcumulado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colComprado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTodosCliente
            // 
            this.btnTodosCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTodosCliente.Location = new System.Drawing.Point(402, 83);
            this.btnTodosCliente.Name = "btnTodosCliente";
            this.btnTodosCliente.Size = new System.Drawing.Size(82, 29);
            this.btnTodosCliente.TabIndex = 10;
            this.btnTodosCliente.Text = "Todos";
            this.btnTodosCliente.UseVisualStyleBackColor = true;
            this.btnTodosCliente.Click += new System.EventHandler(this.btnTodosCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscarCliente.Location = new System.Drawing.Point(207, 83);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(82, 29);
            this.btnBuscarCliente.TabIndex = 9;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscarCliente.Location = new System.Drawing.Point(139, 42);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(150, 26);
            this.txtBuscarCliente.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre o DPI:";
            // 
            // lvClientes
            // 
            this.lvClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNombre,
            this.ColDPI,
            this.colAcumulado,
            this.colComprado});
            this.lvClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvClientes.HideSelection = false;
            this.lvClientes.Location = new System.Drawing.Point(16, 153);
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(762, 265);
            this.lvClientes.TabIndex = 11;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
            // 
            // ColNombre
            // 
            this.ColNombre.Text = "NOMBRE";
            this.ColNombre.Width = 385;
            // 
            // ColDPI
            // 
            this.ColDPI.Text = "DPI";
            this.ColDPI.Width = 150;
            // 
            // colAcumulado
            // 
            this.colAcumulado.Text = "Acumulado";
            this.colAcumulado.Width = 110;
            // 
            // colComprado
            // 
            this.colComprado.Text = "Comprado";
            this.colComprado.Width = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(554, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "*Peso expresado en quintales";
            // 
            // ClientesRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvClientes);
            this.Controls.Add(this.btnTodosCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.label1);
            this.Name = "ClientesRegistrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Registrados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodosCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.ColumnHeader ColNombre;
        private System.Windows.Forms.ColumnHeader ColDPI;
        private System.Windows.Forms.ColumnHeader colAcumulado;
        private System.Windows.Forms.ColumnHeader colComprado;
        private System.Windows.Forms.Label label2;
    }
}