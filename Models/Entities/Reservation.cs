namespace csharp_EZReserve.Models.Entities
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public string Room { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Customer Customer { get; set; }
    }
}
