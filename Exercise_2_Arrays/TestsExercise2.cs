using System;
using Xunit;

namespace Exercise_2_Arrays {
    public class TestsExercise2

    {
        [Fact]

        public void Should_return_1_arrays_with_right_order_and_other_with_inverse_order () {
            //Given
            var exercise = new ArraysListExercise2 ();
            var input = new double[] { 1, 2, 3, 4 };

            //When
            var result = exercise.Exercise2 (input);
            var expected = ((1, 2, 3, 4), (4, 3, 2, 1));

            //Then

            Assert.Collection 
            (
                result,
                i11 => { Assert.Equal (1, i11); },
                i12 => { Assert.Equal (2, i12); },
                i13 => { Assert.Equal (3, i13); },
                i14 => { Assert.Equal (4, i14); },
                i21 => { Assert.Equal (4, i21); },
                i22 => { Assert.Equal (3, i22); },
                i23=> { Assert.Equal (2, i23); },
                i24 => { Assert.Equal (1, i24); }

            );

        }
    }
}