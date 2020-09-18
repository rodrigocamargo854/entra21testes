using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xunit;

namespace Exercise1_Arrays_List2 
{
    public class TestExercise1 
    {
        [Fact]
        public void Should_Be_Return_A_Vector () 
        {
            var exercise = new Exercise1_Arrays ();
            var listA = new List<double> () { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var listB = new List<double> () { -1, -2, -3, -4, -5, -6, -7, -8, -9 };

            var result = exercise.Exercise1 (listA,listB);



        }
    }
}