using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounterTest
{
    public class RepeatCounterTest
    {
        [Fact]
        public void GetSentence_returnUserSentence_sameSentence()
        {
            //arrange
            string sentence = "this is a sentence";
            string returnSentence = "this is a sentence";
            RepeatCounter newCounter = new RepeatCounter(sentence);

            //act
            string result = newCounter.GetSentence();

            //assert
            Assert.Equal(returnSentence, result);
        }


    }
}
