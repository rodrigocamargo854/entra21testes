using System;
using Xunit;
using System.Collections.Generic;

namespace Exercise_3_Arrays {
    public class TestExercise3 {
        [Fact]
        public void Should_return_True_if_the_input_are_insie_Arrays () {

            //Given
            Exercise_3_Arrays exercise = new Exercise_3_Arrays ();
            var list = new List<double> (10) { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //when
            var result = exercise.Exercise3 (list, 5);

            Assert.Equal (true, result);

        }
    }
}