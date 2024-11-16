namespace csharp_EZReserve.Models.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
