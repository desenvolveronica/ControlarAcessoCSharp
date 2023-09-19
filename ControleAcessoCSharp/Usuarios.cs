using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
