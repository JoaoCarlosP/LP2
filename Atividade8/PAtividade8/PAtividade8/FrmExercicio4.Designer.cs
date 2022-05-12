
namespace PAtividade8
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtProdução = new System.Windows.Forms.TextBox();
            this.lblProdução = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtGratificacao = new System.Windows.Forms.TextBox();
            this.lblGratificação = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.cbxCargo = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 36);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(215, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(17, 66);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(48, 16);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(20, 136);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(215, 22);
            this.txtMatricula.TabIndex = 5;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(17, 117);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(135, 16);
            this.lblMatricula.TabIndex = 4;
            this.lblMatricula.Text = "Número da matrícula:";
            // 
            // txtProdução
            // 
            this.txtProdução.Location = new System.Drawing.Point(266, 36);
            this.txtProdução.Name = "txtProdução";
            this.txtProdução.Size = new System.Drawing.Size(161, 22);
            this.txtProdução.TabIndex = 7;
            // 
            // lblProdução
            // 
            this.lblProdução.AutoSize = true;
            this.lblProdução.Location = new System.Drawing.Point(263, 17);
            this.lblProdução.Name = "lblProdução";
            this.lblProdução.Size = new System.Drawing.Size(164, 16);
            this.lblProdução.TabIndex = 6;
            this.lblProdução.Text = "Número da sua produção:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(266, 85);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.ReadOnly = true;
            this.txtSalario.Size = new System.Drawing.Size(161, 22);
            this.txtSalario.TabIndex = 9;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(263, 66);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(79, 16);
            this.lblSalario.TabIndex = 8;
            this.lblSalario.Text = "Seu salário:";
            // 
            // txtGratificacao
            // 
            this.txtGratificacao.Location = new System.Drawing.Point(266, 136);
            this.txtGratificacao.Name = "txtGratificacao";
            this.txtGratificacao.Size = new System.Drawing.Size(161, 22);
            this.txtGratificacao.TabIndex = 11;
            // 
            // lblGratificação
            // 
            this.lblGratificação.AutoSize = true;
            this.lblGratificação.Location = new System.Drawing.Point(263, 117);
            this.lblGratificação.Name = "lblGratificação";
            this.lblGratificação.Size = new System.Drawing.Size(108, 16);
            this.lblGratificação.TabIndex = 10;
            this.lblGratificação.Text = "Sua gratificação:";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(124, 207);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(155, 41);
            this.btnCalculo.TabIndex = 12;
            this.btnCalculo.Text = "Calcular Salário bruto:";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(17, 180);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(87, 16);
            this.lblResposta.TabIndex = 13;
            this.lblResposta.Text = "Salário bruto:";
            // 
            // cbxCargo
            // 
            this.cbxCargo.FormattingEnabled = true;
            this.cbxCargo.Items.AddRange(new object[] {
            "Desenvolvedor PHP Júnior",
            "Desenvolvedor PHP Pleno",
            "Desenvolvedor PHP Sênior",
            "Engenheiro de Software Júnior",
            "Engenheiro de Software Pleno",
            "Engenheiro de Software Sênior",
            "Estagiário de Web Developer"});
            this.cbxCargo.Location = new System.Drawing.Point(20, 85);
            this.cbxCargo.Name = "cbxCargo";
            this.cbxCargo.Size = new System.Drawing.Size(215, 24);
            this.cbxCargo.TabIndex = 14;
            this.cbxCargo.SelectedIndexChanged += new System.EventHandler(this.cbxCargo_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(320, 207);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 41);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Limpar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 260);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbxCargo);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.txtGratificacao);
            this.Controls.Add(this.lblGratificação);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtProdução);
            this.Controls.Add(this.lblProdução);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmExercicio4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FrmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtProdução;
        private System.Windows.Forms.Label lblProdução;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtGratificacao;
        private System.Windows.Forms.Label lblGratificação;
        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.ComboBox cbxCargo;
        private System.Windows.Forms.Button btnClose;
    }
}