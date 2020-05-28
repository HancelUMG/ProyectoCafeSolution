namespace ProyectoCafe.Frontend
{
    partial class BancosRegistrados
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
            this.lvBancos = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.banco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cuenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvBancos
            // 
            this.lvBancos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.banco,
            this.cuenta});
            this.lvBancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvBancos.HideSelection = false;
            this.lvBancos.Location = new System.Drawing.Point(12, 12);
            this.lvBancos.Name = "lvBancos";
            this.lvBancos.Size = new System.Drawing.Size(650, 300);
            this.lvBancos.TabIndex = 0;
            this.lvBancos.UseCompatibleStateImageBehavior = false;
            this.lvBancos.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // banco
            // 
            this.banco.Text = "BANCO";
            this.banco.Width = 285;
            // 
            // cuenta
            // 
            this.cuenta.Text = "NÚMERO DE CUENTA";
            this.cuenta.Width = 300;
            // 
            // BancosRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 324);
            this.Controls.Add(this.lvBancos);
            this.Name = "BancosRegistrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bancos Registrados";
            this.Load += new System.EventHandler(this.BancosRegistrados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvBancos;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader banco;
        private System.Windows.Forms.ColumnHeader cuenta;
    }
}