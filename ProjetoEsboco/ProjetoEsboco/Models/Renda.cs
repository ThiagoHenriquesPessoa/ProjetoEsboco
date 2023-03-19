using System;
using SQLite;

namespace ProjetoEsboco.Models
{
    public class Renda
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set;}
        public bool Fixo { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
