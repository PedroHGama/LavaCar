using System.ComponentModel.DataAnnotations;

namespace WashCar.Models
{
    public class Recibo
    {
        [Key]
        public int IDRecibo { get; set; }

        public int IDCliente { get; set; }

        [Required]
        public int IDCarro { get; set; }
        [Required]
        public int IDFuncionario { get; set; }

        [Required]

        public int IDLavagem { get; set; }
    }
}
