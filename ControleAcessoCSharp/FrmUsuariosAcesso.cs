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
    public partial class FrmUsuariosAcesso : Form
    {
        public FrmUsuariosAcesso(Usuarios usuario)
        {
            InitializeComponent();
            //transferir dados do objeto usuário para o form
            lblId.Text = usuario.Id.ToString();
            lblEmail.Text = usuario.Email;
            lblNomeCurto.Text = usuario.NomeCurto;

            //ir na tabela de acessos e buscar o acesso que ele tem
            var listaAcesso = Acessos.GetMenuAcessos(Convert.ToInt32(lblId.Text));

            ConfigurarGrade(listaAcesso);

        }

        private void ConfigurarGrade(List<Acessos> listaAcesso)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 9);

            //id da opção do menu
            dataGridView1.Columns.Add("id_opcao", "Id");
           // dataGridView1.Columns["id_opcao"].Visible = false;

            dataGridView1.Columns.Add("nome", "Nome");
            dataGridView1.Columns["nome"].Visible = false;

            dataGridView1.Columns.Add("descricao", "Descrição");
            dataGridView1.Columns["descricao"].Width = 380;
            dataGridView1.Columns["descricao"].ReadOnly = true;

            dataGridView1.Columns.Add("nivel", "Nível");
            //dataGridView1.Columns["nivel"].Visible = false;

            //Id do registro do acesso
            dataGridView1.Columns.Add("id_registro", "Id do Registro");
          //  dataGridView1.Columns["id_registro"].Visible = false;

            dataGridView1.Columns.Add("id_usuario", "Usuário");
          //  dataGridView1.Columns["id_usuario"].Visible = false;

            //situação corrente 
            dataGridView1.Columns.Add("liberado", "Liberado");
           // dataGridView1.Columns["liberado"].Visible = false;

            //adicionar coluna checkbox
            var acesso = new DataGridViewCheckBoxColumn();
            acesso.Name = "acesso";
            acesso.HeaderText = "Liberar";
            acesso.Width = 50;
            acesso.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            acesso.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns.Add(acesso);

            //dataGridView1.Columns.Insert(dataGridView1.ColumnCount-1, acesso);

            try
            {
                foreach (var item in listaAcesso)
                {
                    dataGridView1.Rows.Add(item.IdOpcao, item.NomeOpcao, item.DescricaoOpcao,
                        item.NomeOpcao, item.IdRegistro, Convert.ToInt32(lblId.Text), item.Liberado, 
                        item.Liberado == 'S'? true: false);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}
