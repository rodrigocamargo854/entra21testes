using System;
using Xunit;

namespace TesteProvaQuestao4
{
    public class TestQuestao4
    {
         [Theory]

        [InlineData (2003,true)]
        [InlineData (2004,true)]
        [InlineData (2002,true)]
        [InlineData (2000,true)]

        public void Shold_be_return_True_If_Age_Below_18(int year, bool expected)
        {
            //Given
            var exercise = new Questao4Prova();
            
            //When
            var result = exercise.verifyAge(year);

            //Then
            Assert.Equal(expected,result);

        }
    }
}
