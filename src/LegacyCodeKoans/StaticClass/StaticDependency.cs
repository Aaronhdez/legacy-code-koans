using System;

namespace LegacyCodeKoans.StaticClass {
    public class StaticDependency : IDependency {
        public void SomeSideEffect() {
            Console.WriteLine("Another effect");
        }
    }
}