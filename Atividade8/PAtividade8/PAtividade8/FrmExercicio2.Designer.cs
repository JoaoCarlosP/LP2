
namespace PAtividade8
{
    partial class FrmExercicio2
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
            this.btnValorH = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumeroInserido = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValorH
            // 
            this.btnValorH.Location = new System.Drawing.Point(28, 69);
            this.btnValorH.Name = "btnValorH";
            this.btnValorH.Size = new System.Drawing.Size(98, 27);
            this.btnValorH.TabIndex = 0;
            this.btnValorH.Text = "Valor da soma";
            this.btnValorH.UseVisualStyleBackColor = true;
            this.btnValorH.Click += new System.EventHandler(this.btnValorH_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(25, 14);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(90, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Insira um número:";
            // 
            // txtNumeroInserido
            // 
            this.txtNumeroInserido.Location = new System.Drawing.Point(28, 30);
            this.txtNumeroInserido.Name = "txtNumeroInserido";
            this.txtNumeroInserido.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroInserido.TabIndex = 2;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(12, 140);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(55, 13);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Text = "Resposta:";
            this.lblResposta.UseWaitCursor = true;
            this.lblResposta.Visible = false;
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 176);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.txtNumeroInserido);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnValorH);
            this.Name = "FrmExercicio2";
            this.Text = "FrmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValorH;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumeroInserido;
        private System.Windows.Forms.Label lblResposta;
    }
}