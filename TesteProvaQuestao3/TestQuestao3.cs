using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TesteProvaQuestao3 {
    public class TesteQuestao3 {
        [Fact]
        public void Should_Be_Return_The_Name_Of_Singles ()

        {
            //Given
            var exercise = new Questao3Prova ();
            var input = new (string names , string answers)[] {("Daniel", "yes"), ("Danilo", "não"), ("Mario", "YES")};

            // var expected = new StringBuilder("Daniel Mario ");
            

            //When
            var result = exercise.Questao3 (input);

            //Then

            Assert.Equal ("Daniel Mario ", result);//o result não é um SringBuilder, mas sim uma string

        }
    }
}