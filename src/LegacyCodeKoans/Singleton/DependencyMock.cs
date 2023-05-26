using System;

namespace LegacyCodeKoans.Singleton {
    class DependencyMock : IDependency {
        public static readonly DependencyMock Instance = new DependencyMock();
        public void SomeSideEffect() {
            Console.WriteLine("Nailed it");
        }
    }
}