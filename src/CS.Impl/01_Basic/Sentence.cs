using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            var reversedSentence = string.Empty;
            var wordsOfSentence = sentence.Split(" ");

            for (int i = wordsOfSentence.Length - 1; i >= 0; i--)
            {
                reversedSentence += wordsOfSentence[i];
                reversedSentence += " ";
            }

            reversedSentence = reversedSentence.Remove(reversedSentence.Length - 1, 1);

            return reversedSentence;
        }
    }
}
