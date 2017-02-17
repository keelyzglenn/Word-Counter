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
            string returnSentence = "this is a sentence";
            RepeatCounter newCounter = new RepeatCounter(sentence);

            //act
            string result = newCounter.GetSentence();

            //assert
            Assert.Equal(returnSentence, result);
        }
// this will return the inputted sentence exacty
        [Fact]
        public void GetSentenceandWord_returnUserSentenceandWord_sameSentenceandWord()
        {
            //arrange
            string sentence = "this is a sentence";
            string word = "sentence";
            string returnSentence = "this is a sentence";
            string returnWord = "sentence";
            RepeatCounter newCounter = new RepeatCounter(sentence, word);

            //act
            string result = newCounter.GetBothInputs(returnSentence, returnWord);

            //assert
            Assert.Equal(returnSentence, result);
        }



    }
}
