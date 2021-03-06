using System;
using System.Text;
using Cryptography.api;
using Cryptography.result;
using Cryptography.utils;

namespace Cryptography.algorithms.impl
{
    public class AlphabeticDecryptionAlgorithmImpl : AAlphabeticAlgorithm
    {
        private string input;
        private int n;
        private DecryptionResult result;

        public AlphabeticDecryptionAlgorithmImpl(int n)
        {
            this.n = n;
        }

        public override string getName()
        {
            return "AlphabeticDecryptionAlgorithm";
        }

        public override void initInput(object input)
        {
            this.input = (string)input;
        }

        public override int getN()
        {
            return this.n;
        }

        public override void solve()
        {
            AlphabetUtils alphabetUtils = AlphabetUtils.getInstance();
            StringBuilder str = new StringBuilder();
            int pos,actual;
            for (int i = 0; i < this.input.Length; i++)
            {
                if (!alphabetUtils.isLetter(this.input[i]))
                {
                    str.Append(this.input[i]);
                    continue;
                }
                pos = alphabetUtils.getPosition($"{this.input[i]}");
                actual = pos - this.n;
                if (actual < 0)
                    actual = alphabetUtils.getLength() - 1 + actual;
                str.Append(alphabetUtils.getLetterAt(actual));
            }
            this.result = new DecryptionResult(str.ToString());
        }

        public override IResult getResult()
        {
            return this.result;
        }
    }
}
