using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
        private string _sentence;
        private string _word;
        private string[] _sentenceSplitArray;
        private int _count;

        public RepeatCounter(string userSentence, string userWord)
        {
            _sentence = userSentence;
            _word = userWord;
            _sentenceSplitArray = userSentence.Split(' ');
            _count = 0;
        }

        // to return user input sentence
        public string GetSentence()
        {
            return _sentence;
        }

        // to return user input sentence
        public string GetWord()
        {
            return _word;
        }

        // to determine if sentence contains word
        public bool ContainsWord()
        {
            foreach (string word in _sentenceSplitArray)
            {
                if(word == _word)
                {
                    return true;
                }
            }
            return false;
        }

        // to determine how many times a sentence contains word
        public int CountRepeats()
        {
            string[] _wordArray = _word.Split(' ');
            Console.WriteLine(_wordArray);

            for (int i = 0; i < _sentenceSplitArray.Length; i++)
            {
                for (int j= 0; j < _wordArray.Length; j++)
                {
                    if (_sentenceSplitArray[i] == _wordArray[i])
                    {
                        _count += 1;
                    }
                }
            }
            return _count;
        }

    }
}
