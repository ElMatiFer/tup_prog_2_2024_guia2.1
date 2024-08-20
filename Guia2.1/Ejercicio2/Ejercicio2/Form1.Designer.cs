namespace Ejercicio2
{
    partial class fLiquidacion
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
            this.btRegistrarEmpleado = new System.Windows.Forms.Button();
            this.btGenerarLiquidaciones = new System.Windows.Forms.Button();
            this.btMostrarLiquidaciones = new System.Windows.Forms.Button();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btRegistrarEmpleado
            // 
            this.btRegistrarEmpleado.Location = new System.Drawing.Point(37, 12);
            this.btRegistrarEmpleado.Name = "btRegistrarEmpleado";
            this.btRegistrarEmpleado.Size = new System.Drawing.Size(127, 48);
            this.btRegistrarEmpleado.TabIndex = 0;
            this.btRegistrarEmpleado.Text = "Registrar Empleado";
            this.btRegistrarEmpleado.UseVisualStyleBackColor = true;
            this.btRegistrarEmpleado.Click += new System.EventHandler(this.btRegistrarEmpleado_Click);
            // 
            // btGenerarLiquidaciones
            // 
            this.btGenerarLiquidaciones.Location = new System.Drawing.Point(260, 12);
            this.btGenerarLiquidaciones.Name = "btGenerarLiquidaciones";
            this.btGenerarLiquidaciones.Size = new System.Drawing.Size(127, 48);
            this.btGenerarLiquidaciones.TabIndex = 1;
            this.btGenerarLiquidaciones.Text = "Generar Liquidaciones";
            this.btGenerarLiquidaciones.UseVisualStyleBackColor = true;
            // 
            // btMostrarLiquidaciones
            // 
            this.btMostrarLiquidaciones.Location = new System.Drawing.Point(463, 12);
            this.btMostrarLiquidaciones.Name = "btMostrarLiquidaciones";
            this.btMostrarLiquidaciones.Size = new System.Drawing.Size(127, 48);
            this.btMostrarLiquidaciones.TabIndex = 2;
            this.btMostrarLiquidaciones.Text = "Mostrar liquidaciones";
            this.btMostrarLiquidaciones.UseVisualStyleBackColor = true;
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(12, 66);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(623, 342);
            this.lbResultados.TabIndex = 3;
            // 
            // fLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 415);
            this.Controls.Add(this.lbResultados);
            this.Controls.Add(this.btMostrarLiquidaciones);
            this.Controls.Add(this.btGenerarLiquidaciones);
            this.Controls.Add(this.btRegistrarEmpleado);
            this.Name = "fLiquidacion";
            this.Text = "Liquidacion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRegistrarEmpleado;
        private System.Windows.Forms.Button btGenerarLiquidaciones;
        private System.Windows.Forms.Button btMostrarLiquidaciones;
        private System.Windows.Forms.ListBox lbResultados;
    }
}

