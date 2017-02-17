using Xunit;
using WordCounter.Objects;
using System;
using System.Collections.Generic;

namespace WordCounterTest
{
    public class RepeatCounterTest
    {
// this will return the inputted sentence exacty
        [Fact]
        public void GetSentence_returnUserSentence_sameSentence()
        {
            //arrange
            string sentence = "this is a sentence";
            string returnSentence = "This is a sentence";
            RepeatCounter newCounter = new RepeatCounter(sentence);

            //act
            string result = newCounter.GetSentence();

            //assert
            Assert.Equal(returnSentence, result);
        }



    }
}
