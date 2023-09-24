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
    }
}
