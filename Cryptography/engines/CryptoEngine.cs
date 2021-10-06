using System;
using Cryptography.api;
using Cryptography.algorithms;
using Cryptography.algorithms.impl;

namespace Cryptography.engines
{
    public class CryptoEngine : IEngine
    {
        private static CryptoEngine INSTANCE;

        public static CryptoEngine getInstance()
        {
            return INSTANCE;
        }

        private object input;
        private IAlgorithm algorithm;
        private AlgorithmFactory algorithmFactory;
        private IResult result;

        public CryptoEngine()
        {
            INSTANCE = this;
            this.init();
        }

        public AlgorithmFactory getAlgorithmFactory()
        {
            return this.algorithmFactory;
        }

        public void init()
        {
            this.algorithmFactory = new AlgorithmFactory();
        }

        public void loadAlgorithm(IAlgorithm algorithm)
        {
            this.algorithm = algorithm;
            Console.WriteLine($"Loading {algorithm.GetType().ToString()}");
        }

        public IAlgorithm getAlgorithm()
        {
            return this.algorithm;
        }

        public object getInput()
        {
            return this.input;
        }

        public void setInput(object input)
        {
            this.input = input;
        }

        public IResult getResult()
        {
            return this.result;
        }

        public void run()
        {
            this.algorithm.initInput(this.input);
            this.algorithm.solve();
            this.result = this.algorithm.getResult();
        }
    }
}
