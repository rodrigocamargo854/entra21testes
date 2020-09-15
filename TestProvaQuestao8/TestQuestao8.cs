using System;
using Xunit;
using System.Text;

namespace TestProvaQuestao8 {
    public class TestQuestao8 
    {
        [Fact]
        public void Should_be_return_Names_Of_Students_who_in_Full_Time () 
        {

            string expected = "";

            expected = "rodrigo Matheus Joao";

            var exercise = new Questao8Prova ();

            var vespnames = new string[] { "rodrigo", "Matheus", "Joao" };
            var matnames = new string[] { "rodrigo", "Matheus", "Joao" };


            var result = exercise.Questao8 (vespnames,matnames);
            
            
            
            Assert.Equal(expected,result);



        }
    }
}