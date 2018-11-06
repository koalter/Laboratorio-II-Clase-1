namespace Ejercicio_Threads_2
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
            this.labelReloj = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // labelReloj
            // 
            this.labelReloj.AutoSize = true;
            this.labelReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReloj.Location = new System.Drawing.Point(291, 9);
            this.labelReloj.Name = "labelReloj";
            this.labelReloj.Size = new System.Drawing.Size(36, 20);
            this.labelReloj.TabIndex = 0;
            this.labelReloj.Text = "100";
            this.labelReloj.Visible = false;
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(270, 129);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Maroon;
            this.pb.Location = new System.Drawing.Point(-10, -8);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(10, 10);
            this.pb.TabIndex = 2;
            this.pb.TabStop = false;
            this.pb.Visible = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 287);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.labelReloj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelReloj;
        private System.Windows.Forms.Button btnComenzar;
        public System.Windows.Forms.PictureBox pb;
    }
}

