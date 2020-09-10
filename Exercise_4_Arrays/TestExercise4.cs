using System;
using Xunit;

namespace Exercise_4_Arrays {
    public class TestExercise4 
    {
        [Fact]
        public void Should_be_return_true_if_the_arrays_are_equals () {
            //Given
            var exercise = new ArraysListExercicie4 ();
            double[] arrayA = new double[3] {1,0,3};
            double[] arrayB = new double[3] {1,2,3};

            var result = exercise.Exercise4 (arrayA,arrayB);

            //Then
            Assert.Equal (false, result);

        }
    }
}