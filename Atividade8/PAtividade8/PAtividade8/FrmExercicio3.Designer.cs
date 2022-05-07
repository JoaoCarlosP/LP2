
namespace PAtividade8
{
    partial class FrmExercicio3
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
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblFrase = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(25, 36);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(134, 20);
            this.txtFrase.TabIndex = 0;
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(22, 20);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(134, 13);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Insira uma frase ou palavra";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(22, 106);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(55, 13);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.Text = "Resposta:";
            this.lblResposta.Visible = false;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(49, 62);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Click here";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // FrmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 288);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.txtFrase);
            this.Name = "FrmExercicio3";
            this.Text = "FrmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnClick;
    }
}