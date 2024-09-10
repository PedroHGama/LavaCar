using System.ComponentModel.DataAnnotations;

namespace WashCar.Models
{
    public class Carro
    {
        [Key]
        public int IDCarro { get; set; }

        [Required]
        [StringLength(7, ErrorMessage = "A placa deve ter 7 caracteres.")]
        public string Placa { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "O modelo não pode ter mais que 50 caracteres.")]
        public string Modelo { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "A marca não pode ter mais que 50 caracteres.")]
        public string Marca { get; set; }

        [Required]
        [StringLength(4, ErrorMessage = "O ano deve ter 4 caracteres.")]
        public string Ano { get; set; }

        [Required]
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }

        // REFERÊCIA DAS CHAVES ESTRANGEIRAS
        public ICollection<Lavagem> Lavagens { get; set; }
        public ICollection<Recibo> Recibos { get; set; }
    }
}
