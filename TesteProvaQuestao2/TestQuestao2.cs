using System;
using Xunit;

namespace TesteProvaQuestao2
{
    public class UnitTest1
    {
        [Fact]
        public void Shold_Be_a_Word()
        {
            //Given
            var exercise = new Questao2Prova();
            var str = new string[]{"a","b","c"};

            //when
            var result = exercise.Questao2(str,2);

            //then
            Assert.Equal("abc",result);


        }
    }
}
