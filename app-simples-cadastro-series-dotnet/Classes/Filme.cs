using System;
using System.Text;
using System.Collections.Generic;

namespace AppCadastroMidias
{
    public class Filme : EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public double Nota { get; set; }
        public int Duracao { get; set; }
        private bool Excluido { get; set; }

        public Filme(int id, Genero genero, string titulo, 
                     string descricao, int ano, double nota, 
                     int duracao)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Nota = nota;
            this.Duracao = duracao;
            this.Excluido = false;
        }

        public override string ToString()
        {
            var duracao = TimeSpan.FromMinutes(this.Duracao);
            string sDuracao = String.Format("Duração: {0}h {1:00}min", 
                                            (int)duracao.TotalHours,
                                            duracao.Minutes);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Gênero: " + this.Genero + Environment.NewLine);
            stringBuilder.Append("Título: " + this.Titulo + Environment.NewLine);
            stringBuilder.Append("Descrição: " + this.Descricao + Environment.NewLine);
            stringBuilder.Append("Ano de lançamento: " + this.Ano + Environment.NewLine);
            stringBuilder.Append("Nota: " + this.Nota + Environment.NewLine);
            stringBuilder.Append(sDuracao + Environment.NewLine);
            stringBuilder.Append("Excluído da base: " + (this.Excluido ? "Sim" : "Não"));               
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

        public void Excluir()
        {
            this.Excluido = true;
        }

        public bool retornaExclusao()
        {
            return this.Excluido;
        }
    }
}