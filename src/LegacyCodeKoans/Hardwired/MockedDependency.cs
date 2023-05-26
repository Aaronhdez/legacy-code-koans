using System;

namespace LegacyCodeKoans.Hardwired {
    class MockedDependency : IDependency {
        public void SomeSideEffect() {
            Console.WriteLine("Dummy mock method");
        }
    }
}