
namespace PAtividade9
{
    partial class FrmExercicio6
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
            this.lstbxLista = new System.Windows.Forms.ListBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lblComentario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxLista
            // 
            this.lstbxLista.FormattingEnabled = true;
            this.lstbxLista.Location = new System.Drawing.Point(190, 53);
            this.lstbxLista.Name = "lstbxLista";
            this.lstbxLista.Size = new System.Drawing.Size(299, 160);
            this.lstbxLista.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(52, 110);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(98, 43);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(12, 263);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(481, 13);
            this.lblComentario.TabIndex = 2;
            this.lblComentario.Text = "Exercício 6: Verificar a quantidade de caracteres em um nome, inserindo o resulta" +
    "do em uma ListBox";
            // 
            // FrmExercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 342);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lstbxLista);
            this.Name = "FrmExercicio6";
            this.Text = "FrmExercicio6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxLista;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Label lblComentario;
    }
}