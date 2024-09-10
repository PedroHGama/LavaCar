using System.ComponentModel.DataAnnotations;

namespace WashCar.Models
{
    public class Lavagem
    {
        [Key]
        public int IDLavagem { get; set; }

        [Required]
        public string TipoLavagem { get; set; }

        [Required]
        public DateTime DataLavagem { get; set; }

        [Required]
        public double ValorLavagem { get; set; }

        [Required]
        public double DescontoLavagem { get; set; }

        [Required]
        public int CarroID { get; set; }
        public Carro Carro { get; set; }

        // REFERÊCIA DAS CHAVES ESTRANGEIRAS
        public ICollection<Recibo> Recibos { get; set; }
    }
}
