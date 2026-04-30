using System.ComponentModel.DataAnnotations;

namespace SistemaEstagio.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        
        [Required(ErrorMessage = "O nome do cliente é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome não pode exceder 100 caracteres")]
        public string Nome { get; set; } = string.Empty;

        // Propriedade de navegação: permite acessar os produtos deste cliente
        public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}