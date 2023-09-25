namespace ControleAcessoCSharp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emitirNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarNotaFiscalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFaturamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comissãoDeVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeAcessoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invalidarAtivarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acessoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ativarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.faturamentoToolStripMenuItem,
            this.acessoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.vendedorToolStripMenuItem,
            this.fornecedorToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // vendedorToolStripMenuItem
            // 
            this.vendedorToolStripMenuItem.Name = "vendedorToolStripMenuItem";
            this.vendedorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.vendedorToolStripMenuItem.Text = "Vendedores";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedorToolStripMenuItem.Text = "Fornecedores";
            // 
            // faturamentoToolStripMenuItem
            // 
            this.faturamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emitirNotaFiscalToolStripMenuItem,
            this.cancelarNotaFiscalToolStripMenuItem,
            this.consultarNotaFiscalToolStripMenuItem,
            this.consultarFaturamentoToolStripMenuItem,
            this.comissãoDeVendedoresToolStripMenuItem});
            this.faturamentoToolStripMenuItem.Name = "faturamentoToolStripMenuItem";
            this.faturamentoToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.faturamentoToolStripMenuItem.Text = "Faturamento";
            // 
            // emitirNotaFiscalToolStripMenuItem
            // 
            this.emitirNotaFiscalToolStripMenuItem.Name = "emitirNotaFiscalToolStripMenuItem";
            this.emitirNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.emitirNotaFiscalToolStripMenuItem.Text = "Emitir Nota Fiscal";
            // 
            // cancelarNotaFiscalToolStripMenuItem
            // 
            this.cancelarNotaFiscalToolStripMenuItem.Name = "cancelarNotaFiscalToolStripMenuItem";
            this.cancelarNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.cancelarNotaFiscalToolStripMenuItem.Text = "Cancelar Nota Fiscal";
            // 
            // consultarNotaFiscalToolStripMenuItem
            // 
            this.consultarNotaFiscalToolStripMenuItem.Name = "consultarNotaFiscalToolStripMenuItem";
            this.consultarNotaFiscalToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.consultarNotaFiscalToolStripMenuItem.Text = "Consultar Nota Fiscal";
            // 
            // consultarFaturamentoToolStripMenuItem
            // 
            this.consultarFaturamentoToolStripMenuItem.Name = "consultarFaturamentoToolStripMenuItem";
            this.consultarFaturamentoToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.consultarFaturamentoToolStripMenuItem.Text = "Consultar Faturamento do Mês";
            // 
            // comissãoDeVendedoresToolStripMenuItem
            // 
            this.comissãoDeVendedoresToolStripMenuItem.Name = "comissãoDeVendedoresToolStripMenuItem";
            this.comissãoDeVendedoresToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.comissãoDeVendedoresToolStripMenuItem.Text = "Comissão de Vendedores";
            // 
            // acessoToolStripMenuItem
            // 
            this.acessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuáriosToolStripMenuItem,
            this.controleDeAcessoToolStripMenuItem});
            this.acessoToolStripMenuItem.Name = "acessoToolStripMenuItem";
            this.acessoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.acessoToolStripMenuItem.Text = "Acesso";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            this.cadastroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de Usuários";
            this.cadastroDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuáriosToolStripMenuItem_Click);
            // 
            // controleDeAcessoToolStripMenuItem
            // 
            this.controleDeAcessoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ativarToolStripMenuItem,
            this.invalidarAtivarToolStripMenuItem,
            this.acessoToolStripMenuItem1});
            this.controleDeAcessoToolStripMenuItem.Name = "controleDeAcessoToolStripMenuItem";
            this.controleDeAcessoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.controleDeAcessoToolStripMenuItem.Text = "Controle de Acesso";
            // 
            // invalidarAtivarToolStripMenuItem
            // 
            this.invalidarAtivarToolStripMenuItem.Name = "invalidarAtivarToolStripMenuItem";
            this.invalidarAtivarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.invalidarAtivarToolStripMenuItem.Text = "Invalidar";
            // 
            // acessoToolStripMenuItem1
            // 
            this.acessoToolStripMenuItem1.Name = "acessoToolStripMenuItem1";
            this.acessoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.acessoToolStripMenuItem1.Text = "Acesso";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // ativarToolStripMenuItem
            // 
            this.ativarToolStripMenuItem.Name = "ativarToolStripMenuItem";
            this.ativarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ativarToolStripMenuItem.Text = "Ativar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 293);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Acesso";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emitirNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarNotaFiscalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFaturamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comissãoDeVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeAcessoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invalidarAtivarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acessoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ativarToolStripMenuItem;
    }
}

