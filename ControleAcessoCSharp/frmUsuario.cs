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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)//verifica se tem algo para alterar ou seja, se a grade não esta vazia
            {//transferindo os dados da grade (linha) para o objeto usuario

                TransferirGradeParaUsuario();


                using (var frm = new FrmUsuariosCadastro(usuario, Operacao.Alterar))
                {
                    frm.ShowDialog();
                    if (usuario.Id != -1) //-1 é o id de erro que vem so método btnSalvar_Click
                    {
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value = usuario.Id;
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["email"].Value = usuario.Email;
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nome"].Value = usuario.Nome;
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nomeCurto"].Value = usuario.NomeCurto;
                        dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ativo"].Value = usuario.Ativo;
                    }
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ReiniciarUsuario(usuario);

            using (var frm = new FrmUsuariosCadastro(usuario, Operacao.Adicionar))
            {
                frm.ShowDialog();
                dataGridView1.DataSource = Usuarios.BuscarTodos();
            }
        }

        private void ReiniciarUsuario(Usuarios usuario)
        {   //está limpando os dados do objeto usuário
            usuario.Id = 0;
            usuario.Email = "";
            usuario.Nome = "";
            usuario.NomeCurto = "";
            usuario.Ativo = 'S';
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                TransferirGradeParaUsuario();

                using (var frm = new FrmUsuariosCadastro(usuario, Operacao.Excluir))
                {
                    frm.ShowDialog();

                    if (usuario.Id != -1)
                        dataGridView1.DataSource = Usuarios.BuscarTodos();
                }
            }
        }
        private void TransferirGradeParaUsuario()
        {

            usuario.Id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["id"].Value);
            usuario.Email = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["email"].Value.ToString();
            usuario.Nome = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nome"].Value.ToString();
            usuario.NomeCurto = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["nomeCurto"].Value.ToString();
            usuario.Ativo = Convert.ToChar(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells["ativo"].Value);
        }

        private void consultarToolStripButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                TransferirGradeParaUsuario();

                using (var frm = new FrmUsuariosCadastro(usuario, Operacao.Consultar))
                {
                    frm.ShowDialog();

                    if (usuario.Id != -1)
                        dataGridView1.DataSource = Usuarios.BuscarTodos();
                }
            }
        }
    }
}
