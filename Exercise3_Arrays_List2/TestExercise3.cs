using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Exercise3_Arrays_List2 
{
    public class TestExercise3 
    
    {
        (int woman, double answerYes, double answerNo) woman = (4, 2, 1);
        (int man, double answerYes, double answerNo) men = (2, 1, 1);

        [Fact]
        public void Should_Return_How_Many_People_Answered_Yes () 
        {
            //Given
            var exercise = new Exercicio3_Arrays ();

            //When
            var result =  exercise.PeopleAnsweredYes(men.answerYes, woman.answerYes);

            Assert.Equal (3, result);
        }

         [Fact]
        public void Should_Return_How_Many_People_Answered_No () 
        {
            //Given
            var exercise = new Exercicio3_Arrays ();

            //When
            var result =  exercise.PeopleAnsweredNo(men.answerNo, woman.answerNo);

            Assert.Equal (2, result);
        }
        
        [Fact]
        public void Should_Return_Percent_Of_Men_Answers_No () 
        {
            //Given
            var exercise = new Exercicio3_Arrays ();

            //When
            var result =  exercise.PercentageOfMenAnsweredNo(men.answerNo, men.man);

            Assert.Equal (50.0, result);
        }

         [Fact]
        public void Should_Return_Percent_Of_Women_Answers_No () 
        {
            //Given
            var exercise = new Exercicio3_Arrays ();

            //When
            var result =  exercise.PercentageOfMenAnsweredNo(woman.answerNo,woman.woman);

            Assert.Equal (25.0, result);
        }

        
        
       
    }
}