using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exercise6_Arrays_List2 {
    public class TestExercise6 {
        [Fact]
        public void Shold_be_return_The_Biggest_Number_and_Index () {

            //given
            var exercise = new Exercise6_Arrays ();
            var list = new List<double> () { 0, -1, -22, 3, -4, 5, 8 };

            //When
            var result = exercise.Exercicio6 (list);

            //Then
            Assert.Equal ((8,0), result);

        }
    }
}