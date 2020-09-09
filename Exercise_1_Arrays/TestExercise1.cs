using System;
using Xunit;

namespace Exercise_1_Arrays {
    public class TestExercise1 {

        [Fact]
        public void Should_return_a_Arrays_with_the_15_elements_resulting_of_others_Two_Arrays ()

        {

            //Given
            var exercise = new ArraysListExercise1cs ();
            var arrayA = new double[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var arrayD = new double[15] { 1, -1, 3, 4, 5, 6, 7, -8, 9, 10, 11, -12, 13, 14, 15 };

            //When
            var result = exercise.Exercise1 (arrayA, arrayD);

            Assert.Collection (
                result,
                i1 => { Assert.Equal (0, i1); },
                i2 => { Assert.Equal (3, i2); },
                i3 => { Assert.Equal (0, i3); },
                i4 => { Assert.Equal (0, i4); },
                i5 => { Assert.Equal (0, i5); },
                i6 => { Assert.Equal (0, i6); },
                i7 => { Assert.Equal (0, i7); },
                i8 => { Assert.Equal (16, i8); },
                i9 => { Assert.Equal (0, i9); },
                i10 => { Assert.Equal (0, i10); },
                i11 => { Assert.Equal (0, i11); },
                i12 => { Assert.Equal (24, i12); },
                i13 => { Assert.Equal (0, i13); },
                i14 => { Assert.Equal (0, i14); },
                i15 => { Assert.Equal (0, i15); }

            );

        }
    }
}