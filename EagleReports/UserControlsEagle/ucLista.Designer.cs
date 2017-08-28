namespace EagleReports.UserControlsEagle
{
    partial class ucLista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReporteVentas = new MetroFramework.Controls.MetroGrid();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnkAtras = new MetroFramework.Controls.MetroLink();
            this.lnkSiguiente = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteVentas
            // 
            this.dgvReporteVentas.AllowUserToAddRows = false;
            this.dgvReporteVentas.AllowUserToResizeRows = false;
            this.dgvReporteVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReporteVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReporteVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvReporteVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnDescr,
            this.ColumnIdCategoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReporteVentas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteVentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReporteVentas.EnableHeadersVisualStyles = false;
            this.dgvReporteVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvReporteVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvReporteVentas.Location = new System.Drawing.Point(0, 79);
            this.dgvReporteVentas.MultiSelect = false;
            this.dgvReporteVentas.Name = "dgvReporteVentas";
            this.dgvReporteVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporteVentas.RowHeadersWidth = 20;
            this.dgvReporteVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvReporteVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReporteVentas.Size = new System.Drawing.Size(554, 235);
            this.dgvReporteVentas.TabIndex = 24;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnID.Visible = false;
            // 
            // ColumnDescr
            // 
            this.ColumnDescr.HeaderText = "Descripción";
            this.ColumnDescr.MaxInputLength = 150;
            this.ColumnDescr.Name = "ColumnDescr";
            this.ColumnDescr.ReadOnly = true;
            this.ColumnDescr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDescr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnDescr.Width = 532;
            // 
            // ColumnIdCategoria
            // 
            this.ColumnIdCategoria.HeaderText = "IDCategoria";
            this.ColumnIdCategoria.Name = "ColumnIdCategoria";
            this.ColumnIdCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnIdCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnIdCategoria.Visible = false;
            // 
            // lnkAtras
            // 
            this.lnkAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkAtras.Image = global::EagleReports.Properties.Resources.if_back_left_arrow_botton_2203523;
            this.lnkAtras.ImageSize = 32;
            this.lnkAtras.Location = new System.Drawing.Point(2, 3);
            this.lnkAtras.Name = "lnkAtras";
            this.lnkAtras.Size = new System.Drawing.Size(45, 33);
            this.lnkAtras.TabIndex = 26;
            this.lnkAtras.UseSelectable = true;
            this.lnkAtras.Click += new System.EventHandler(this.lnkAtras_Click);
            // 
            // lnkSiguiente
            // 
            this.lnkSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSiguiente.Image = global::EagleReports.Properties.Resources.if_next_right_arrow_botton_2203522;
            this.lnkSiguiente.ImageSize = 32;
            this.lnkSiguiente.Location = new System.Drawing.Point(510, 3);
            this.lnkSiguiente.Name = "lnkSiguiente";
            this.lnkSiguiente.Size = new System.Drawing.Size(41, 33);
            this.lnkSiguiente.TabIndex = 27;
            this.lnkSiguiente.UseSelectable = true;
            this.lnkSiguiente.Click += new System.EventHandler(this.lnkSiguiente_Click);
            // 
            // ucLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.lnkSiguiente);
            this.Controls.Add(this.dgvReporteVentas);
            this.Name = "ucLista";
            this.Size = new System.Drawing.Size(554, 314);
            this.Load += new System.EventHandler(this.ucLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgvReporteVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdCategoria;
        private MetroFramework.Controls.MetroLink lnkAtras;
        private MetroFramework.Controls.MetroLink lnkSiguiente;
    }
}
