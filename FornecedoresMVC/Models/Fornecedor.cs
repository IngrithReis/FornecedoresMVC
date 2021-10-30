using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FornecedoresMVC.Models
{
    public class Fornecedor
    {   
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }

        public string Telefone { get; set; }

        
        public Categoria Categoria { get; set; }

        public int CategoriaId { get; set; }

    }
}
