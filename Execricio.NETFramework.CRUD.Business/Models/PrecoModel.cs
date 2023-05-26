using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execricio.NETFramework.CRUD.Business.Models
{
    public class PrecoModel : ProdutoModel
    {
        public Guid Id_Preco { get; set; }
        public double Preco_produto { get; set; }
        public DateTime Data_Atualizacao { get; set; }
    }
}
