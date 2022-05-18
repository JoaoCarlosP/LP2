
namespace PAtividade9
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
            this.btnCalculoFaturamento = new System.Windows.Forms.Button();
            this.rchtxtQuantidade = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.rchtxtValorUnitario = new System.Windows.Forms.RichTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.rchtxtValorTotal = new System.Windows.Forms.RichTextBox();
            this.txtFaturamentoTotal = new System.Windows.Forms.TextBox();
            this.lblFaturamentoTotal = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculoFaturamento
            // 
            this.btnCalculoFaturamento.Location = new System.Drawing.Point(145, 205);
            this.btnCalculoFaturamento.Name = "btnCalculoFaturamento";
            this.btnCalculoFaturamento.Size = new System.Drawing.Size(114, 50);
            this.btnCalculoFaturamento.TabIndex = 0;
            this.btnCalculoFaturamento.Text = "Calcular faturamento";
            this.btnCalculoFaturamento.UseVisualStyleBackColor = true;
            this.btnCalculoFaturamento.Click += new System.EventHandler(this.btnCalculoFaturamento_Click);
            // 
            // rchtxtQuantidade
            // 
            this.rchtxtQuantidade.Location = new System.Drawing.Point(31, 27);
            this.rchtxtQuantidade.Name = "rchtxtQuantidade";
            this.rchtxtQuantidade.ReadOnly = true;
            this.rchtxtQuantidade.Size = new System.Drawing.Size(85, 170);
            this.rchtxtQuantidade.TabIndex = 1;
            this.rchtxtQuantidade.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade";
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(128, 11);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(70, 13);
            this.lblValorUnitario.TabIndex = 4;
            this.lblValorUnitario.Text = "Valor Unitário";
            // 
            // rchtxtValorUnitario
            // 
            this.rchtxtValorUnitario.Location = new System.Drawing.Point(122, 27);
            this.rchtxtValorUnitario.Name = "rchtxtValorUnitario";
            this.rchtxtValorUnitario.ReadOnly = true;
            this.rchtxtValorUnitario.Size = new System.Drawing.Size(85, 170);
            this.rchtxtValorUnitario.TabIndex = 3;
            this.rchtxtValorUnitario.Text = "";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(227, 11);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(58, 13);
            this.lblValorTotal.TabIndex = 6;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // rchtxtValorTotal
            // 
            this.rchtxtValorTotal.Location = new System.Drawing.Point(213, 27);
            this.rchtxtValorTotal.Name = "rchtxtValorTotal";
            this.rchtxtValorTotal.ReadOnly = true;
            this.rchtxtValorTotal.Size = new System.Drawing.Size(85, 170);
            this.rchtxtValorTotal.TabIndex = 5;
            this.rchtxtValorTotal.Text = "";
            // 
            // txtFaturamentoTotal
            // 
            this.txtFaturamentoTotal.Location = new System.Drawing.Point(326, 102);
            this.txtFaturamentoTotal.Name = "txtFaturamentoTotal";
            this.txtFaturamentoTotal.ReadOnly = true;
            this.txtFaturamentoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtFaturamentoTotal.TabIndex = 7;
            // 
            // lblFaturamentoTotal
            // 
            this.lblFaturamentoTotal.AutoSize = true;
            this.lblFaturamentoTotal.Location = new System.Drawing.Point(326, 86);
            this.lblFaturamentoTotal.Name = "lblFaturamentoTotal";
            this.lblFaturamentoTotal.Size = new System.Drawing.Size(92, 13);
            this.lblFaturamentoTotal.TabIndex = 8;
            this.lblFaturamentoTotal.Text = "Faturamento total:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(343, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 267);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblFaturamentoTotal);
            this.Controls.Add(this.txtFaturamentoTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.rchtxtValorTotal);
            this.Controls.Add(this.lblValorUnitario);
            this.Controls.Add(this.rchtxtValorUnitario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rchtxtQuantidade);
            this.Controls.Add(this.btnCalculoFaturamento);
            this.Name = "FrmExercicio2";
            this.Text = "FrmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculoFaturamento;
        private System.Windows.Forms.RichTextBox rchtxtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.RichTextBox rchtxtValorUnitario;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.RichTextBox rchtxtValorTotal;
        private System.Windows.Forms.TextBox txtFaturamentoTotal;
        private System.Windows.Forms.Label lblFaturamentoTotal;
        private System.Windows.Forms.Button btnClear;
    }
}