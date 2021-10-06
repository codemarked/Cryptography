using System;
using System.Collections.Generic;
using System.Text;
using Cryptography.api;
using Cryptography.result;
using Cryptography.utils;

namespace Cryptography.algorithms.impl
{
    public class AlphabeticBruteforceDecryptionAlgorithmImpl : AAlphabeticAlgorithm
    {
        private string input;
        private DecryptionResultSet result;

        public AlphabeticBruteforceDecryptionAlgorithmImpl(){}

        public override string getName()
        {
            return "AlphabeticBruteforceDecryptionAlgorithm";
        }

        public override void initInput(object input)
        {
            this.input = (string)input;
        }

        public override int getN()
        {
            return 0;
        }

        public override void solve()
        {
            AlphabetUtils alphabetUtils = AlphabetUtils.getInstance();
            StringBuilder str;
            List<string> resultsList = new List<string>();
            int n = 1;
            int pos, actual;
            while (true)
            {
                str = new StringBuilder();
                for (int i = 0; i < this.input.Length; i++)
                {
                    if (!alphabetUtils.isLetter(this.input[i]))
                    {
                        str.Append(this.input[i]);
                        continue;
                    }
                    pos = alphabetUtils.getPosition($"{this.input[i]}");
                    actual = pos - n;
                    if (actual < 0)
                        actual = alphabetUtils.getLength() - 1 + actual;
                    str.Append(alphabetUtils.getLetterAt(actual));
                }
                resultsList.Add($"[{n}] {str.ToString()}");
                if (n >= 26)
                    break;
                n++;
            }
            resultsList.Sort(new StringSortByVocals());
            this.result = new DecryptionResultSet(resultsList);
        }

        public override IResult getResult()
        {
            return this.result;
        }
    }
}
