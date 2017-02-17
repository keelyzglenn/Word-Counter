using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
        private string _sentence;
        private string _word;
        private string[] _sentenceSplitArray;

        public RepeatCounter(string userSentence, string userWord)
        {
            _sentence = userSentence;
            _word = userWord;
            _sentenceSplitArray = userSentence.Split(' ');
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

        
    }
}
