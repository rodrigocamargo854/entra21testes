using System;
using Xunit;

namespace Exercise8_Arrays_List2 {
    public class TestExercise8 {
        [Fact]
        public void Should_Be_Return_How_Many_Itens_Letters_Are_Vogal () {
            //Given
            var exercise = new Exercise8_Arrays ();
            var letters = new string[] { "a", "b", "c" };

            //Then
            var result = exercise.Exercise8 (letters);

            //When
            Assert.Equal (1, result);

        }
    }
}