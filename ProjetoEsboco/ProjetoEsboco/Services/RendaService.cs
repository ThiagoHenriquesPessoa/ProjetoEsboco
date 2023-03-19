using ProjetoEsboco.Data;
using ProjetoEsboco.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEsboco.Services
{
    public class RendaService : IRendaService
    {
        public readonly Database _database;

        public RendaService(Database database)
        {
            _database = database;
        }

        public void SaveRenda(Renda renda)
        {
            _database.SaveRendaAsync(renda);
        }
    }
}
