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
    public partial class FrmUsuario : Form
    {
        Usuarios usuario = new Usuarios();
        public FrmUsuario()
        {
            InitializeComponent();
            dataGridView1.DataSource = Usuarios.BuscarTodos();
            configurarGrade();
        }

        private void configurarGrade()
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            //dataGridView1.Columns["id"].Visible = false; 
            dataGridView1.Columns["email"].HeaderText = "Email";
            dataGridView1.Columns["email"].Width = 250;
            dataGridView1.Columns["email"].ReadOnly = true;

            dataGridView1.Columns["nome"].HeaderText = "Nome";
            dataGridView1.Columns["nome"].Width = 300;
            dataGridView1.Columns["nome"].ReadOnly = true;

            dataGridView1.Columns["nomeCurto"].HeaderText = "Nome Curto";
            dataGridView1.Columns["nomeCurto"].Width = 110;
            dataGridView1.Columns["nomeCurto"].ReadOnly = true;

            dataGridView1.Columns["ativo"].HeaderText = "Ativo";
            dataGridView1.Columns["ativo"].Width = 60;
            dataGridView1.Columns["ativo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["ativo"].ReadOnly = true;


        }

    }
}
