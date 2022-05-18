
namespace PAtividade9
{
    partial class FrmExercicio4
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
            this.btnClique = new System.Windows.Forms.Button();
            this.lblComentario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClique
            // 
            this.btnClique.Location = new System.Drawing.Point(209, 147);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(100, 40);
            this.btnClique.TabIndex = 0;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(113, 98);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(301, 13);
            this.lblComentario.TabIndex = 12;
            this.lblComentario.Text = "Exercício 4: Excluir o nome \"Otávio\" da lista de nomes e exibir";
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 223);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.btnClique);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.Label lblComentario;
    }
}