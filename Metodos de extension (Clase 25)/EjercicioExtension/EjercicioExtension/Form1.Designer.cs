namespace EjercicioExtension
{
    partial class Form1
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
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.boxAlumnos = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgressBar1 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumnos.Location = new System.Drawing.Point(12, 9);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(95, 25);
            this.lblAlumnos.TabIndex = 0;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // boxAlumnos
            // 
            this.boxAlumnos.FormattingEnabled = true;
            this.boxAlumnos.Location = new System.Drawing.Point(17, 37);
            this.boxAlumnos.Name = "boxAlumnos";
            this.boxAlumnos.Size = new System.Drawing.Size(269, 251);
            this.boxAlumnos.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 330);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(356, 23);
            this.progressBar1.TabIndex = 2;
            // 
            // lblProgressBar1
            // 
            this.lblProgressBar1.AutoSize = true;
            this.lblProgressBar1.Location = new System.Drawing.Point(14, 314);
            this.lblProgressBar1.Name = "lblProgressBar1";
            this.lblProgressBar1.Size = new System.Drawing.Size(69, 13);
            this.lblProgressBar1.TabIndex = 3;
            this.lblProgressBar1.Text = "Guardando...";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(298, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 365);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblProgressBar1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.boxAlumnos);
            this.Controls.Add(this.lblAlumnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.ListBox boxAlumnos;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgressBar1;
        private System.Windows.Forms.Button btnNuevo;
    }
}

