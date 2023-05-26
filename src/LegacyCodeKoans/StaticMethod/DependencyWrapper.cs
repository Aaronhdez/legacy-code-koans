namespace LegacyCodeKoans.StaticMethod {
    public class DependencyWrapper : IDependencyWrapper {
        public void SomeSideEffect() {
            Dependency.SomeSideEffect();
        }
    }
}