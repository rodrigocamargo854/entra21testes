using System;
using Xunit;

namespace Exercise4_Arrays_List2 {
    public class TestExercise4

    {
        [Theory]

        [InlineData (new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 55)]
        [InlineData (new double[] { 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 56)]

        [InlineData (new double[] { -1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 53)]

        [InlineData (new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 55)]

        public void Should_be_return_The_Sum_of_All_Item_of_Array (double[] input, double expected) {
            //Given
            var exercise = new Exercise4_Arrays ();

            //When
            var result = exercise.Exercicio4 (input);

            //Then
            Assert.Equal (expected, result);

        }
    }
}