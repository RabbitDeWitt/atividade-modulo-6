using System.ComponentModel.DataAnnotations;

namespace daviagens_api.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        public string dataPartida { get; set;}
        public string dataRetorno { get; set;}
        public float valor {  get; set;}

        public int clienteId { get; set;}

        public Cliente cliente { get; set;}

        public int destinoId { get; set;}

        public Destino destino{ get; set;}
        public int pacoteId { get; set;}

        public Pacote pacote{ get; set;}
    }
}
