using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
        private string _sentence;
        private string _word;

        public RepeatCounter(string userSentence, string userWord)
        {
            _sentence = userSentence;
            _word = userWord;
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
    }
}
