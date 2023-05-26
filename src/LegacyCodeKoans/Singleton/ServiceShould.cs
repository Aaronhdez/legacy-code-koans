using Xunit;

namespace LegacyCodeKoans.Singleton
{
    public class ServiceShould
    {
        [Fact]
        public void DoSomething()
        {
            var service = new Service(DependencyMock.Instance);
            service.DoSomething();
            
            // TODO: Assert Dependency.SomeSideEffect() method was called
        }
    }
}
