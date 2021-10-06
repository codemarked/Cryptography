using System;
using System.Text;
using System.Collections.Generic;
using Cryptography.api;

namespace Cryptography
{
    public class EncryptionResultSet : IResult
    {
        private List<string> result;

        public EncryptionResultSet(object result)
        {
            this.result = new List<string>((List<string>)result);
        }

        public object getResult()
        {
            return this.result;
        }

        private string convertResult()
        {
            StringBuilder str = new StringBuilder();
            foreach (string a in this.result){
                if (str.Length > 0)
                    str.Append(", ");
                str.Append(a);
            }
            return str.ToString();
        }

        public override string ToString()
        {
            return this.convertResult();
        }
    }
}
