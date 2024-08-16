namespace Ejercicio1
{
    partial class fPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbListarRegistros = new System.Windows.Forms.ListBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btListarRegistros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListarRegistros
            // 
            this.lbListarRegistros.FormattingEnabled = true;
            this.lbListarRegistros.Location = new System.Drawing.Point(12, 12);
            this.lbListarRegistros.Name = "lbListarRegistros";
            this.lbListarRegistros.Size = new System.Drawing.Size(379, 134);
            this.lbListarRegistros.TabIndex = 0;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(397, 12);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(173, 64);
            this.btAgregar.TabIndex = 1;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btListarRegistros
            // 
            this.btListarRegistros.Location = new System.Drawing.Point(397, 82);
            this.btListarRegistros.Name = "btListarRegistros";
            this.btListarRegistros.Size = new System.Drawing.Size(173, 64);
            this.btListarRegistros.TabIndex = 2;
            this.btListarRegistros.Text = "Listar Registros";
            this.btListarRegistros.UseVisualStyleBackColor = true;
            this.btListarRegistros.Click += new System.EventHandler(this.btListarRegistros_Click);
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 151);
            this.Controls.Add(this.btListarRegistros);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.lbListarRegistros);
            this.Name = "fPrincipal";
            this.Text = "Registro Vehicular";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListarRegistros;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btListarRegistros;
    }
}

