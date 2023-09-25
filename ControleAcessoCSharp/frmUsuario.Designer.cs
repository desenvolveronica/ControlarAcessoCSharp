namespace ControleAcessoCSharp
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.adicionarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.alterarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.excluirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.consultarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selecionarToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(864, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripButton,
            this.toolStripSeparator1,
            this.alterarToolStripButton,
            this.toolStripSeparator3,
            this.excluirToolStripButton,
            this.toolStripSeparator4,
            this.consultarToolStripButton,
            this.toolStripSeparator5,
            this.selecionarToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(888, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // adicionarToolStripButton
            // 
            this.adicionarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("adicionarToolStripButton.Image")));
            this.adicionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.adicionarToolStripButton.Name = "adicionarToolStripButton";
            this.adicionarToolStripButton.Size = new System.Drawing.Size(78, 22);
            this.adicionarToolStripButton.Text = "&Adicionar";
            this.adicionarToolStripButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // alterarToolStripButton
            // 
            this.alterarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("alterarToolStripButton.Image")));
            this.alterarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alterarToolStripButton.Name = "alterarToolStripButton";
            this.alterarToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.alterarToolStripButton.Text = "&Alterar";
            this.alterarToolStripButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // excluirToolStripButton
            // 
            this.excluirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("excluirToolStripButton.Image")));
            this.excluirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.excluirToolStripButton.Name = "excluirToolStripButton";
            this.excluirToolStripButton.Size = new System.Drawing.Size(62, 22);
            this.excluirToolStripButton.Text = "&Excluir";
            this.excluirToolStripButton.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // consultarToolStripButton
            // 
            this.consultarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripButton.Image")));
            this.consultarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.consultarToolStripButton.Name = "consultarToolStripButton";
            this.consultarToolStripButton.Size = new System.Drawing.Size(78, 22);
            this.consultarToolStripButton.Text = "&Consultar";
            this.consultarToolStripButton.Click += new System.EventHandler(this.consultarToolStripButton_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // selecionarToolStripButton
            // 
            this.selecionarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("selecionarToolStripButton.Image")));
            this.selecionarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selecionarToolStripButton.Name = "selecionarToolStripButton";
            this.selecionarToolStripButton.Size = new System.Drawing.Size(81, 22);
            this.selecionarToolStripButton.Text = "&Selecionar";
            this.selecionarToolStripButton.ToolTipText = "Selecionar";
            this.selecionarToolStripButton.Visible = false;
            this.selecionarToolStripButton.Click += new System.EventHandler(this.selecionarToolStripButton_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton selecionarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton adicionarToolStripButton;
        private System.Windows.Forms.ToolStripButton alterarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton excluirToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton consultarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}