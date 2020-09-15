using System;
using Xunit;

namespace Exercise5_Arrays_List2
{
    public class TestExercise5
    {
         
        [Theory]

        [InlineData (new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10)]
        [InlineData (new double[] { -2, -2, -3, -4, -5, -6, -7, 8, 9, 10 }, 3)]

        [InlineData (new double[] { -1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 9)]

        [InlineData (new double[] { 1, 2, 3, 4, 5, -6, 7, -8, -9, 10 }, 7)]

        public void Should_be_return_The_Sum_of_All_Item_of_Array (double[] input, double expected) {
            //Given
            var exercise = new Exercise5_Arrays ();

            //When
            var result = exercise.Exercicio5 (input);

            //Then
            Assert.Equal (expected, result);

        }
    }
}
