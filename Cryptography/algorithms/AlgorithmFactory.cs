using System;
using Cryptography.algorithms.impl;

namespace Cryptography.algorithms
{
    public class AlgorithmFactory
    {
        private static AlgorithmFactory INSTANCE;

        public static AlgorithmFactory getInstance()
        {
            return INSTANCE;
        }

        public AlgorithmFactory()
        {
            INSTANCE = this;
        }

        public AlphabeticEncryptionAlgorithmImpl createAlphabeticEncryptionAlgorithm(int n)
        {
            return new AlphabeticEncryptionAlgorithmImpl(n);
        }

        public AlphabeticDecryptionAlgorithmImpl createAlphabeticDecryptionAlgorithm(int n)
        {
            return new AlphabeticDecryptionAlgorithmImpl(n);
        }
        public AlphabeticBruteforceDecryptionAlgorithmImpl createAlphabeticBruteforceDecryptionAlgorithm()
        {
            return new AlphabeticBruteforceDecryptionAlgorithmImpl();
        }
    }
}
