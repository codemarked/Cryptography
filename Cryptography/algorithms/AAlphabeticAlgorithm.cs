using System;
using Cryptography.api;

namespace Cryptography.algorithms
{
    public abstract class AAlphabeticAlgorithm : IAlgorithm
    {
        public abstract string getName();
        public abstract int getN();

        public abstract void initInput(object input);

        public abstract void solve();

        public abstract IResult getResult();
    }
}
