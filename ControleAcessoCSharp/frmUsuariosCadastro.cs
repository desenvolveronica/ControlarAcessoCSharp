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
    public partial class FrmUsuariosCadastro : Form
    {
        Usuarios usuario = new Usuarios();
        public FrmUsuariosCadastro(Usuarios usuario, Operacao operacao)
        {
            InitializeComponent();
            this.usuario = usuario;

            if (operacao == Operacao.Adicionar && usuario.Id == 0)
                this.Text += " - Adicionar";
            else if (operacao == Operacao.Alterar)
                this.Text += " - Alterar";
            else if (operacao == Operacao.Excluir)
            {
                this.Text += " - Excluir";
                TravarControles();
                btnSalvar.Visible = false;
                btnOk.Visible = true;
                btnOk.Text = "Excluir";
            }
            else if (operacao == Operacao.Consultar)
            {
                this.Text += " - Consultar ";
                TravarControles();
                btnSalvar.Visible = false;
                btnOk.Visible = true;
                btnOk.Text = "Fechar";
            }

            //transferir dados do objeto usuario para form
            lblId.Text = usuario.Id.ToString();
            txtEmail.Text = usuario.Email;
            txtNome.Text = usuario.Nome;
            txtNomeCurto.Text = usuario.NomeCurto;
            cmbAtivo.Text = usuario.Ativo == 'S' ? "Sim" : "Não";

        }

        private void TravarControles()
        {
            txtEmail.Enabled = false;
            txtNome.Enabled = false;
            txtNomeCurto.Enabled = false;
            cmbAtivo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //transferir dados do form para o objeto 

            usuario.Id = Convert.ToInt32(lblId.Text);
            usuario.Email = txtEmail.Text;  
            usuario.Nome = txtNome.Text;    
            usuario.NomeCurto = txtNomeCurto.Text;
            usuario.Ativo = cmbAtivo.Text[0];

            var result = usuario.Salvar(usuario);

            if(result == "ok")
            {
                MessageBox.Show("Salvo com sucesso!");
                this.Close();//fecha o formulário
            }
            else
            {
                MessageBox.Show("Não foi possível salvar, tente novamente.\n" + result);
                usuario.Id = -1;
            }


        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (btnOk.Text == "Fechar")
                this.Close();
            else
            {
                var resposta = MessageBox.Show("Deseja mesmo excluir ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if(resposta == DialogResult.Yes)
                {
                    var result = usuario.Excluir(usuario.Id);
                    if (result)
                    {
                        MessageBox.Show("Excluido com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível escluir, tente novamente");
                        usuario.Id = -1;
                    }

                }
            }
        }
    }
}
