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
    public class Acessos
    {
        public int IdOpcao { get; set; }
        public string NomeOpcao { get; set; }
        public string DescricaoOpcao { get; set; }
        public byte NivelOpcao { get; set; }
        public char Liberado { get; set; }
        public int IdRegistro { get; set; }

        public Acessos() { }
         

        public Acessos(int idOpcao, string nomeOpcao, string descricaoOpcao, byte nivelOpcao, char liberado, int idRegistro)
        {   //join entre a tabela MenuAcesso e MenuOpcoes
            IdOpcao = idOpcao;
            NomeOpcao = nomeOpcao;
            DescricaoOpcao = descricaoOpcao;
            NivelOpcao = nivelOpcao;
            Liberado = liberado;
            IdRegistro = idRegistro;

        }
        public Acessos(int idOpcoes, char liberado, int idRegistro)
        {
            IdOpcao = idOpcoes;
            Liberado = liberado;
            IdRegistro = idRegistro;
        }

        public static List<Acessos> GetMenuAcessos(int id_usuario)
        {
            var sql = "SELECT o.id, o.nome nomeOpcao, o.descricao descricaoOpcao, o.nivel, ISNULL(a.liberado, 'N') liberado, ISNULL(a.id, 0) id_registro FROM MenuOpcoes o LEFT JOIN(SELECT id_usuario, id_opcao, liberado, id FROM MenuAcesso WHERE id_usuario=@id_usuario) a ON o.id = a.id_opcao";

            var listaAcessos = new List<Acessos>();

            try
            {

                using (var cn = new SqlConnection(Program.strConn))
                {
                    cn.Open();
                    using (var da = new SqlDataAdapter(sql, cn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@id_usuario", id_usuario);
                        using (var dt = new DataTable())
                        {
                            da.Fill(dt);
                            foreach (DataRow row in dt.Rows)
                            {
                                listaAcessos.Add(new Acessos((int)row["id"], (string)row["nomeOpcao"],
                                    (string)row["descricaoOpcao"], (byte)row["nivel"], Convert.ToChar(row
                                    ["liberado"]), (int)row["id_registro"]));
                            }
                        }
                    }
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return listaAcessos;
        }

        public string Salvar(int idUsuario, List<Acessos> listaAcessos)
        {
            try
            {
                using (var cn = new SqlConnection(Program.strConn))
                {
                    cn.Open();
                    foreach (var item in listaAcessos)
                    {
                        var sql = "";
                        if (item.IdRegistro == 0)
                            sql = "INSERT INTO MenuAcesso (id_opcao, id_usuario, liberado) VALUES (@id_opcao, @id_usuario, @liberado)";
                        else
                            sql = "UPDATE MenuAcesso SET id_opcao=@id_opcao, id_usuario=@id_usuario, liberado=@liberado WHERE id=@id";

                        using (var cmd = new SqlCommand(sql, cn))
                        {
                            if (item.IdRegistro > 0)
                                cmd.Parameters.AddWithValue("@id", item.IdRegistro);
                            cmd.Parameters.AddWithValue("@id_opcao", item.IdOpcao);
                            cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                            cmd.Parameters.AddWithValue("@liberado", item.Liberado);

                            cmd.ExecuteNonQuery();

                        }

                    }
                } 
                    return "ok";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}
