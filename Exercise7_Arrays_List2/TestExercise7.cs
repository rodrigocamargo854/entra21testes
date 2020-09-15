using System;
using Xunit;

namespace Exercise7_Arrays_List2 {
    public class TestExercise7 {
        [Fact]
        public void Should_be_return_How_Many_Times_The_Number_is_Equal_a_index () {
            //Given
            var exercise = new Exercise7_Arrays ();
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7 };

            //When    
            var result = exercise.Exercise7 (numbers);

            //Then            
            Assert.Equal (8, result);

        }
    }
}