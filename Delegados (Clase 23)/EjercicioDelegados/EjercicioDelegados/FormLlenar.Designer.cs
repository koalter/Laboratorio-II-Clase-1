namespace EjercicioDelegados
{
    partial class FormLlenar
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
            this.txtLlenar = new System.Windows.Forms.TextBox();
            this.btnLlenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLlenar
            // 
            this.txtLlenar.Location = new System.Drawing.Point(100, 75);
            this.txtLlenar.Name = "txtLlenar";
            this.txtLlenar.Size = new System.Drawing.Size(100, 20);
            this.txtLlenar.TabIndex = 0;
            // 
            // btnLlenar
            // 
            this.btnLlenar.Location = new System.Drawing.Point(113, 115);
            this.btnLlenar.Name = "btnLlenar";
            this.btnLlenar.Size = new System.Drawing.Size(75, 23);
            this.btnLlenar.TabIndex = 1;
            this.btnLlenar.Text = "Llenar";
            this.btnLlenar.UseVisualStyleBackColor = true;
            this.btnLlenar.Click += new System.EventHandler(this.btnLlenar_Click);
            // 
            // FormLlenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 202);
            this.Controls.Add(this.btnLlenar);
            this.Controls.Add(this.txtLlenar);
            this.Name = "FormLlenar";
            this.Text = "FormLlenar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLlenar;
        private System.Windows.Forms.Button btnLlenar;
    }
}