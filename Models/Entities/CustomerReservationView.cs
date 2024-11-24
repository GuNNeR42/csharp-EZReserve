namespace csharp_EZReserve.Models.Entities
{
    public class CustomerReservationView
    {
        public int CustomerId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public int ReservationId { get; set; }
        public required string Room { get; set; }
        public DateTime ReservationFrom { get; set; }
        public DateTime ReservationTo { get; set; }
    }
}
