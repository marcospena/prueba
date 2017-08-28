namespace EagleReports
{
    partial class FormularioEagleReports
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
            this.pnlEagleReport = new MetroFramework.Controls.MetroPanel();
            this.SuspendLayout();
            // 
            // pnlEagleReport
            // 
            this.pnlEagleReport.HorizontalScrollbarBarColor = true;
            this.pnlEagleReport.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlEagleReport.HorizontalScrollbarSize = 10;
            this.pnlEagleReport.Location = new System.Drawing.Point(23, 63);
            this.pnlEagleReport.Name = "pnlEagleReport";
            this.pnlEagleReport.Size = new System.Drawing.Size(554, 314);
            this.pnlEagleReport.TabIndex = 0;
            this.pnlEagleReport.VerticalScrollbarBarColor = true;
            this.pnlEagleReport.VerticalScrollbarHighlightOnWheel = false;
            this.pnlEagleReport.VerticalScrollbarSize = 10;
            // 
            // FormularioEagleReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pnlEagleReport);
            this.Name = "FormularioEagleReports";
            this.Resizable = false;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FormularioEagleReports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlEagleReport;
    }
}