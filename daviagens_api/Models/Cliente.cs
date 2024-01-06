using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace daviagens_api.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string nome { get; set; }
        public string dataNasc { get; set; }
        public string telefone { get; set; }
        public string numPassaporte { get; set; }

        [JsonIgnore]
        public List<Reserva> reservas { get; set; }
    }
}
