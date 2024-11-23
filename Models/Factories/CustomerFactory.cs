using Bogus;
using csharp_EZReserve.Models.Entities;

namespace csharp_EZReserve.Models.Factories
{
    public class CustomerFactory : BaseFactory<Customer>
    {
        public CustomerFactory(bool withReservations = false) 
        {
            Faker
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.FirstName, c.LastName))
                .RuleFor(c => c.StreetAddress, f => f.Address.StreetAddress())
                .RuleFor(c => c.City, f => f.Address.City())
                .RuleFor(c => c.PostalCode, f => f.Address.ZipCode("### ##"))
                .RuleFor(c => c.Reservations, (f, c) =>
                    withReservations ? GenerateNonOverlappingReservations(c.CustomerId, f.Random.Int(1, 5)) : new List<Reservation>());
        }

        private static List<Reservation> GenerateNonOverlappingReservations(int customerId, int count)
        {
            var reservations = new List<Reservation>();
            var faker = new Faker();
            var roomReservations = new Dictionary<string, List<(DateTime From, DateTime To)>>();

            for (int i = 0; i < count; i++)
            {
                var room = faker.Random.ListItem(new[] {
                    "Room L101",
                    "Room L102",
                    "Room L201",
                    "Room L202",
                    "Room L301",
                    "Room L302"
                });
                if (!roomReservations.ContainsKey(room))
                {
                    roomReservations[room] = new List<(DateTime From, DateTime To)>();
                }

                DateTime from, to;

                // Generate non-overlapping dates for the selected room
                do
                {
                    from = faker.Date.Future(1); // Start date in the future
                    to = from.AddHours(faker.Random.Int(1, 72)); // End date 1-72 hours later
                } while (roomReservations[room].Any(r => r.From < to && r.To > from));

                // Add the new reservation to the room-specific list
                roomReservations[room].Add((from, to));

                reservations.Add(new Reservation
                {
                    CustomerId = customerId,
                    Room = room,
                    From = from,
                    To = to
                });
            }

            return reservations;
        }

        public override Customer Genereate() => Faker.Generate();
    }
}
