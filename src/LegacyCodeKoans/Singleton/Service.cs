namespace LegacyCodeKoans.Singleton
{
    public class Service
    {
        private readonly IDependency _dependency;

        public Service(IDependency dependency) {
            _dependency = dependency;
        }

        public void DoSomething() {
            _dependency.SomeSideEffect();
        }
    }
}