
namespace PtesteMetodos
{
    partial class formExercicio5
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
            this.lblPrimeiroNumero = new System.Windows.Forms.Label();
            this.txtPrimeiroNum = new System.Windows.Forms.TextBox();
            this.txtSegundoNum = new System.Windows.Forms.TextBox();
            this.lblSegundoNumero = new System.Windows.Forms.Label();
            this.btnSorteio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrimeiroNumero
            // 
            this.lblPrimeiroNumero.AutoSize = true;
            this.lblPrimeiroNumero.Location = new System.Drawing.Point(29, 28);
            this.lblPrimeiroNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrimeiroNumero.Name = "lblPrimeiroNumero";
            this.lblPrimeiroNumero.Size = new System.Drawing.Size(144, 20);
            this.lblPrimeiroNumero.TabIndex = 0;
            this.lblPrimeiroNumero.Text = "Digite o 1º número:";
            // 
            // txtPrimeiroNum
            // 
            this.txtPrimeiroNum.Location = new System.Drawing.Point(33, 53);
            this.txtPrimeiroNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrimeiroNum.Name = "txtPrimeiroNum";
            this.txtPrimeiroNum.Size = new System.Drawing.Size(164, 26);
            this.txtPrimeiroNum.TabIndex = 1;
            // 
            // txtSegundoNum
            // 
            this.txtSegundoNum.Location = new System.Drawing.Point(33, 121);
            this.txtSegundoNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSegundoNum.Name = "txtSegundoNum";
            this.txtSegundoNum.Size = new System.Drawing.Size(164, 26);
            this.txtSegundoNum.TabIndex = 3;
            // 
            // lblSegundoNumero
            // 
            this.lblSegundoNumero.AutoSize = true;
            this.lblSegundoNumero.Location = new System.Drawing.Point(29, 96);
            this.lblSegundoNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSegundoNumero.Name = "lblSegundoNumero";
            this.lblSegundoNumero.Size = new System.Drawing.Size(144, 20);
            this.lblSegundoNumero.TabIndex = 2;
            this.lblSegundoNumero.Text = "Digite o 2º número:";
            // 
            // btnSorteio
            // 
            this.btnSorteio.Location = new System.Drawing.Point(246, 85);
            this.btnSorteio.Name = "btnSorteio";
            this.btnSorteio.Size = new System.Drawing.Size(146, 43);
            this.btnSorteio.TabIndex = 4;
            this.btnSorteio.Text = "Realizar o sorteio";
            this.btnSorteio.UseVisualStyleBackColor = true;
            this.btnSorteio.Click += new System.EventHandler(this.btnSorteio_Click);
            // 
            // formExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 204);
            this.Controls.Add(this.btnSorteio);
            this.Controls.Add(this.txtSegundoNum);
            this.Controls.Add(this.lblSegundoNumero);
            this.Controls.Add(this.txtPrimeiroNum);
            this.Controls.Add(this.lblPrimeiroNumero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formExercicio5";
            this.Text = "formExercicio5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrimeiroNumero;
        private System.Windows.Forms.TextBox txtPrimeiroNum;
        private System.Windows.Forms.TextBox txtSegundoNum;
        private System.Windows.Forms.Label lblSegundoNumero;
        private System.Windows.Forms.Button btnSorteio;
    }
}