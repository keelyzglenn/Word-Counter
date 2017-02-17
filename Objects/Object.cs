using System;
using System.Collections.Generic;

namespace WordCounter.Objects
{
    public class RepeatCounter
    {
        private string _sentence;

        public RepeatCounter(string userSentence)
        {
            _sentence = userSentence;
        }
        
// to return user input sentence
        public string GetSentence()
        {
            return _sentence;
        }
    }
}
