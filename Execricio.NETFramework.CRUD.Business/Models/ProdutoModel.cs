using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execricio.NETFramework.CRUD.Business.Models
{
    public class ProdutoModel 
    {
        public Guid Id_Produto { get; set; }
        public string Nome_produto { get; set; }
        public string Descricao_produto { get; set; }
        public double Preco_atual { get; set; }
    }
}
