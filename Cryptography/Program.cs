using System;
using Cryptography.engines;
using Cryptography.result;
using Cryptography.api;
using Cryptography.algorithms;

namespace Cryptography
{
    class Program
    {
        private static string lastResult;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine((lastResult != null ? "Last result: " + lastResult : ""));
                Console.WriteLine();
                Console.WriteLine("Enter Algorithm Type:");
                Console.WriteLine("A) Alphabetic Encryption");
                Console.WriteLine("B) Alphabetic Decryption");
                Console.WriteLine("C) Bruteforce Alphabetic Decryption");
                string type = Console.ReadLine();
                CryptoEngine engine = new CryptoEngine();
                if (type.ToLower().Equals("a"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Initializing Alphabetic Encryption Algorithm");
                    Console.WriteLine("Enter a value for n: ");
                    int number;
                    try
                    {
                        number = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error converting number! Exiting...");
                        return;
                    }
                    engine.loadAlgorithm(engine.getAlgorithmFactory().createAlphabeticEncryptionAlgorithm(number));
                    Console.WriteLine();
                    Console.WriteLine("Enter the input for Encryption: ");
                    engine.setInput(Console.ReadLine());
                }
                if (type.ToLower().Equals("b"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Initializing Alphabetic Decryption Algorithm");
                    Console.WriteLine("Enter a value for n: ");
                    int number;
                    try
                    {
                        number = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error converting number! Exiting...");
                        return;
                    }
                    engine.loadAlgorithm(engine.getAlgorithmFactory().createAlphabeticDecryptionAlgorithm(number));
                    Console.WriteLine();
                    Console.WriteLine("Enter the input for Decryption: ");
                    engine.setInput(Console.ReadLine());
                }
                if (type.ToLower().Equals("c"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Initializing Bruteforce Alphabetic Decryption Algorithm");
                    engine.loadAlgorithm(engine.getAlgorithmFactory().createAlphabeticBruteforceDecryptionAlgorithm());
                    Console.WriteLine();
                    Console.WriteLine("Enter the input for Bruteforce Decryption: ");
                    engine.setInput(Console.ReadLine());

                }
                if (engine.getAlgorithm() == null)
                {
                    Console.WriteLine($"Couldn't load algorithm for CryptoEngine! Exiting...");
                    return;
                }
                Console.WriteLine($"Using {engine.getAlgorithm().getName()} " +
                    $"{(engine.getAlgorithm() is AAlphabeticAlgorithm ? $"| n: {((AAlphabeticAlgorithm)engine.getAlgorithm()).getN()}" : "")}");
                engine.run();
                IResult result = engine.getResult();
                Console.WriteLine();
                Console.WriteLine($"{(result is EncryptionResult ? "En" : "De")}cryption Result: {lastResult = result.ToString()}");
                Console.ReadKey();
            }
        }
    }
}
