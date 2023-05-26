namespace LegacyCodeKoans.StaticMethod
{
    public class Service
    {
        private readonly IDependencyWrapper _wrapper;
        public Service(IDependencyWrapper wrapper) {
            _wrapper = wrapper;
        }

        public void DoSomething() {
            _wrapper.SomeSideEffect();
        }
    }
}