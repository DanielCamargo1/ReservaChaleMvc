using System.ComponentModel.DataAnnotations;

namespace ReservaDeChaleMvc.Models
{
    public class ChaleModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Precisa que um nome Seja digitado")]
        public string NomeUsuario { get; set; }
        public int? QuantidadeDePessoa { get; set; }
        [Required(ErrorMessage = "Precisa que um chale Seja informado")]
        public NomeDosChales Chale { get; set; }
    }
    public enum NomeDosChales
    {
        Fé = 1,
        RosaDeSaron = 2,
        EstrelaDaManhã = 3,
        LirioDosVales = 4,
        ValeDeJaboque = 5,
        Luz = 6,
        Esperança = 7,
        Amor = 8,
        Betseda = 9,
        ColunaDeFogo = 10,
        LuzDoMundo = 11,
        Graça = 12,
        Companheirismo = 13,
        Paz = 14,
        Jordão = 15,
        Jerusalém = 16,
        Cantico = 17,
        Belém = 18,
        MonteSinai = 19,
        MonteCarmelo = 20
    }

}
