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
            string word = "sentence";
            string returnSentence = "this is a sentence";
            RepeatCounter newCounter = new RepeatCounter(sentence, word);

            //act
            string result = newCounter.GetSentence();

            //assert
            Assert.Equal(returnSentence, result);
        }
        // this will return the inputted sentence exacty
        [Fact]
        public void GetWord_returnUserWord_sameWord()
        {
            //arrange
            string sentence = "this is a sentence";
            string word = "sentence";
            string returnWord = "sentence";
            RepeatCounter newCounter = new RepeatCounter(sentence, word);

            //act
            string result = newCounter.GetWord();

            //assert
            Assert.Equal(returnWord, result);
        }

        // this will return true or false if the sentence contains the word
        [Fact]
        public void containsWord_doesSentenceHaveWord_true()
        {
            //arrange
            string sentence = "this is a sentence";
            string word = "sentence";
            bool expectedResult = true;
            RepeatCounter newCounter = new RepeatCounter(sentence, word);

            //act
            bool result = newCounter.ContainsWord();

            //assert
            Assert.Equal(expectedResult, result);
        }

        // this will return how many instances of the word are in the sentence
        [Fact]
        public void CountRepeats_howManyTimesdoesSentenceHaveWord_one()
        {
            //arrange
            string sentence = "this is a sentence";
            string word = "sentence";
            int expectedResult = 1;
            RepeatCounter newCounter = new RepeatCounter(sentence, word);

            //act
            int result = newCounter.CountRepeats();

            //assert
            Assert.Equal(expectedResult, result);
        }

        // this will return how many instances of the word are in the sentence with multiple words
        [Fact]
        public void CountRepeats_howManyTimesdoesSentenceHaveWord_three()
        {
            //arrange
            string sentence = "this is a sentence sentence is it a sentence";
            string word = "sentence";
            int expectedResult = 3;
            RepeatCounter newCounter = new RepeatCounter(sentence, word);

            //act
            int result = newCounter.CountRepeats();

            //assert
            Assert.Equal(expectedResult, result);
        }

        // this will run method regardless of capitalization
        [Fact]
        public void CountRepeats_countsRegardlessofCap_three()
        {
            //arrange
            string sentence = "this is a Sentence sentEnce is it a sentence";
            string word = "senteNce";
            int expectedResult = 3;
            RepeatCounter newCounter = new RepeatCounter(sentence, word);

            //act
            int result = newCounter.CountRepeats();

            //assert
            Assert.Equal(expectedResult, result);
        }

    }
}
