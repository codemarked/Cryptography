using System;
using Cryptography.api;

namespace Cryptography
{
    public class EncryptionResult : IResult
    {
        private object result;

        public EncryptionResult(object result)
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
