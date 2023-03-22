using SQLite;
using System;

namespace ProjetoEsboco.Models
{
    public class Despesa
    {
        [PrimaryKey, AutoIncrement]
        public int IdDespesa { get; set; }

        public double ValorDespesa { get; set; }
        public string TipoDespesa { get; set; }
        public bool FixaDespesa { get; set; }
        public string CartaoCredito { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataCriacaoDespesa { get; set; }
    }
}