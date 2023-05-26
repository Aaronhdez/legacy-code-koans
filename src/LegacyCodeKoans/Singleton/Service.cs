namespace LegacyCodeKoans.Singleton
{
    public class Service
    {
        private readonly Dependency _dependency;

        public Service() {
            _dependency = Dependency.Instance;
        }

        public void DoSomething() {
            _dependency.SomeSideEffect();
        }
    }
}