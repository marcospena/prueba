namespace EagleReports.UserControlsEagle
{
    partial class ucFormularioCategoria
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtEmpleados = new MetroFramework.Controls.MetroTile();
            this.mtTurnos = new MetroFramework.Controls.MetroTile();
            this.mtCash = new MetroFramework.Controls.MetroTile();
            this.mtCompras = new MetroFramework.Controls.MetroTile();
            this.mtVentas = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtEmpleados
            // 
            this.mtEmpleados.ActiveControl = null;
            this.mtEmpleados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtEmpleados.Location = new System.Drawing.Point(282, 199);
            this.mtEmpleados.Name = "mtEmpleados";
            this.mtEmpleados.Size = new System.Drawing.Size(184, 66);
            this.mtEmpleados.TabIndex = 9;
            this.mtEmpleados.Text = "Empleados";
            this.mtEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEmpleados.UseSelectable = true;
            this.mtEmpleados.Click += new System.EventHandler(this.mtEmpleados_Click);
            // 
            // mtTurnos
            // 
            this.mtTurnos.ActiveControl = null;
            this.mtTurnos.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtTurnos.Location = new System.Drawing.Point(92, 199);
            this.mtTurnos.Name = "mtTurnos";
            this.mtTurnos.Size = new System.Drawing.Size(184, 66);
            this.mtTurnos.TabIndex = 8;
            this.mtTurnos.Text = "Turnos";
            this.mtTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtTurnos.UseSelectable = true;
            this.mtTurnos.Click += new System.EventHandler(this.mtTurnos_Click);
            // 
            // mtCash
            // 
            this.mtCash.ActiveControl = null;
            this.mtCash.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtCash.Location = new System.Drawing.Point(92, 127);
            this.mtCash.Name = "mtCash";
            this.mtCash.Size = new System.Drawing.Size(374, 66);
            this.mtCash.TabIndex = 7;
            this.mtCash.Text = "Cash";
            this.mtCash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCash.UseSelectable = true;
            this.mtCash.Click += new System.EventHandler(this.mtCash_Click);
            // 
            // mtCompras
            // 
            this.mtCompras.ActiveControl = null;
            this.mtCompras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtCompras.Location = new System.Drawing.Point(282, 55);
            this.mtCompras.Name = "mtCompras";
            this.mtCompras.Size = new System.Drawing.Size(184, 66);
            this.mtCompras.TabIndex = 6;
            this.mtCompras.Text = "Compras";
            this.mtCompras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCompras.UseSelectable = true;
            this.mtCompras.Click += new System.EventHandler(this.mtCompras_Click);
            // 
            // mtVentas
            // 
            this.mtVentas.ActiveControl = null;
            this.mtVentas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mtVentas.Location = new System.Drawing.Point(92, 55);
            this.mtVentas.Name = "mtVentas";
            this.mtVentas.Size = new System.Drawing.Size(184, 66);
            this.mtVentas.TabIndex = 5;
            this.mtVentas.Text = "Ventas";
            this.mtVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtVentas.UseSelectable = true;
            this.mtVentas.Click += new System.EventHandler(this.mtVentas_Click);
            // 
            // ucFormularioCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mtEmpleados);
            this.Controls.Add(this.mtTurnos);
            this.Controls.Add(this.mtCash);
            this.Controls.Add(this.mtCompras);
            this.Controls.Add(this.mtVentas);
            this.Name = "ucFormularioCategoria";
            this.Size = new System.Drawing.Size(554, 314);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtEmpleados;
        private MetroFramework.Controls.MetroTile mtTurnos;
        private MetroFramework.Controls.MetroTile mtCash;
        private MetroFramework.Controls.MetroTile mtCompras;
        private MetroFramework.Controls.MetroTile mtVentas;
    }
}
