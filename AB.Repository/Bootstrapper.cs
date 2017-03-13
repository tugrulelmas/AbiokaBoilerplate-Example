using AB.Domain.Repositories;
using AbiokaApi.Infrastructure.Common.IoC;

namespace AB.Repository
{
    public class Bootstrapper
    {
        public static void Initialise() {
            DependencyContainer.Container
                .Register<IFooRepository, FooRepository>();
        }
    }
}
