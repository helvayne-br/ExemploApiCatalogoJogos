using System.ComponentModel.DataAnnotations;

namespace ExemploApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "The game name must contain between 3 and 100 characters")]
        public string Nome { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "The producer name must contain between 3 and 100 characters")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 500, ErrorMessage = "The price must be at least US 1 Dollar and at most  US 500 Dollars")]
        public double Preco { get; set; }
    }
}
