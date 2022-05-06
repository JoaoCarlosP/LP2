
namespace Psalario
{
    partial class frmSalario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.txtAliquotaInss = new System.Windows.Forms.TextBox();
            this.lblAliquotaInss = new System.Windows.Forms.Label();
            this.txtAliquotaIrrf = new System.Windows.Forms.TextBox();
            this.lblAliquotaIrrf = new System.Windows.Forms.Label();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.grpbxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFeminino = new System.Windows.Forms.RadioButton();
            this.pnlCasado = new System.Windows.Forms.Panel();
            this.ckbxCasado = new System.Windows.Forms.CheckBox();
            this.txtDescontoInss = new System.Windows.Forms.TextBox();
            this.lblDescontoInss = new System.Windows.Forms.Label();
            this.txtDescontoIrrf = new System.Windows.Forms.TextBox();
            this.lblDescontoIrrf = new System.Windows.Forms.Label();
            this.cbxNumFilhos = new System.Windows.Forms.ComboBox();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpbxSexo.SuspendLayout();
            this.pnlCasado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(30, 22);
            this.lblNomeFunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(140, 16);
            this.lblNomeFunc.TabIndex = 0;
            this.lblNomeFunc.Text = "Nome do Funcionário:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(33, 42);
            this.txtNomeFunc.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(192, 22);
            this.txtNomeFunc.TabIndex = 1;
            this.txtNomeFunc.Validated += new System.EventHandler(this.txtNomeFunc_Validated);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(33, 95);
            this.txtSalarioBruto.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(192, 22);
            this.txtSalarioBruto.TabIndex = 3;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(29, 75);
            this.lblSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(116, 16);
            this.lblSalarioBruto.TabIndex = 2;
            this.lblSalarioBruto.Text = "Salário Bruto (R$):";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(30, 129);
            this.lblNumFilhos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(117, 16);
            this.lblNumFilhos.TabIndex = 4;
            this.lblNumFilhos.Text = "Número de Filhos:";
            // 
            // btnDesconto
            // 
            this.btnDesconto.Location = new System.Drawing.Point(50, 200);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(136, 29);
            this.btnDesconto.TabIndex = 6;
            this.btnDesconto.Text = "Verificar Desconto";
            this.btnDesconto.UseVisualStyleBackColor = true;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // txtAliquotaInss
            // 
            this.txtAliquotaInss.Enabled = false;
            this.txtAliquotaInss.Location = new System.Drawing.Point(32, 327);
            this.txtAliquotaInss.Margin = new System.Windows.Forms.Padding(4);
            this.txtAliquotaInss.Name = "txtAliquotaInss";
            this.txtAliquotaInss.Size = new System.Drawing.Size(154, 22);
            this.txtAliquotaInss.TabIndex = 8;
            // 
            // lblAliquotaInss
            // 
            this.lblAliquotaInss.AutoSize = true;
            this.lblAliquotaInss.Location = new System.Drawing.Point(31, 307);
            this.lblAliquotaInss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAliquotaInss.Name = "lblAliquotaInss";
            this.lblAliquotaInss.Size = new System.Drawing.Size(122, 16);
            this.lblAliquotaInss.TabIndex = 7;
            this.lblAliquotaInss.Text = "Aliquota INSS (R$):";
            // 
            // txtAliquotaIrrf
            // 
            this.txtAliquotaIrrf.Enabled = false;
            this.txtAliquotaIrrf.Location = new System.Drawing.Point(32, 381);
            this.txtAliquotaIrrf.Margin = new System.Windows.Forms.Padding(4);
            this.txtAliquotaIrrf.Name = "txtAliquotaIrrf";
            this.txtAliquotaIrrf.Size = new System.Drawing.Size(154, 22);
            this.txtAliquotaIrrf.TabIndex = 10;
            // 
            // lblAliquotaIrrf
            // 
            this.lblAliquotaIrrf.AutoSize = true;
            this.lblAliquotaIrrf.Location = new System.Drawing.Point(31, 361);
            this.lblAliquotaIrrf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAliquotaIrrf.Name = "lblAliquotaIrrf";
            this.lblAliquotaIrrf.Size = new System.Drawing.Size(122, 16);
            this.lblAliquotaIrrf.TabIndex = 9;
            this.lblAliquotaIrrf.Text = "Aliquota IRRF (R$):";
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Location = new System.Drawing.Point(32, 438);
            this.txtSalarioFamilia.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(154, 22);
            this.txtSalarioFamilia.TabIndex = 12;
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(31, 418);
            this.lblSalarioFamilia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(129, 16);
            this.lblSalarioFamilia.TabIndex = 11;
            this.lblSalarioFamilia.Text = "Salário Família (R$):";
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(258, 438);
            this.txtSalarioLiquido.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(154, 22);
            this.txtSalarioLiquido.TabIndex = 14;
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(257, 418);
            this.lblSalarioLiquido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(129, 16);
            this.lblSalarioLiquido.TabIndex = 13;
            this.lblSalarioLiquido.Text = "Salário Líquido (R$):";
            // 
            // grpbxSexo
            // 
            this.grpbxSexo.Controls.Add(this.rbtnMasculino);
            this.grpbxSexo.Controls.Add(this.rbtnFeminino);
            this.grpbxSexo.Location = new System.Drawing.Point(285, 26);
            this.grpbxSexo.Name = "grpbxSexo";
            this.grpbxSexo.Size = new System.Drawing.Size(149, 105);
            this.grpbxSexo.TabIndex = 15;
            this.grpbxSexo.TabStop = false;
            this.grpbxSexo.Text = "Sexo:";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(20, 63);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(87, 20);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFeminino
            // 
            this.rbtnFeminino.AutoSize = true;
            this.rbtnFeminino.Checked = true;
            this.rbtnFeminino.Location = new System.Drawing.Point(20, 37);
            this.rbtnFeminino.Name = "rbtnFeminino";
            this.rbtnFeminino.Size = new System.Drawing.Size(78, 21);
            this.rbtnFeminino.TabIndex = 0;
            this.rbtnFeminino.TabStop = true;
            this.rbtnFeminino.Text = "Feminino";
            this.rbtnFeminino.UseCompatibleTextRendering = true;
            this.rbtnFeminino.UseVisualStyleBackColor = true;
            // 
            // pnlCasado
            // 
            this.pnlCasado.Controls.Add(this.ckbxCasado);
            this.pnlCasado.Location = new System.Drawing.Point(285, 137);
            this.pnlCasado.Name = "pnlCasado";
            this.pnlCasado.Size = new System.Drawing.Size(149, 36);
            this.pnlCasado.TabIndex = 16;
            // 
            // ckbxCasado
            // 
            this.ckbxCasado.AutoSize = true;
            this.ckbxCasado.Location = new System.Drawing.Point(20, 11);
            this.ckbxCasado.Name = "ckbxCasado";
            this.ckbxCasado.Size = new System.Drawing.Size(82, 20);
            this.ckbxCasado.TabIndex = 0;
            this.ckbxCasado.Text = "Casado?";
            this.ckbxCasado.UseVisualStyleBackColor = true;
            // 
            // txtDescontoInss
            // 
            this.txtDescontoInss.Enabled = false;
            this.txtDescontoInss.Location = new System.Drawing.Point(260, 327);
            this.txtDescontoInss.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescontoInss.Name = "txtDescontoInss";
            this.txtDescontoInss.Size = new System.Drawing.Size(154, 22);
            this.txtDescontoInss.TabIndex = 18;
            // 
            // lblDescontoInss
            // 
            this.lblDescontoInss.AutoSize = true;
            this.lblDescontoInss.Location = new System.Drawing.Point(259, 307);
            this.lblDescontoInss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontoInss.Name = "lblDescontoInss";
            this.lblDescontoInss.Size = new System.Drawing.Size(131, 16);
            this.lblDescontoInss.TabIndex = 17;
            this.lblDescontoInss.Text = "Desconto INSS (R$):";
            // 
            // txtDescontoIrrf
            // 
            this.txtDescontoIrrf.Enabled = false;
            this.txtDescontoIrrf.Location = new System.Drawing.Point(258, 381);
            this.txtDescontoIrrf.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescontoIrrf.Name = "txtDescontoIrrf";
            this.txtDescontoIrrf.Size = new System.Drawing.Size(154, 22);
            this.txtDescontoIrrf.TabIndex = 20;
            // 
            // lblDescontoIrrf
            // 
            this.lblDescontoIrrf.AutoSize = true;
            this.lblDescontoIrrf.Location = new System.Drawing.Point(257, 361);
            this.lblDescontoIrrf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescontoIrrf.Name = "lblDescontoIrrf";
            this.lblDescontoIrrf.Size = new System.Drawing.Size(131, 16);
            this.lblDescontoIrrf.TabIndex = 19;
            this.lblDescontoIrrf.Text = "Desconto IRRF (R$):";
            // 
            // cbxNumFilhos
            // 
            this.cbxNumFilhos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNumFilhos.FormattingEnabled = true;
            this.cbxNumFilhos.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxNumFilhos.Location = new System.Drawing.Point(33, 149);
            this.cbxNumFilhos.Name = "cbxNumFilhos";
            this.cbxNumFilhos.Size = new System.Drawing.Size(192, 24);
            this.cbxNumFilhos.TabIndex = 21;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Location = new System.Drawing.Point(31, 252);
            this.lblInformacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(85, 16);
            this.lblInformacao.TabIndex = 22;
            this.lblInformacao.Text = "Informações:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(173, 495);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(86, 26);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(285, 200);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(127, 29);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "Limpar tudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 533);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.cbxNumFilhos);
            this.Controls.Add(this.txtDescontoIrrf);
            this.Controls.Add(this.lblDescontoIrrf);
            this.Controls.Add(this.txtDescontoInss);
            this.Controls.Add(this.lblDescontoInss);
            this.Controls.Add(this.pnlCasado);
            this.Controls.Add(this.grpbxSexo);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIrrf);
            this.Controls.Add(this.lblAliquotaIrrf);
            this.Controls.Add(this.txtAliquotaInss);
            this.Controls.Add(this.lblAliquotaInss);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.lblNomeFunc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalario";
            this.Text = "Descontos Salário";
            this.Load += new System.EventHandler(this.frmSalario_Load);
            this.grpbxSexo.ResumeLayout(false);
            this.grpbxSexo.PerformLayout();
            this.pnlCasado.ResumeLayout(false);
            this.pnlCasado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.TextBox txtAliquotaInss;
        private System.Windows.Forms.Label lblAliquotaInss;
        private System.Windows.Forms.TextBox txtAliquotaIrrf;
        private System.Windows.Forms.Label lblAliquotaIrrf;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.GroupBox grpbxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFeminino;
        private System.Windows.Forms.Panel pnlCasado;
        private System.Windows.Forms.CheckBox ckbxCasado;
        private System.Windows.Forms.TextBox txtDescontoInss;
        private System.Windows.Forms.Label lblDescontoInss;
        private System.Windows.Forms.TextBox txtDescontoIrrf;
        private System.Windows.Forms.Label lblDescontoIrrf;
        private System.Windows.Forms.ComboBox cbxNumFilhos;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLimpar;
    }
}

