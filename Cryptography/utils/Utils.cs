using System;

namespace Cryptography.utils
{
    public class Utils
    {
        private static Utils INSTANCE = new Utils();

        public static Utils getInstance()
        {
            return INSTANCE;
        }


    }
}
