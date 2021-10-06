using System;

namespace Cryptography.api
{
    public interface IEngine
    {
        void init();

        void loadAlgorithm(IAlgorithm alg);

        IAlgorithm getAlgorithm();

        void setInput(object input);

        object getInput();

        void run();
    }
}
