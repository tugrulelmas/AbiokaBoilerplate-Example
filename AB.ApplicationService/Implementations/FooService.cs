using AB.ApplicationService.Abstractions;
using AB.Domain.Repositories;

namespace AB.ApplicationService.Implementations
{
    public class FooService : IFooService
    {
        private readonly IFooRepository fooRepository;

        public FooService(IFooRepository fooRepository) {
            this.fooRepository = fooRepository;
        }

        public void Bar() {
            var bar = fooRepository.Bar();
        }
    }
}
