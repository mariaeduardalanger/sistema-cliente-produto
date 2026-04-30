using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaEstagio.Models
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório")]
        [Display(Name = "Nome do Produto")]
        // Inicializado com string.Empty para evitar avisos de referência nula
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe o valor")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que zero")]
        [Column(TypeName = "decimal(18,2)")] // Recomendado para precisão monetária no SQL
        public decimal Valor { get; set; }

        [Display(Name = "Disponível?")]
        public bool Disponivel { get; set; }

        // Relacionamento com o Cliente
        [Required(ErrorMessage = "Selecione um cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente? Cliente { get; set; }
    }
}