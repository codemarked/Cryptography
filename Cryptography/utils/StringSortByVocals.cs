using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography.utils
{
    class StringSortByVocals : IComparer<string>
    {
        public int Compare(string str1, string str2)
        {
            AlphabetUtils alphabetUtils = AlphabetUtils.getInstance();
            int vocals1 = alphabetUtils.countVocals(str1);
            int vocals2 = alphabetUtils.countVocals(str2);
            if (vocals1 > vocals2)
                return 0 - 1;
            if (vocals1 < vocals2)
                return 1;
            return string.Compare(str1, str2);
        }
    }
}
