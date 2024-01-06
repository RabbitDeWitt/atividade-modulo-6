using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace daviagens_api.Models
{
    public class Pacote
    {
        [Key]
        public int Id { get; set; }

        public string nome { get; set; }

        public float valor { get; set; }

        [JsonIgnore]
        public List<Reserva> reservas { get; set; }
    }
}
