using System;

namespace LegacyCodeKoans.StaticClass
{
    public static class Dependency 
    {
        public static void SomeSideEffect()
        {
            throw new Exception("This method should not be called in a unit test!");
        }
    }
}