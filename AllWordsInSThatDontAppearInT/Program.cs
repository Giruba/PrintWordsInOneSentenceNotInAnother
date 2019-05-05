using System;

namespace AllWordsInSThatDontAppearInT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print words in one string not in another!");
            Console.WriteLine("-----------------------------------------");

            try
            {
                Console.WriteLine("Enter the first sentence");
                String sentence1 = Console.ReadLine().Trim();
                Console.WriteLine("Enter the second sentence");
                String sentence2 = Console.ReadLine().Trim();
                PrintWordsInFirstSentenceNotInSecond(sentence1, sentence2);
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }
            Console.ReadLine();
        }

        public static void PrintWordsInFirstSentenceNotInSecond(String sentence1, String sentence2) {

            if (string.IsNullOrEmpty(sentence1) && string.IsNullOrEmpty(sentence2))
            {
                Console.WriteLine("Cannot print anything! Both the sentences are empty/null");
            }
            else if (string.IsNullOrEmpty(sentence1) || (string.IsNullOrEmpty(sentence2)))
            {
                Console.WriteLine("Cannot print words when one sentence is null or empty!");
            }
            else {
                String[] words1 = sentence1.Split(' ', ',');
                String[] words2 = sentence2.Split(' ', ',');
                for (int index = 0; index < words1.Length; index++) {
                    if (!isPresent(words2, words1[index])) {
                        Console.WriteLine("This word '"+ words1[index]+"' is not present ");
                    }
                }
            }
        }

        private static bool isPresent(String[] words, String word) {
            for (int index = 0; index < words.Length; index++) {
                if (word == words[index]) {
                    return true;
                }
            }
            return false;
        }
    }
}
