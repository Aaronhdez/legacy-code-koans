using NSubstitute;
using Xunit;

namespace LegacyCodeKoans.StaticMethod
{
    public class ServiceShould
    {
        [Fact]
        public void DoSomething()
        {
            var dependencyWrapper = Substitute.For<IDependencyWrapper>();
            var service = new Service(dependencyWrapper);
            service.DoSomething();

            // TODO: Assert Dependency.SomeSideEffect() method was called
        }
    }
}