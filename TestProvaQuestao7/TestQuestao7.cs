using System;
using Xunit;

namespace TestProvaQuestao7 {
    public class TesteQuestao7 
    {
        [Theory]
        [InlineData (new int[] { 42, 11, 34, 42, 25, 27, 28 }, 28.57)]
        
         public void Shold_BE_Return_Average_of_ScBorns (int[] input , double expected) 
         {
            //Given
            var exercise = new Questao7Prova ();

            //When
            //  var input = new int[] { 42, 11, 34, 42, 25, 27, 28 };
            var result = exercise.Questao7 (input);
            // double expected = 28.37;

            //Then
            Assert.Equal (expected, input);

        }
    }
}