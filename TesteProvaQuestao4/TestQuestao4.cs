using System;
using Xunit;

namespace TesteProvaQuestao4
{
    public class TestQuestao4
    {
        [Fact]
        public void Shold_be_return_True_If_Age_Below_18()
        {
            //Given
            var exercise = new Questao4Prova();
            
            //When
            var result = exercise.verifyAge(2003);

            //Then
            Assert.Equal(true,result);

        }
    }
}
