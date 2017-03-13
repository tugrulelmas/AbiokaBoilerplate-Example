using AB.ApplicationService.Abstractions;
using AB.ApplicationService.Implementations;
using AbiokaApi.Infrastructure.Common.IoC;

namespace AB.ApplicationService
{
    public class Bootstrapper
    {
        public static void Initialise() {
            Repository.Bootstrapper.Initialise();
            DependencyContainer.Container
                .RegisterService<IFooService, FooService>();
        }
    }
}
