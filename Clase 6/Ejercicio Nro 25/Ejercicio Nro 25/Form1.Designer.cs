namespace Ejercicio_Nro_25
{
    partial class Form1
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
            this.lblBinarioDecimal = new System.Windows.Forms.Label();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.lblDecimalBinario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBinarioDecimal
            // 
            this.lblBinarioDecimal.AutoSize = true;
            this.lblBinarioDecimal.Location = new System.Drawing.Point(11, 38);
            this.lblBinarioDecimal.Name = "lblBinarioDecimal";
            this.lblBinarioDecimal.Size = new System.Drawing.Size(89, 13);
            this.lblBinarioDecimal.TabIndex = 0;
            this.lblBinarioDecimal.Text = "Binario a Decimal";
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(106, 35);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(100, 20);
            this.txtBinario.TabIndex = 1;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(212, 33);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(75, 23);
            this.btnBinToDec.TabIndex = 2;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtResultadoDec.Location = new System.Drawing.Point(293, 35);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoDec.TabIndex = 3;
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Location = new System.Drawing.Point(293, 68);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(100, 20);
            this.txtResultadoBin.TabIndex = 7;
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(212, 66);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(75, 23);
            this.btnDecToBin.TabIndex = 6;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(106, 68);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 5;
            // 
            // lblDecimalBinario
            // 
            this.lblDecimalBinario.AutoSize = true;
            this.lblDecimalBinario.Location = new System.Drawing.Point(11, 71);
            this.lblDecimalBinario.Name = "lblDecimalBinario";
            this.lblDecimalBinario.Size = new System.Drawing.Size(89, 13);
            this.lblDecimalBinario.TabIndex = 4;
            this.lblDecimalBinario.Text = "Decimal a Binario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 115);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.lblDecimalBinario);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.lblBinarioDecimal);
            this.Name = "Form1";
            this.Text = "Conversor numérico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBinarioDecimal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.TextBox txtResultadoDec;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label lblDecimalBinario;
    }
}

