using Xunit;

namespace LegacyCodeKoans.StaticMethod
{
    public class ServiceShould
    {
        [Fact]
        public void DoSomething()
        {
            var service = new Service(new DependencyWrapper());
            service.DoSomething();

            // TODO: Assert Dependency.SomeSideEffect() method was called
        }
    }
}