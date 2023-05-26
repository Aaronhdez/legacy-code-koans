namespace LegacyCodeKoans.StaticClass
{
    public static class Service
    {
        private static readonly IDependency StaticDependency;

        static Service() {
            StaticDependency = new StaticDependency();
        }

        public static void DoSomething()
        {
            StaticDependency.SomeSideEffect();
        }
    }
}