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
        public FrmUsuariosCadastro(Usuarios usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            //transferir dados do objeto usuario para form
            lblId.Text = usuario.Id.ToString();
            txtEmail.Text = usuario.Email;
            txtNome.Text = usuario.Nome;
            txtNomeCurto.Text = usuario.NomeCurto;
            cmbAtivo.Text = usuario.Ativo == 'S' ? "Sim" : "Não";

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
    }
}
