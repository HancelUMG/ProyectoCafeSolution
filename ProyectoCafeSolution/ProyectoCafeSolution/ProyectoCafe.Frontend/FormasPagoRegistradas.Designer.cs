namespace ProyectoCafe.Frontend
{
    partial class FormasPagoRegistradas
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
            this.lvFormaPago = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOMBRE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFormaPago
            // 
            this.lvFormaPago.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.NOMBRE});
            this.lvFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lvFormaPago.HideSelection = false;
            this.lvFormaPago.Location = new System.Drawing.Point(12, 12);
            this.lvFormaPago.Name = "lvFormaPago";
            this.lvFormaPago.Size = new System.Drawing.Size(467, 237);
            this.lvFormaPago.TabIndex = 2;
            this.lvFormaPago.UseCompatibleStateImageBehavior = false;
            this.lvFormaPago.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // NOMBRE
            // 
            this.NOMBRE.Text = "DESCRIPCIÓN";
            this.NOMBRE.Width = 400;
            // 
            // FormasPagoRegistradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 261);
            this.Controls.Add(this.lvFormaPago);
            this.Name = "FormasPagoRegistradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formas De Pago Registradas";
            this.Load += new System.EventHandler(this.FormasPagoRegistradas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvFormaPago;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader NOMBRE;
    }
}