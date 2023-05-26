using Xunit;

namespace LegacyCodeKoans.Hardwired
{
    public class ServiceShould
    {
        [Fact]
        public void DoSomething()
        {
            var service = new Service(new MockedDependency());
            service.DoSomething();

            // TODO: Assert Dependency.SomeSideEffect() method was called
        }
    }
}