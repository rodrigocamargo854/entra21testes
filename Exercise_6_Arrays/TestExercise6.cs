using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exercise_6_Arrays
 {
    public class TestExercise6
     {
        [Fact]
        public void Shold_Be_return_a_List_with_result_with_rev_order_and_Inv_Ord () 
        {

            //Given
            var exercise = new ArraysListExercise6 ();
            var listA = new List<double> () { 1, 2, 3, 4, 5, 6, 7 };
            var listB = new List<double> () {-1, -2, -3, 0, 1, 2, 3 };

            //When
            var result = exercise.Exercise6 (listA, listB);

            //Then
            Assert.Collection (
                result,
                i1 => { Assert.Equal (4, i1); },
                i2 => { Assert.Equal (4, i2); },
                i3 => { Assert.Equal (4, i3); },
                i4 => { Assert.Equal (4, i4); },
                i5 => { Assert.Equal (4, i5); },
                i6 => { Assert.Equal (4, i6); },
                i7 => { Assert.Equal (4, i7); }
            );

        }
    }
}