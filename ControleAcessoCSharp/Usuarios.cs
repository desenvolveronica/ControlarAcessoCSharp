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

        public string Salvar(Usuarios usuario)
        {
            var sql = "";

            if (usuario.Id == 0)
                sql = "INSERT INTO usuarios (email, nome, nomeCurto, ativo) VALUES (@email, @nome, @nomeCurto, @ativo)";
            else
                sql = "UPDATE usuarios SET email=@email, nome=@nome, nomeCurto=@nomeCurto, ativo=@ativo WHERE id=@id";

            try
            {
                using (var cn = new SqlConnection(Program.strConn))
                {
                    cn.Open();
                    using (var cmd = new SqlCommand(sql, cn))
                    {
                        if (usuario.Id > 0)
                            cmd.Parameters.AddWithValue("@id", usuario.Id);
                        cmd.Parameters.AddWithValue("@email", usuario.Email);
                        cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                        cmd.Parameters.AddWithValue("@nomeCurto", usuario.NomeCurto);
                        cmd.Parameters.AddWithValue("@ativo", usuario.Ativo);

                        cmd.ExecuteNonQuery();
                    }
                }
                return "ok";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public static DataTable BuscarTodos()
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
