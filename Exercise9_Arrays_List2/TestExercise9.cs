using System;
using Xunit;
using System.Text;


namespace Exercise9_Arrays_List2 
{
    public class TestExercise9 
    {
        [Fact]
        public void Shold_Be_return_A_Word_With_All_Letter_In_Index_Pairs () {

            //Given
            var exercise = new Exercise9_Arrays ();
            var expected = "ary";
            var letters = new string[] { "a", "b", "r", "s", "y" };

            //When
            var result = exercise.Exercise9(letters);

            //Then

            Assert.Equal (expected, result);

        }
    }
}