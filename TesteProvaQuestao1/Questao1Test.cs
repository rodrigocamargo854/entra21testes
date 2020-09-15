using System;
using Xunit;

namespace TesteProva 

{
    public class Questao1Test 
    {
         [Theory]

        [InlineData (12,4.5,54.0)]
       
        public void Should_Be_Return_Total_Value ( double hours, double valueHours,double expected ) 
        {
            //Given
            var exercise = new Questao1Prova ();

            //When
            var result = exercise.Questao1 (hours, valueHours);

            //Then
            Assert.Equal (expected, result);

        }
    }
}