using System;
using Xunit;

namespace Exercise_5_Arrays {
    public class TestExercise5

    {
        [Fact]
        public void Should_be_return_how_many_digits_are_below_of_the_average ()

        {
            //Given
            var exercise = new ArraysListExercise5 ();
            var input = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //When
            var result = exercise.Exercise5 (input);

            //Then

            Assert.Equal (7, result);

        }
    }
}