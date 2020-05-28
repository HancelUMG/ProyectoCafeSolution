namespace ProyectoCafe.Frontend
{
    partial class UsuariosRegistrados
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
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.ColNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnTodosUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColNombre,
            this.ColUsuario});
            this.lvUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvUsuarios.HideSelection = false;
            this.lvUsuarios.Location = new System.Drawing.Point(75, 152);
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(604, 199);
            this.lvUsuarios.TabIndex = 1;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // ColNombre
            // 
            this.ColNombre.Text = "NOMBRE";
            this.ColNombre.Width = 400;
            // 
            // ColUsuario
            // 
            this.ColUsuario.Text = "USUARIO";
            this.ColUsuario.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre o ID:";
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscarUsuario.Location = new System.Drawing.Point(188, 39);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(150, 26);
            this.txtBuscarUsuario.TabIndex = 3;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscarUsuario.Location = new System.Drawing.Point(256, 80);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(82, 29);
            this.btnBuscarUsuario.TabIndex = 4;
            this.btnBuscarUsuario.Text = "Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnTodosUsuarios
            // 
            this.btnTodosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTodosUsuarios.Location = new System.Drawing.Point(597, 117);
            this.btnTodosUsuarios.Name = "btnTodosUsuarios";
            this.btnTodosUsuarios.Size = new System.Drawing.Size(82, 29);
            this.btnTodosUsuarios.TabIndex = 5;
            this.btnTodosUsuarios.Text = "Todos";
            this.btnTodosUsuarios.UseVisualStyleBackColor = true;
            this.btnTodosUsuarios.Click += new System.EventHandler(this.btnTodosUsuarios_Click);
            // 
            // UsuariosRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 394);
            this.Controls.Add(this.btnTodosUsuarios);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvUsuarios);
            this.Name = "UsuariosRegistrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios Registrados";
            this.Load += new System.EventHandler(this.UsuariosRegistrados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.ColumnHeader ColNombre;
        private System.Windows.Forms.ColumnHeader ColUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnTodosUsuarios;
    }
}