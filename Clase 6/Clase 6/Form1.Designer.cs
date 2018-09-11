namespace Clase_6
{
    partial class FrmPantalla1
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCascada = new System.Windows.Forms.Button();
            this.btnVertical = new System.Windows.Forms.Button();
            this.btnHorizontal = new System.Windows.Forms.Button();
            this.btnArrange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(31, 94);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "button1";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(31, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 45);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCascada
            // 
            this.btnCascada.Location = new System.Drawing.Point(148, 12);
            this.btnCascada.Name = "btnCascada";
            this.btnCascada.Size = new System.Drawing.Size(75, 23);
            this.btnCascada.TabIndex = 3;
            this.btnCascada.Text = "Cascada";
            this.btnCascada.UseVisualStyleBackColor = true;
            this.btnCascada.Click += new System.EventHandler(this.btnCascada_Click);
            // 
            // btnVertical
            // 
            this.btnVertical.Location = new System.Drawing.Point(148, 63);
            this.btnVertical.Name = "btnVertical";
            this.btnVertical.Size = new System.Drawing.Size(75, 23);
            this.btnVertical.TabIndex = 4;
            this.btnVertical.Text = "Vertical";
            this.btnVertical.UseVisualStyleBackColor = true;
            this.btnVertical.Click += new System.EventHandler(this.btnVertical_Click);
            // 
            // btnHorizontal
            // 
            this.btnHorizontal.Location = new System.Drawing.Point(148, 111);
            this.btnHorizontal.Name = "btnHorizontal";
            this.btnHorizontal.Size = new System.Drawing.Size(75, 23);
            this.btnHorizontal.TabIndex = 5;
            this.btnHorizontal.Text = "Horizontal";
            this.btnHorizontal.UseVisualStyleBackColor = true;
            this.btnHorizontal.Click += new System.EventHandler(this.btnHorizontal_Click);
            // 
            // btnArrange
            // 
            this.btnArrange.Location = new System.Drawing.Point(148, 154);
            this.btnArrange.Name = "btnArrange";
            this.btnArrange.Size = new System.Drawing.Size(75, 23);
            this.btnArrange.TabIndex = 6;
            this.btnArrange.Text = "Arrange";
            this.btnArrange.UseVisualStyleBackColor = true;
            this.btnArrange.Click += new System.EventHandler(this.btnArrange_Click);
            // 
            // FrmPantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 274);
            this.Controls.Add(this.btnArrange);
            this.Controls.Add(this.btnHorizontal);
            this.Controls.Add(this.btnVertical);
            this.Controls.Add(this.btnCascada);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnSalir);
            this.IsMdiContainer = true;
            this.Name = "FrmPantalla1";
            this.Text = "FrmPantalla1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCascada;
        private System.Windows.Forms.Button btnVertical;
        private System.Windows.Forms.Button btnHorizontal;
        private System.Windows.Forms.Button btnArrange;
    }
}

