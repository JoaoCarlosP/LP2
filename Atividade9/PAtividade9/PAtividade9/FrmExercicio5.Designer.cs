
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
            this.rchtxtTela1 = new System.Windows.Forms.RichTextBox();
            this.rchtxtTela2 = new System.Windows.Forms.RichTextBox();
            this.rchtxtTela3 = new System.Windows.Forms.RichTextBox();
            this.rchtxtTela4 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnCalcMedia
            // 
            this.btnCalcMedia.Location = new System.Drawing.Point(350, 128);
            this.btnCalcMedia.Name = "btnCalcMedia";
            this.btnCalcMedia.Size = new System.Drawing.Size(100, 40);
            this.btnCalcMedia.TabIndex = 1;
            this.btnCalcMedia.Text = "Calcular média";
            this.btnCalcMedia.UseVisualStyleBackColor = true;
            this.btnCalcMedia.Click += new System.EventHandler(this.btnCalcMedia_Click);
            // 
            // rchtxtTela1
            // 
            this.rchtxtTela1.Location = new System.Drawing.Point(4, 12);
            this.rchtxtTela1.Name = "rchtxtTela1";
            this.rchtxtTela1.ReadOnly = true;
            this.rchtxtTela1.Size = new System.Drawing.Size(108, 275);
            this.rchtxtTela1.TabIndex = 2;
            this.rchtxtTela1.Text = "";
            // 
            // rchtxtTela2
            // 
            this.rchtxtTela2.Location = new System.Drawing.Point(110, 12);
            this.rchtxtTela2.Name = "rchtxtTela2";
            this.rchtxtTela2.ReadOnly = true;
            this.rchtxtTela2.Size = new System.Drawing.Size(75, 275);
            this.rchtxtTela2.TabIndex = 3;
            this.rchtxtTela2.Text = "";
            // 
            // rchtxtTela3
            // 
            this.rchtxtTela3.Location = new System.Drawing.Point(183, 12);
            this.rchtxtTela3.Name = "rchtxtTela3";
            this.rchtxtTela3.ReadOnly = true;
            this.rchtxtTela3.Size = new System.Drawing.Size(75, 275);
            this.rchtxtTela3.TabIndex = 4;
            this.rchtxtTela3.Text = "";
            // 
            // rchtxtTela4
            // 
            this.rchtxtTela4.Location = new System.Drawing.Point(255, 12);
            this.rchtxtTela4.Name = "rchtxtTela4";
            this.rchtxtTela4.ReadOnly = true;
            this.rchtxtTela4.Size = new System.Drawing.Size(83, 275);
            this.rchtxtTela4.TabIndex = 5;
            this.rchtxtTela4.Text = "";
            // 
            // FrmExercicio5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 309);
            this.Controls.Add(this.rchtxtTela4);
            this.Controls.Add(this.rchtxtTela3);
            this.Controls.Add(this.rchtxtTela2);
            this.Controls.Add(this.rchtxtTela1);
            this.Controls.Add(this.btnCalcMedia);
            this.Name = "FrmExercicio5";
            this.Text = "FrmExercicio5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcMedia;
        private System.Windows.Forms.RichTextBox rchtxtTela1;
        private System.Windows.Forms.RichTextBox rchtxtTela2;
        private System.Windows.Forms.RichTextBox rchtxtTela3;
        private System.Windows.Forms.RichTextBox rchtxtTela4;
    }
}