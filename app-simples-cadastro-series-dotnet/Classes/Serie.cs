using System;
using System.Text;

namespace AppCadastroSeries
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("");
            stringBuilder.Append("Genero: " + this.Genero + Environment.NewLine);
            stringBuilder.Append("Titulo: " + this.Titulo + Environment.NewLine);
            stringBuilder.Append("Descricao: " + this.Descricao + Environment.NewLine);
            stringBuilder.Append("Ano de lancamento: " + this.Ano + Environment.NewLine);
            return stringBuilder.ToString();
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
    }
}