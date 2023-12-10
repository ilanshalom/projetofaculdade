using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoInter
{
    public class Curso
    {
        private int idcurso;
        private string nome;
        private string descricao;
        private string duracao;

        public Curso(int idcurso, string nome, string descricao, string duracao)
        {
            this.idcurso = idcurso;
            this.nome = nome;
            this.descricao = descricao;
            this.duracao = duracao;
        }
        public int Idcurso { get => idcurso; set => idcurso = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Duracao { get => duracao; set => duracao = value; }
    }
}