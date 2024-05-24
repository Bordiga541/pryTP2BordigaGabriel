namespace pryTP2BordigaGabriel
{
    partial class frmMain
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
            this.cmdVerLogs = new System.Windows.Forms.Button();
            this.cmdCrearUsuarios = new System.Windows.Forms.Button();
            this.cmdPantallaDeReporte = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdVerLogs
            // 
            this.cmdVerLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVerLogs.Location = new System.Drawing.Point(12, 12);
            this.cmdVerLogs.Name = "cmdVerLogs";
            this.cmdVerLogs.Size = new System.Drawing.Size(236, 61);
            this.cmdVerLogs.TabIndex = 0;
            this.cmdVerLogs.Text = "VER LOGS";
            this.cmdVerLogs.UseVisualStyleBackColor = true;
            this.cmdVerLogs.Click += new System.EventHandler(this.cmdVerLogs_Click);
            // 
            // cmdCrearUsuarios
            // 
            this.cmdCrearUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrearUsuarios.Location = new System.Drawing.Point(12, 109);
            this.cmdCrearUsuarios.Name = "cmdCrearUsuarios";
            this.cmdCrearUsuarios.Size = new System.Drawing.Size(236, 61);
            this.cmdCrearUsuarios.TabIndex = 0;
            this.cmdCrearUsuarios.Text = "CREAR USUARIOS";
            this.cmdCrearUsuarios.UseVisualStyleBackColor = true;
            this.cmdCrearUsuarios.Click += new System.EventHandler(this.cmdCrearUsuarios_Click);
            // 
            // cmdPantallaDeReporte
            // 
            this.cmdPantallaDeReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPantallaDeReporte.Location = new System.Drawing.Point(12, 207);
            this.cmdPantallaDeReporte.Name = "cmdPantallaDeReporte";
            this.cmdPantallaDeReporte.Size = new System.Drawing.Size(236, 61);
            this.cmdPantallaDeReporte.TabIndex = 0;
            this.cmdPantallaDeReporte.Text = "PANTALLA DE REPORTES";
            this.cmdPantallaDeReporte.UseVisualStyleBackColor = true;
            this.cmdPantallaDeReporte.Click += new System.EventHandler(this.cmdPantallaDeReporte_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 308);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(236, 61);
            this.cmdSalir.TabIndex = 0;
            this.cmdSalir.Text = "SALIR";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 382);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdPantallaDeReporte);
            this.Controls.Add(this.cmdCrearUsuarios);
            this.Controls.Add(this.cmdVerLogs);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdVerLogs;
        private System.Windows.Forms.Button cmdCrearUsuarios;
        private System.Windows.Forms.Button cmdPantallaDeReporte;
        private System.Windows.Forms.Button cmdSalir;
    }
}