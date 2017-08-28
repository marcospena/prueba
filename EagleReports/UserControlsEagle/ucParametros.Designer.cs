namespace EagleReports.UserControlsEagle
{
    partial class ucParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucParametros));
            this.gbRangos = new System.Windows.Forms.GroupBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblHacia = new MetroFramework.Controls.MetroLabel();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.pnlRangoNum = new MetroFramework.Controls.MetroPanel();
            this.lbl = new MetroFramework.Controls.MetroLabel();
            this.txblbl = new MetroFramework.Controls.MetroTextBox();
            this.pnlRangoFec = new MetroFramework.Controls.MetroPanel();
            this.lblRangofec = new MetroFramework.Controls.MetroLabel();
            this.dtRangoFecTo = new MetroFramework.Controls.MetroDateTime();
            this.dtRangoFecFrom = new MetroFramework.Controls.MetroDateTime();
            this.pnlRangoRVC = new MetroFramework.Controls.MetroPanel();
            this.lblrangoRVC = new MetroFramework.Controls.MetroLabel();
            this.lnkAtras = new MetroFramework.Controls.MetroLink();
            this.lnkSiguiente = new MetroFramework.Controls.MetroLink();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.txbIDRVCinicio = new System.Windows.Forms.TextBox();
            this.txbIDRVCfin = new System.Windows.Forms.TextBox();
            this.txtRangoRvcDesd = new MetroFramework.Controls.MetroTextBox();
            this.txtRangoRvcA = new MetroFramework.Controls.MetroTextBox();
            this.gbRangos.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.pnlRangoNum.SuspendLayout();
            this.pnlRangoFec.SuspendLayout();
            this.pnlRangoRVC.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRangos
            // 
            this.gbRangos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbRangos.Controls.Add(this.metroPanel1);
            this.gbRangos.Controls.Add(this.pnlRangoNum);
            this.gbRangos.Controls.Add(this.pnlRangoFec);
            this.gbRangos.Controls.Add(this.pnlRangoRVC);
            this.gbRangos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRangos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbRangos.Location = new System.Drawing.Point(49, 42);
            this.gbRangos.Name = "gbRangos";
            this.gbRangos.Size = new System.Drawing.Size(450, 201);
            this.gbRangos.TabIndex = 129;
            this.gbRangos.TabStop = false;
            this.gbRangos.Text = "Reporte";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblHacia);
            this.metroPanel1.Controls.Add(this.lblCodigo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(32, 19);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(388, 37);
            this.metroPanel1.TabIndex = 132;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblHacia
            // 
            this.lblHacia.AutoSize = true;
            this.lblHacia.ForeColor = System.Drawing.Color.Navy;
            this.lblHacia.Location = new System.Drawing.Point(290, 9);
            this.lblHacia.Name = "lblHacia";
            this.lblHacia.Size = new System.Drawing.Size(41, 19);
            this.lblHacia.TabIndex = 10;
            this.lblHacia.Text = "Hacia";
            this.lblHacia.UseCustomForeColor = true;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigo.Location = new System.Drawing.Point(142, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(45, 19);
            this.lblCodigo.TabIndex = 9;
            this.lblCodigo.Text = "Desde";
            this.lblCodigo.UseCustomForeColor = true;
            // 
            // pnlRangoNum
            // 
            this.pnlRangoNum.Controls.Add(this.lbl);
            this.pnlRangoNum.Controls.Add(this.txblbl);
            this.pnlRangoNum.HorizontalScrollbarBarColor = true;
            this.pnlRangoNum.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRangoNum.HorizontalScrollbarSize = 10;
            this.pnlRangoNum.Location = new System.Drawing.Point(32, 156);
            this.pnlRangoNum.Name = "pnlRangoNum";
            this.pnlRangoNum.Size = new System.Drawing.Size(388, 35);
            this.pnlRangoNum.TabIndex = 133;
            this.pnlRangoNum.VerticalScrollbarBarColor = true;
            this.pnlRangoNum.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRangoNum.VerticalScrollbarSize = 10;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.ForeColor = System.Drawing.Color.Navy;
            this.lbl.Location = new System.Drawing.Point(3, 6);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(37, 19);
            this.lbl.TabIndex = 131;
            this.lbl.Text = "label";
            this.lbl.UseCustomForeColor = true;
            // 
            // txblbl
            // 
            this.txblbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txblbl.CustomButton.Image = null;
            this.txblbl.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txblbl.CustomButton.Name = "";
            this.txblbl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txblbl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txblbl.CustomButton.TabIndex = 1;
            this.txblbl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txblbl.CustomButton.UseSelectable = true;
            this.txblbl.CustomButton.Visible = false;
            this.txblbl.Lines = new string[0];
            this.txblbl.Location = new System.Drawing.Point(153, 6);
            this.txblbl.MaxLength = 32767;
            this.txblbl.Name = "txblbl";
            this.txblbl.PasswordChar = '\0';
            this.txblbl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txblbl.SelectedText = "";
            this.txblbl.SelectionLength = 0;
            this.txblbl.SelectionStart = 0;
            this.txblbl.ShortcutsEnabled = true;
            this.txblbl.Size = new System.Drawing.Size(142, 23);
            this.txblbl.TabIndex = 130;
            this.txblbl.UseCustomBackColor = true;
            this.txblbl.UseSelectable = true;
            this.txblbl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txblbl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnlRangoFec
            // 
            this.pnlRangoFec.Controls.Add(this.lblRangofec);
            this.pnlRangoFec.Controls.Add(this.dtRangoFecTo);
            this.pnlRangoFec.Controls.Add(this.dtRangoFecFrom);
            this.pnlRangoFec.HorizontalScrollbarBarColor = true;
            this.pnlRangoFec.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRangoFec.HorizontalScrollbarSize = 10;
            this.pnlRangoFec.Location = new System.Drawing.Point(32, 62);
            this.pnlRangoFec.Name = "pnlRangoFec";
            this.pnlRangoFec.Size = new System.Drawing.Size(388, 35);
            this.pnlRangoFec.TabIndex = 130;
            this.pnlRangoFec.VerticalScrollbarBarColor = true;
            this.pnlRangoFec.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRangoFec.VerticalScrollbarSize = 10;
            // 
            // lblRangofec
            // 
            this.lblRangofec.AutoSize = true;
            this.lblRangofec.ForeColor = System.Drawing.Color.Navy;
            this.lblRangofec.Location = new System.Drawing.Point(3, 4);
            this.lblRangofec.Name = "lblRangofec";
            this.lblRangofec.Size = new System.Drawing.Size(106, 19);
            this.lblRangofec.TabIndex = 130;
            this.lblRangofec.Text = "Rango de fechas";
            this.lblRangofec.UseCustomForeColor = true;
            // 
            // dtRangoFecTo
            // 
            this.dtRangoFecTo.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtRangoFecTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRangoFecTo.Location = new System.Drawing.Point(260, 4);
            this.dtRangoFecTo.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtRangoFecTo.Name = "dtRangoFecTo";
            this.dtRangoFecTo.Size = new System.Drawing.Size(114, 25);
            this.dtRangoFecTo.TabIndex = 5;
            // 
            // dtRangoFecFrom
            // 
            this.dtRangoFecFrom.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtRangoFecFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtRangoFecFrom.Location = new System.Drawing.Point(114, 4);
            this.dtRangoFecFrom.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtRangoFecFrom.Name = "dtRangoFecFrom";
            this.dtRangoFecFrom.Size = new System.Drawing.Size(114, 25);
            this.dtRangoFecFrom.TabIndex = 4;
            // 
            // pnlRangoRVC
            // 
            this.pnlRangoRVC.Controls.Add(this.txtRangoRvcA);
            this.pnlRangoRVC.Controls.Add(this.txtRangoRvcDesd);
            this.pnlRangoRVC.Controls.Add(this.lblrangoRVC);
            this.pnlRangoRVC.HorizontalScrollbarBarColor = true;
            this.pnlRangoRVC.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlRangoRVC.HorizontalScrollbarSize = 10;
            this.pnlRangoRVC.Location = new System.Drawing.Point(32, 103);
            this.pnlRangoRVC.Name = "pnlRangoRVC";
            this.pnlRangoRVC.Size = new System.Drawing.Size(388, 47);
            this.pnlRangoRVC.TabIndex = 131;
            this.pnlRangoRVC.VerticalScrollbarBarColor = true;
            this.pnlRangoRVC.VerticalScrollbarHighlightOnWheel = false;
            this.pnlRangoRVC.VerticalScrollbarSize = 10;
            // 
            // lblrangoRVC
            // 
            this.lblrangoRVC.AutoSize = true;
            this.lblrangoRVC.ForeColor = System.Drawing.Color.Navy;
            this.lblrangoRVC.Location = new System.Drawing.Point(3, 10);
            this.lblrangoRVC.Name = "lblrangoRVC";
            this.lblrangoRVC.Size = new System.Drawing.Size(95, 19);
            this.lblrangoRVC.TabIndex = 132;
            this.lblrangoRVC.Text = "Rango de RVC";
            this.lblrangoRVC.UseCustomForeColor = true;
            // 
            // lnkAtras
            // 
            this.lnkAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkAtras.Image = global::EagleReports.Properties.Resources.if_back_left_arrow_botton_2203523;
            this.lnkAtras.ImageSize = 32;
            this.lnkAtras.Location = new System.Drawing.Point(2, 3);
            this.lnkAtras.Name = "lnkAtras";
            this.lnkAtras.Size = new System.Drawing.Size(45, 33);
            this.lnkAtras.TabIndex = 121;
            this.lnkAtras.UseSelectable = true;
            this.lnkAtras.Click += new System.EventHandler(this.lnkAtras_Click);
            // 
            // lnkSiguiente
            // 
            this.lnkSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkSiguiente.Enabled = false;
            this.lnkSiguiente.Image = global::EagleReports.Properties.Resources.if_next_right_arrow_botton_2203522;
            this.lnkSiguiente.ImageSize = 32;
            this.lnkSiguiente.Location = new System.Drawing.Point(510, 3);
            this.lnkSiguiente.Name = "lnkSiguiente";
            this.lnkSiguiente.Size = new System.Drawing.Size(41, 33);
            this.lnkSiguiente.TabIndex = 122;
            this.lnkSiguiente.UseSelectable = true;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVisualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnVisualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(248, 259);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(61, 34);
            this.btnVisualizar.TabIndex = 11;
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // txbIDRVCinicio
            // 
            this.txbIDRVCinicio.Location = new System.Drawing.Point(489, 259);
            this.txbIDRVCinicio.Name = "txbIDRVCinicio";
            this.txbIDRVCinicio.Size = new System.Drawing.Size(10, 20);
            this.txbIDRVCinicio.TabIndex = 130;
            this.txbIDRVCinicio.Visible = false;
            // 
            // txbIDRVCfin
            // 
            this.txbIDRVCfin.Location = new System.Drawing.Point(505, 259);
            this.txbIDRVCfin.Name = "txbIDRVCfin";
            this.txbIDRVCfin.Size = new System.Drawing.Size(10, 20);
            this.txbIDRVCfin.TabIndex = 131;
            this.txbIDRVCfin.Visible = false;
            // 
            // txtRangoRvcDesd
            // 
            this.txtRangoRvcDesd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtRangoRvcDesd.CustomButton.Image = null;
            this.txtRangoRvcDesd.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtRangoRvcDesd.CustomButton.Name = "";
            this.txtRangoRvcDesd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRangoRvcDesd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRangoRvcDesd.CustomButton.TabIndex = 1;
            this.txtRangoRvcDesd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRangoRvcDesd.CustomButton.UseSelectable = true;
            this.txtRangoRvcDesd.CustomButton.Visible = false;
            this.txtRangoRvcDesd.Lines = new string[0];
            this.txtRangoRvcDesd.Location = new System.Drawing.Point(114, 10);
            this.txtRangoRvcDesd.MaxLength = 32767;
            this.txtRangoRvcDesd.Name = "txtRangoRvcDesd";
            this.txtRangoRvcDesd.PasswordChar = '\0';
            this.txtRangoRvcDesd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRangoRvcDesd.SelectedText = "";
            this.txtRangoRvcDesd.SelectionLength = 0;
            this.txtRangoRvcDesd.SelectionStart = 0;
            this.txtRangoRvcDesd.ShortcutsEnabled = true;
            this.txtRangoRvcDesd.Size = new System.Drawing.Size(114, 23);
            this.txtRangoRvcDesd.TabIndex = 132;
            this.txtRangoRvcDesd.UseCustomBackColor = true;
            this.txtRangoRvcDesd.UseSelectable = true;
            this.txtRangoRvcDesd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRangoRvcDesd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRangoRvcDesd.Click += new System.EventHandler(this.txtRangoRvcDesd_Click);
            // 
            // txtRangoRvcA
            // 
            this.txtRangoRvcA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtRangoRvcA.CustomButton.Image = null;
            this.txtRangoRvcA.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtRangoRvcA.CustomButton.Name = "";
            this.txtRangoRvcA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRangoRvcA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRangoRvcA.CustomButton.TabIndex = 1;
            this.txtRangoRvcA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRangoRvcA.CustomButton.UseSelectable = true;
            this.txtRangoRvcA.CustomButton.Visible = false;
            this.txtRangoRvcA.Lines = new string[0];
            this.txtRangoRvcA.Location = new System.Drawing.Point(260, 10);
            this.txtRangoRvcA.MaxLength = 32767;
            this.txtRangoRvcA.Name = "txtRangoRvcA";
            this.txtRangoRvcA.PasswordChar = '\0';
            this.txtRangoRvcA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRangoRvcA.SelectedText = "";
            this.txtRangoRvcA.SelectionLength = 0;
            this.txtRangoRvcA.SelectionStart = 0;
            this.txtRangoRvcA.ShortcutsEnabled = true;
            this.txtRangoRvcA.Size = new System.Drawing.Size(114, 23);
            this.txtRangoRvcA.TabIndex = 133;
            this.txtRangoRvcA.UseCustomBackColor = true;
            this.txtRangoRvcA.UseSelectable = true;
            this.txtRangoRvcA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRangoRvcA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRangoRvcA.Click += new System.EventHandler(this.txtRangoRvcA_Click);
            // 
            // ucParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbIDRVCfin);
            this.Controls.Add(this.txbIDRVCinicio);
            this.Controls.Add(this.gbRangos);
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.lnkSiguiente);
            this.Controls.Add(this.btnVisualizar);
            this.Name = "ucParametros";
            this.Size = new System.Drawing.Size(554, 314);
            this.Load += new System.EventHandler(this.ucParametros_Load);
            this.gbRangos.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.pnlRangoNum.ResumeLayout(false);
            this.pnlRangoNum.PerformLayout();
            this.pnlRangoFec.ResumeLayout(false);
            this.pnlRangoFec.PerformLayout();
            this.pnlRangoRVC.ResumeLayout(false);
            this.pnlRangoRVC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVisualizar;
        private MetroFramework.Controls.MetroLink lnkAtras;
        private MetroFramework.Controls.MetroLink lnkSiguiente;
        private System.Windows.Forms.GroupBox gbRangos;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel pnlRangoNum;
        private MetroFramework.Controls.MetroTextBox txblbl;
        private MetroFramework.Controls.MetroPanel pnlRangoFec;
        private MetroFramework.Controls.MetroDateTime dtRangoFecTo;
        private MetroFramework.Controls.MetroDateTime dtRangoFecFrom;
        private MetroFramework.Controls.MetroPanel pnlRangoRVC;
        private MetroFramework.Controls.MetroLabel lblRangofec;
        private MetroFramework.Controls.MetroLabel lbl;
        private MetroFramework.Controls.MetroLabel lblrangoRVC;
        private MetroFramework.Controls.MetroLabel lblHacia;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private System.Windows.Forms.TextBox txbIDRVCinicio;
        private System.Windows.Forms.TextBox txbIDRVCfin;
        private MetroFramework.Controls.MetroTextBox txtRangoRvcDesd;
        private MetroFramework.Controls.MetroTextBox txtRangoRvcA;
    }
}
