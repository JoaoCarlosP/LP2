
namespace PAtividade9
{
    partial class FrmExercicio5
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
            this.btnCalcMedia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcMedia
            // 
            this.btnCalcMedia.Location = new System.Drawing.Point(188, 178);
            this.btnCalcMedia.Name = "btnCalcMedia";
            this.btnCalcMedia.Size = new System.Drawing.Size(100, 40);
            this.btnCalcMedia.TabIndex = 1;
            this.btnCalcMedia.Text = "Calcular média";
            this.btnCalcMedia.UseVisualStyleBackColor = true;
            this.btnCalcMedia.Click += new System.EventHandler(this.btnCalcMedia_Click);
            // 
            // FrmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 230);
            this.Controls.Add(this.btnCalcMedia);
            this.Name = "FrmExercicio5";
            this.Text = "FrmExercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcMedia;
    }
}