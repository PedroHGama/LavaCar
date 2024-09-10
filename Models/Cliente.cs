using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WashCar.Models
{
    public class Cliente
    {
        [Key]
        public int IDCliente { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "O nome não pode ter mais que 100 caracteres.")]
        public string NomeCliente { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "O endereço não pode ter mais que 200 caracteres.")]
        public string EnderecoCliente { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "O telefone não pode ter mais que 15 caracteres.")]
        [Phone(ErrorMessage = "O telefone deve ser válido.")]
        public string FoneClienteId { get; set; }


        // REFERÊCIA DAS CHAVES ESTRANGEIRAS
        public ICollection<Carro> Carros { get; set; }
        public ICollection<Funcionario> Funcionarios { get; set; }
        public ICollection<Recibo> Recibos { get; set; }
    }

    
}
