using AB.Domain.Repositories;

namespace AB.Repository
{
    public class FooRepository : IFooRepository
    {
        public string Bar() {
            var result = "bar";
            return result;
        }
    }
}
