
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
            this.lblFrase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClique
            // 
            this.btnClique.Location = new System.Drawing.Point(178, 149);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(100, 40);
            this.btnClique.TabIndex = 0;
            this.btnClique.Text = "Clique";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase.Location = new System.Drawing.Point(124, 70);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(226, 20);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Exercício utilizando \'.Remove()\'";
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 223);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.btnClique);
            this.Name = "FrmExercicio4";
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.Label lblFrase;
    }
}