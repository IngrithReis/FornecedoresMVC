using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FornecedoresMVC.Models
{
    public class Context : DbContext
    {
        // criacao tabela categorias

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        // conectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=myDataBase;Trusted_Connection=True;");
        }
    }
}
