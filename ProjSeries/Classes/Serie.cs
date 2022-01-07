using System;

namespace ProjSeries

{
   public class Serie : EntidadeBase
   {
      // Atributos
      private Genero Genero { get; set; }
      private string Titulo { get; set; }
      private string Descricao { get; set; }

      private int Ano { get; set; }

      private bool  Excluido { get; set;}

   //Métados
   public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
                this.Id = id;
                this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
               this.Excluido = false;
      } //public Series

      public override string ToString()
      {
         // Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.enironment.newLine?view-netcore.3.1
                string retorno = " ";
                retorno += "Gênero:" + this.Genero + Environment.NewLine;
                retorno += "Título:" + this.Titulo + Environment.NewLine;
                retorno += "Descrição:" + this.Descricao + Environment.NewLine;
                retorno += "Ano de Início:" + this.Ano;
                 retorno += "Excluido" + this.Excluido;
         return retorno;
      } // public override
      public string retornaTitulo()
      {
         return this.Titulo;
      } // public retornaTitulo
      public int retornaId()
      {
         return this.Id;
      } // retornaId
      public bool retornaExcluido()
      {
         return this.Excluido;
      } //retornaExcluido
      public void Excluir()
      {
         this.Excluido = true;
      } // voidExcuir
   } //public Class
} // namaspace