using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EFExemplo.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        [Required]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; }

        public int Quantidade { get; }
    }
}
