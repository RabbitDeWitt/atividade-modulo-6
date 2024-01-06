using System.ComponentModel.DataAnnotations;

namespace daviagens_api.Models
{
    public class Contato
    {
        [Key]
        public int Id { get; set; }

        public string nome { get; set; }
        public string email { get; set; }
        public string mensagem { get; set; }
    }
}
