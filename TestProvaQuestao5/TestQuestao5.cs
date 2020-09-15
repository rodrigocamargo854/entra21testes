using System;
using Xunit;

namespace TestProvaQuestao5 {
    public class TestQuestao5 {
        
        [Fact]
        public void Should_beAreturnA_Arrays_With_Null () 
        {
            //Given
            var exercise = new Questao5Prova();
            var input = new double?[]{1,2,3,4,null,5};

            //When
            var result = exercise.Questao5(input);
            var expected = new double?[]{1,2,3,4,5};

            //Then
            Assert.Equal(expected,result);    
           
        }
    }
}