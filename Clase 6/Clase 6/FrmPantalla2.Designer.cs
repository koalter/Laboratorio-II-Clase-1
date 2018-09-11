namespace Clase_6
{
    partial class FrmPantalla2
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
            this.chkEnviaPublicidad = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grbNacionalidad = new System.Windows.Forms.GroupBox();
            this.rdoExtranjero = new System.Windows.Forms.RadioButton();
            this.rdoArgentino = new System.Windows.Forms.RadioButton();
            this.lstPosicion = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbNacionalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEnviaPublicidad
            // 
            this.chkEnviaPublicidad.AutoSize = true;
            this.chkEnviaPublicidad.Checked = true;
            this.chkEnviaPublicidad.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkEnviaPublicidad.Location = new System.Drawing.Point(12, 12);
            this.chkEnviaPublicidad.Name = "chkEnviaPublicidad";
            this.chkEnviaPublicidad.Size = new System.Drawing.Size(105, 17);
            this.chkEnviaPublicidad.TabIndex = 0;
            this.chkEnviaPublicidad.Text = "Envia Publicidad";
            this.chkEnviaPublicidad.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(346, 183);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grbNacionalidad
            // 
            this.grbNacionalidad.Controls.Add(this.rdoExtranjero);
            this.grbNacionalidad.Controls.Add(this.rdoArgentino);
            this.grbNacionalidad.Location = new System.Drawing.Point(12, 40);
            this.grbNacionalidad.Name = "grbNacionalidad";
            this.grbNacionalidad.Size = new System.Drawing.Size(105, 72);
            this.grbNacionalidad.TabIndex = 2;
            this.grbNacionalidad.TabStop = false;
            this.grbNacionalidad.Text = "Nacionalidad";
            // 
            // rdoExtranjero
            // 
            this.rdoExtranjero.AutoSize = true;
            this.rdoExtranjero.Location = new System.Drawing.Point(14, 42);
            this.rdoExtranjero.Name = "rdoExtranjero";
            this.rdoExtranjero.Size = new System.Drawing.Size(72, 17);
            this.rdoExtranjero.TabIndex = 1;
            this.rdoExtranjero.TabStop = true;
            this.rdoExtranjero.Text = "Extranjero";
            this.rdoExtranjero.UseVisualStyleBackColor = true;
            // 
            // rdoArgentino
            // 
            this.rdoArgentino.AutoSize = true;
            this.rdoArgentino.Location = new System.Drawing.Point(14, 19);
            this.rdoArgentino.Name = "rdoArgentino";
            this.rdoArgentino.Size = new System.Drawing.Size(70, 17);
            this.rdoArgentino.TabIndex = 0;
            this.rdoArgentino.TabStop = true;
            this.rdoArgentino.Text = "Argentino";
            this.rdoArgentino.UseVisualStyleBackColor = true;
            // 
            // lstPosicion
            // 
            this.lstPosicion.FormattingEnabled = true;
            this.lstPosicion.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero",
            "Cuarto",
            "Quinto",
            "Sexto",
            "Septimo"});
            this.lstPosicion.Location = new System.Drawing.Point(132, 12);
            this.lstPosicion.Name = "lstPosicion";
            this.lstPosicion.Size = new System.Drawing.Size(120, 95);
            this.lstPosicion.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(9, 148);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 164);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(105, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco"});
            this.comboBox1.Location = new System.Drawing.Point(12, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // FrmPantalla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 218);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lstPosicion);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grbNacionalidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.chkEnviaPublicidad);
            this.Name = "FrmPantalla2";
            this.Text = "FrmPantalla2";
            this.Load += new System.EventHandler(this.FrmPantalla2_Load);
            this.grbNacionalidad.ResumeLayout(false);
            this.grbNacionalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkEnviaPublicidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grbNacionalidad;
        private System.Windows.Forms.RadioButton rdoExtranjero;
        private System.Windows.Forms.RadioButton rdoArgentino;
        private System.Windows.Forms.ListBox lstPosicion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}