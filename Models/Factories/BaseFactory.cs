using Bogus;

namespace csharp_EZReserve.Models.Factories
{
    public abstract class BaseFactory<T> where T : class
    {
        protected readonly Faker<T> Faker;

        protected BaseFactory(string locale = "cz")
        {
            Faker = new Faker<T>(locale);
        }

        public abstract T Genereate();
        public IEnumerable<T> Generate(int count) => Enumerable.Range(0, count).Select(i => Genereate());
    }
}
