using System;

namespace Cryptography.api
{
    public interface IAlgorithm
    {
        string getName();

        void initInput(object input);

        void solve();

        IResult getResult();
    }
}
