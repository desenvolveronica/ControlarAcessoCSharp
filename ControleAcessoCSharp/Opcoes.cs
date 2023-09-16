using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleAcessoCSharp
{
    public class Opcoes
    {
        public int Id { get; set; } 
        public string Nome { get; set; }  //nome que aparece no menu 
        public string Descricao { get; set;} //descrição do nome do menu 
        public byte Nivel { get; set;}  // 1, 2 ou 3 nível

        //construtor
        public Opcoes (String nome, string descricao, byte nivel)
        {
            Nome = nome;
            Descricao = descricao;  
            Nivel = nivel;  
        }
        //método para ler o menu que está no formulário
        public static HashSet<Opcoes> Criar(MenuStrip menu) //HashSet significa coleção e neste caso uma coleção de opçoes
        {//ele sendo STATIC não precisa instanciar um objeo da classe OPÇÕES
            var hashSetOpcoes = new HashSet<Opcoes>();
            //nivel 1
            foreach (ToolStripMenuItem item in menu.Items)
            {
                var descricao1 = item.Text;
                // nivel 2
                if (item.HasDropDownItems)
                {
                    foreach (ToolStripMenuItem opcao in item.DropDownItems)
                    {
                        var descricao2 = descricao1 + " / " + opcao.Text;
                        if (opcao.HasDropDownItems)
                        {
                            // nivel 3
                            foreach (ToolStripMenuItem subOpcao in opcao.DropDownItems)
                            {
                                var descricao3 = descricao2 + " / " + subOpcao.Text; 
                                hashSetOpcoes.Add(new Opcoes(subOpcao.Name, descricao3, 3));  
                            }
                        } 
                        else
                        {
                            hashSetOpcoes.Add(new Opcoes(opcao.Name, descricao2, 2));
                        }
                    }
                      
                }
                else
                {
                    hashSetOpcoes.Add(new Opcoes(item.Name, descricao1, 1));
                }
            }
            return hashSetOpcoes;
        }

    }
}
