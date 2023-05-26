using System;

namespace LegacyCodeKoans.Singleton
{
    public class Dependency : IDependency {
        public static readonly IDependency Instance = new Dependency();

        public void SomeSideEffect()
        {
            throw new Exception("This method should not be called in a unit test!");
        }
    }
}