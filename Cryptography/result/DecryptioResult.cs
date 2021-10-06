using System;
using Cryptography.api;

namespace Cryptography.result
{
    public class DecryptionResult : IResult
    {
        private object result;

        public DecryptionResult(object result)
        {
            this.result = result;
        }

        public object getResult()
        {
            return this.result;
        }

        public override string ToString()
        {
            return (string)this.result;
        }
    }
}
