using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Singleton01
{
    public class StaticHolderSingleton
    {
        private StaticHolderSingleton() {}

        private static class SingletonHelper {
            internal static StaticHolderSingleton Instance { get; } = new StaticHolderSingleton();
        }

        // public static StaticHolderSingleton Instance {
        //     get {
        //         return SingletonHelper.Instance;
        //     }
        // }

        public static StaticHolderSingleton Instance() => SingletonHelper.Instance;
    }
}