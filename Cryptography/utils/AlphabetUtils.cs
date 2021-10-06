using System;
using System.Threading.Tasks;

namespace Cryptography.utils
{
    class AlphabetUtils
    {
        private static AlphabetUtils INSTANCE = new AlphabetUtils();

        public static AlphabetUtils getInstance()
        {
            return INSTANCE;
        }

        private string[] alphabet;

        public AlphabetUtils()
        {
            this.init();
        }

        private void init()
        {
            this.alphabet = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
                "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        }

        public string[] getAlphabet()
        {
            return this.alphabet;
        }

        public int getLength()
        {
            return this.alphabet.Length;
        }

        public string getLetterAt(int pos)
        {
            if (pos < 0)
                throw new IndexOutOfRangeException("Negative index");
            if (pos >= this.alphabet.Length)
                throw new IndexOutOfRangeException("Position > Length");
            return this.alphabet[pos];
        }

        public int getPosition(string letter)
        {
            for (int i = 0; i < this.alphabet.Length; i++)
                if (this.alphabet[i].ToLower().Equals(letter.ToLower()))
                    return i;
            return -1;
        }

        public bool isLetter(string input)
        {
            char charinput = char.Parse(input);
            return isLetter(charinput);
        }

        public bool isLetter(char input)
        {
            char charinput = Char.ToLower(input);
            return charinput > 96 && charinput < 123;
        }

        public bool isVocal(string input)
        {
            char charinput = char.Parse(input);
            return isVocal(charinput);
        }

        public bool isVocal(char input)
        {
            return input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u';
        }

        public int countVocals(string input)
        {
            int vocals = 0;
            for (int i = 0; i < input.Length; i++)
                if (isVocal(input[i]))
                    vocals++;
            return vocals;
        }
    }
}
