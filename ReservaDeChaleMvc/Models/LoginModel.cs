using System.ComponentModel.DataAnnotations;

namespace ReservaDeChaleMvc.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Adicione um Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Adicione uma Senha")]
        public int Senha { get; set; }
    }
}
