using System;
using Xunit;
using System.Collections.Generic;

namespace Exercise3_Arrays_List2 
{
    public class TestExercise2 
    {
        [Fact]
        public void Should_be_Return_True () 
        {
            //Given
            var exercise = new Exercise2_Arrays ();
            var listTest = new List<double> () { 1, 2, 4, 4, 5, 6, 7, 8 };

            //When
            var result = exercise.Exercise2 (listTest);

            //Then
            Assert.Equal (true, result);

        }
    }
}