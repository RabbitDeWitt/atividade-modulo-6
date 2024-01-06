using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace daviagens_api.Models
{
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string descricaoCompleta { get; set; }
        public string img { get; set; }
        public string tipo { get; set; }
        public float valor { get; set; }
        public float desconto { get; set; }

        [JsonIgnore]
        public List<Reserva> reservas { get; set; }
    }
}
