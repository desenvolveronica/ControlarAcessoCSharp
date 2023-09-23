using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcessoCSharp
{
    public class Usuarios
    {//propriedades da classe
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }
        public string NomeCurto { get; set; }
        public char Ativo { get; set; }

        public Usuarios() { }

        public void _Usuarios(int id, string emil, string nome, string nomeCurto, char ativo) 
        { 
            Id = id;
            Email = emil;
            Nome = nome;
            NomeCurto = nomeCurto;
            Ativo = ativo;
        
        }

        public static DataTable BuscarTodps()
        {
            var sql = "Select id, email, nome, nomeCurto, ativo FROM Usuarios";
            var dt = new DataTable();

            try 
            {
                using (var cn = new SqlConnection(Program.strConn))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }   
            return dt;  
        }
    }

}
