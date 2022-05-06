
namespace PtesteMetodos
{
    partial class formExercicio4
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
            this.rchtxtFrase = new System.Windows.Forms.RichTextBox();
            this.btnQtdeNumero = new System.Windows.Forms.Button();
            this.btnPosicaoCaracterBranco = new System.Windows.Forms.Button();
            this.btnQtdeAlfabetico = new System.Windows.Forms.Button();
            this.lblFrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(25, 47);
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(348, 73);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnQtdeNumero
            // 
            this.btnQtdeNumero.Location = new System.Drawing.Point(12, 155);
            this.btnQtdeNumero.Name = "btnQtdeNumero";
            this.btnQtdeNumero.Size = new System.Drawing.Size(116, 49);
            this.btnQtdeNumero.TabIndex = 1;
            this.btnQtdeNumero.Text = "Qtde de caracter numérico";
            this.btnQtdeNumero.UseVisualStyleBackColor = true;
            this.btnQtdeNumero.Click += new System.EventHandler(this.btnQtdeNumero_Click);
            // 
            // btnPosicaoCaracterBranco
            // 
            this.btnPosicaoCaracterBranco.Location = new System.Drawing.Point(145, 155);
            this.btnPosicaoCaracterBranco.Name = "btnPosicaoCaracterBranco";
            this.btnPosicaoCaracterBranco.Size = new System.Drawing.Size(116, 49);
            this.btnPosicaoCaracterBranco.TabIndex = 2;
            this.btnPosicaoCaracterBranco.Text = "Posição do 1º caracter branco";
            this.btnPosicaoCaracterBranco.UseVisualStyleBackColor = true;
            this.btnPosicaoCaracterBranco.Click += new System.EventHandler(this.btnPosicaoCaracterBranco_Click);
            // 
            // btnQtdeAlfabetico
            // 
            this.btnQtdeAlfabetico.Location = new System.Drawing.Point(276, 155);
            this.btnQtdeAlfabetico.Name = "btnQtdeAlfabetico";
            this.btnQtdeAlfabetico.Size = new System.Drawing.Size(116, 49);
            this.btnQtdeAlfabetico.TabIndex = 3;
            this.btnQtdeAlfabetico.Text = "Qtde de caracter alfabético";
            this.btnQtdeAlfabetico.UseVisualStyleBackColor = true;
            this.btnQtdeAlfabetico.Click += new System.EventHandler(this.btnQtdeAlfabetico_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(22, 28);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(175, 16);
            this.lblFrase.TabIndex = 4;
            this.lblFrase.Text = "Insira um texto ou uma frase:";
            // 
            // formExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 247);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.btnQtdeAlfabetico);
            this.Controls.Add(this.btnPosicaoCaracterBranco);
            this.Controls.Add(this.btnQtdeNumero);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "formExercicio4";
            this.Text = "formExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnQtdeNumero;
        private System.Windows.Forms.Button btnPosicaoCaracterBranco;
        private System.Windows.Forms.Button btnQtdeAlfabetico;
        private System.Windows.Forms.Label lblFrase;
    }
}