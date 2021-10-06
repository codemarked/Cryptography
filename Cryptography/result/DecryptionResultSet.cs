using System;
using System.Collections.Generic;
using System.Text;
using Cryptography.api;

namespace Cryptography.result
{
    class DecryptionResultSet : IResult
    {
        private List<string> result;

        public DecryptionResultSet(object result)
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
            foreach (string a in this.result)
            {
                if (str.Length > 0)
                    str.Append("\n");
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
