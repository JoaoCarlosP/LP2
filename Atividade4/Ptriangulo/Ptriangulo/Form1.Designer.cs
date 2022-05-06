
namespace Ptriangulo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLadoA = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Location = new System.Drawing.Point(39, 36);
            this.lblLadoA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(96, 16);
            this.lblLadoA.TabIndex = 0;
            this.lblLadoA.Text = "Insira o lado A:";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(42, 56);
            this.txtLadoA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(145, 22);
            this.txtLadoA.TabIndex = 1;
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(43, 114);
            this.txtLadoB.Margin = new System.Windows.Forms.Padding(4);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(145, 22);
            this.txtLadoB.TabIndex = 3;
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Location = new System.Drawing.Point(39, 94);
            this.lblLadoB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(96, 16);
            this.lblLadoB.TabIndex = 2;
            this.lblLadoB.Text = "Insira o lado B:";
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(42, 171);
            this.txtLadoC.Margin = new System.Windows.Forms.Padding(4);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(145, 22);
            this.txtLadoC.TabIndex = 5;
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Location = new System.Drawing.Point(38, 151);
            this.lblLadoC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(96, 16);
            this.lblLadoC.TabIndex = 4;
            this.lblLadoC.Text = "Insira o lado C:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(70, 228);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(80, 22);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 289);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.lblLadoA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.Button btnVerificar;
    }
}

