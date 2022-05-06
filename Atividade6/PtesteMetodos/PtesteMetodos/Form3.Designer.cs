
namespace PtesteMetodos
{
    partial class formExercicio3
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
            this.btnInverte = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInverte
            // 
            this.btnInverte.Location = new System.Drawing.Point(309, 161);
            this.btnInverte.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnInverte.Name = "btnInverte";
            this.btnInverte.Size = new System.Drawing.Size(111, 59);
            this.btnInverte.TabIndex = 13;
            this.btnInverte.Text = "Inverte";
            this.btnInverte.UseVisualStyleBackColor = true;
            this.btnInverte.Click += new System.EventHandler(this.btnInverte_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(172, 161);
            this.btnRemove2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(111, 58);
            this.btnRemove2.TabIndex = 12;
            this.btnRemove2.Text = "Remove Ocorrências (replace)";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnRemove1
            // 
            this.btnRemove1.Location = new System.Drawing.Point(35, 161);
            this.btnRemove1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(111, 59);
            this.btnRemove1.TabIndex = 11;
            this.btnRemove1.Text = "Remove Ocorrências";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(35, 104);
            this.txtPalavra2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(344, 22);
            this.txtPalavra2.TabIndex = 10;
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(32, 83);
            this.lblPalavra2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(68, 16);
            this.lblPalavra2.TabIndex = 9;
            this.lblPalavra2.Text = "Palavra 2:";
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(35, 49);
            this.txtPalavra1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(344, 22);
            this.txtPalavra1.TabIndex = 8;
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(32, 27);
            this.lblPalavra1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(68, 16);
            this.lblPalavra1.TabIndex = 7;
            this.lblPalavra1.Text = "Palavra 1:";
            // 
            // formExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 270);
            this.Controls.Add(this.btnInverte);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnRemove1);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Controls.Add(this.lblPalavra1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formExercicio3";
            this.Text = "formExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInverte;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.Label lblPalavra1;
    }
}