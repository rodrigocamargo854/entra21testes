using System;
using Xunit;

namespace TestProvaQuestao6 {
    public class TestQuestao6 {
        [Fact]
        public void Should_Be_Average_of_Salary_of_Employers () {
            //Given
            var exercise = new Questao6Prova ();
            var input = new double[] { 4750.2, -2342, 50, 0, -1234 };
            var result = exercise.Questao6 (input);

            Assert.Equal (1600.07, result);
        }
    }
}
