using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcessoCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var opcoes = Opcoes.Criar(menuStrip1);
            dataGridView1.DataSource = opcoes.ToList();

            configurarGrade();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var opcoes = Opcoes.Criar(menuStrip1);
            dataGridView1.DataSource = opcoes.ToList();

            configurarGrade();
            //criar
            //Opcoes.salvarMenu(opcoes);
            //MessageBox.Show("Gerado");
        }

        public void configurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            dataGridView1.Columns["id"].Visible = false;

            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["nome"].Width = 300;
            dataGridView1.Columns["nome"].ReadOnly = true;

            dataGridView1.Columns["descricao"].HeaderText = "Descrição";
            dataGridView1.Columns["descricao"].Width = 380;
            dataGridView1.Columns["descricao"].ReadOnly = true;

            dataGridView1.Columns["nivel"].HeaderText = "Nível";
            dataGridView1.Columns["nivel"].Width = 60;
            dataGridView1.Columns["nivel"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["nivel"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["nivel"].ReadOnly = true;

            //adicionar coluna
            var acesso = new DataGridViewCheckBoxColumn();
            acesso.HeaderText = "Liberado";
            acesso.Width = 60;
            acesso.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            acesso.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(acesso);

        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmUsuario())
            {
                frm.ShowDialog();
            }
        }
    }
}
