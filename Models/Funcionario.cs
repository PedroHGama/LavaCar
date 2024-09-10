using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WashCar.Models
{
    public class Funcionario
    {
        
            [Key]
            public int IDFuncionario { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "O nome não pode ter mais que 100 caracteres.")]
            public string Nome { get; set; }

            [Required]
            [StringLength(11, ErrorMessage = "O CPF deve ter 11 caracteres.")]
            [RegularExpression(@"^\d{11}$", ErrorMessage = "CPF deve conter apenas números e ter 11 dígitos.")]
            public string CPF { get; set; }

            [Required]
            [StringLength(200, ErrorMessage = "O endereço não pode ter mais que 200 caracteres.")]
            public string Endereco { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
            public DateTime DataNasc { get; set; }

            [Required]
            public int ClienteID { get; set; }
            public Cliente Cliente { get; set; }

        // REFERÊCIA DAS CHAVES ESTRANGEIRAS
        public ICollection<Recibo> Recibos { get; set; }

    }
}
