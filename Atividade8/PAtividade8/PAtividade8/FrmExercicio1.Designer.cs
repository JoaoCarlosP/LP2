
namespace PAtividade8
{
    partial class FrmExercicio1
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
            this.btnQtdeEspacoBranco = new System.Windows.Forms.Button();
            this.btnQtdeLetraR = new System.Windows.Forms.Button();
            this.btnQtdeDePar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtFrase
            // 
            this.rchtxtFrase.Location = new System.Drawing.Point(26, 29);
            this.rchtxtFrase.MaxLength = 100;
            this.rchtxtFrase.Name = "rchtxtFrase";
            this.rchtxtFrase.Size = new System.Drawing.Size(373, 135);
            this.rchtxtFrase.TabIndex = 0;
            this.rchtxtFrase.Text = "";
            // 
            // btnQtdeEspacoBranco
            // 
            this.btnQtdeEspacoBranco.Location = new System.Drawing.Point(26, 170);
            this.btnQtdeEspacoBranco.Name = "btnQtdeEspacoBranco";
            this.btnQtdeEspacoBranco.Size = new System.Drawing.Size(116, 48);
            this.btnQtdeEspacoBranco.TabIndex = 1;
            this.btnQtdeEspacoBranco.Text = "Quantidade de Espaços em Branco";
            this.btnQtdeEspacoBranco.UseVisualStyleBackColor = true;
            this.btnQtdeEspacoBranco.Click += new System.EventHandler(this.btnQtdeEspacoBranco_Click);
            // 
            // btnQtdeLetraR
            // 
            this.btnQtdeLetraR.Location = new System.Drawing.Point(148, 170);
            this.btnQtdeLetraR.Name = "btnQtdeLetraR";
            this.btnQtdeLetraR.Size = new System.Drawing.Size(116, 48);
            this.btnQtdeLetraR.TabIndex = 2;
            this.btnQtdeLetraR.Text = "Qtde de letras \'R\'";
            this.btnQtdeLetraR.UseVisualStyleBackColor = true;
            this.btnQtdeLetraR.Click += new System.EventHandler(this.btnQtdeLetraR_Click);
            // 
            // btnQtdeDePar
            // 
            this.btnQtdeDePar.Location = new System.Drawing.Point(270, 170);
            this.btnQtdeDePar.Name = "btnQtdeDePar";
            this.btnQtdeDePar.Size = new System.Drawing.Size(116, 48);
            this.btnQtdeDePar.TabIndex = 3;
            this.btnQtdeDePar.Text = "Qtde de par da mesma letra";
            this.btnQtdeDePar.UseVisualStyleBackColor = true;
            this.btnQtdeDePar.Click += new System.EventHandler(this.btnQtdeDePar_Click);
            // 
            // FrmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 245);
            this.Controls.Add(this.btnQtdeDePar);
            this.Controls.Add(this.btnQtdeLetraR);
            this.Controls.Add(this.btnQtdeEspacoBranco);
            this.Controls.Add(this.rchtxtFrase);
            this.Name = "FrmExercicio1";
            this.Text = "FrmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchtxtFrase;
        private System.Windows.Forms.Button btnQtdeEspacoBranco;
        private System.Windows.Forms.Button btnQtdeLetraR;
        private System.Windows.Forms.Button btnQtdeDePar;
    }
}