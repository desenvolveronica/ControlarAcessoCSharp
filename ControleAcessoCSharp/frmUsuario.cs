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
        }
    }
}
