namespace LegacyCodeKoans.Singleton
{
    public class Service
    {
        private readonly Dependency _dependency;

        public Service(Dependency dependency) {
            _dependency = dependency;
        }

        public void DoSomething() {
            _dependency.SomeSideEffect();
        }
    }
}