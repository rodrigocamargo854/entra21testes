using System.Collections.Generic;
using Xunit;
namespace entra21_tests {
    public class ExercisesTest {
        [Fact]
        public void should_return_an_array_from_1_to_10 () {
            // BDD - Behavior Driven Design
            // Dado, Quando, Deve

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1,
            // então a aplicação deverá retornar todos os número de 1 a 10

            // Dado / Setup
            var exercises = new Exercises ();

            // Quando / Ação
            var result = exercises.Exercise1A ();

            // Deve / Asserções
            var expectedOutput = new int[10] {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };

            for (int i = 0; i < expectedOutput.Length; i++) {
                Assert.Equal (expectedOutput[i], result[i]);
            }
        }

        [Fact]
        public void should_return_an_array_from_10_to_1 () {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
            // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente

            // arrange
            var exercises = new Exercises ();

            // act
            int[] returnedValues = exercises.Exercise1B ();

            // assert
            var expectedOutput = new int[10] {
                10,
                9,
                8,
                7,
                6,
                5,
                4,
                3,
                2,
                1
            };

            for (int i = 0; i < expectedOutput.Length; i++) {
                Assert.Equal (expectedOutput[i], returnedValues[i]);
            }
        }

        [Fact]
        public void should_return_an_array_from_1_to_10_but_only_even () {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // arrange
            var exercises = new Exercises ();

            // act
            int[] returnedValues = exercises.Exercise1C ();

            // Assert
            var expectedOutput = new int[5] {
                2,
                4,
                6,
                8,
                10
            };

            Assert.Equal (5, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++) {
                Assert.Equal (expectedOutput[i], returnedValues[i]);
            }
        }

        [Fact]
        public void should_return_a_Sum_of_all_numbers_between_1_and_100 () {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar a soma dos numeros entre 1 a 100

            // arrange
            var exercises = new Exercises ();

            // act
            int returnedTotalSum1_100 = exercises.Exercise2 ();

            // assert

            Assert.Equal (5050, returnedTotalSum1_100);

            //podemos utilizar a formula da p.a.
            // Soma = (a1 + an) x n / 2

            // a1 = primeiro termo = 1
            // an = último termo = 100
            // n = número de termo = 100

            // Soma = (1 + 100) x 100 / 2
            // Soma = 101 x 50
            // Soma = 5.050
        }

        [Fact]

        public void Ex4_should_return_a_average_of_students_type_digit_0_the_aplication_must_stop () {

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
            // quando a aplicação receber a idade de 5 mulheres
            // deve retornar a porcentagem de mulheres que tem a idade entre 18 e 35

            // arrange
            var exercices = new Exercises ();
            var mylist = new List<int> () { 6, 6, 6 };

            //act
            double result = exercices.Exercise4 (mylist); // é preciso instanciar e encapsular dentro da instancia

            //assert
            Assert.Equal (6, result);
        }

        [Fact]

        public void should_return_a_percent_of_women_between_18_and_35_years_with_theory () {

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
            // quando a aplicação receber a idade de 5 mulheres
            // deve retornar a porcentagem de mulheres que tem a idade entre 18 e 35

            // arrange
            var exercises = new Exercises ();

            //act
            int[] idades = new int[5] { 23, 25, 45, 69, 89 }; // é preciso instanciar e encapsular dentro da instancia

            //assert
            var resultado = exercises.Exercise5 (idades);
            Assert.Equal (40, resultado);
        }

        //with theory , 2 tests ok
        [Theory]

        [InlineData (6, 3, 4.50, 1478.25)]
        [InlineData (6, 8, 3.50, 3066)]
        [InlineData (6, 5, 5.20, 2847)]

        public void Ex7_should_return_the_cost_of_cigarette_smoking_for_years (int years, int cigars, double price, double expected) {

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 7,
            // quando a aplicação receber o números de cigarros consumidos por dia e a quantidade
            //de anos de fumante deve retornar o custo total com duas casas decimais

            //arrange
            var exercises = new Exercises ();
            //act
            var resultado = exercises.Exercise7 (years, cigars, price);

            // assert
            Assert.Equal (expected, resultado);
        }

        [Theory]

        [InlineData (6, 3, true)]
        [InlineData (9, 3, true)]
        [InlineData (8, 4, true)]

        public void should_return_True_if_number1_is_a_multiple_of_number2_Ex8 (int number1, int number2, bool expected) {

            // Dado que a aplicação está preparada, quando o usuário chamar o exercicio 8
            // quando a aplicação receber dois numeros inteiros, deve retornar True se o primeiro numero
            //for multiplo do segundo numero

            //arrange
            var exercises = new Exercises ();
            //act
            var isMultiple = exercises.Exercise8 (number1, number2);

            // assert//podemos mudar para Assert.True e utlizar somente o expected?
            Assert.Equal (expected, isMultiple);
        }

        [Theory]

        [InlineData (5, 3, 3, false)]

        public void should_return_True_if_number_bigger_Sum_number2_with_numer3 (int number1, int number2, int number3, bool expected) {

            // Dado que a aplicação está preparada, quando o usuário chamar o exercicio 8
            // quando a aplicação receber três numeros , deve retornar True se o primeiro numero
            //for maior que a soma  do segundo com o terceiro

            //Dado setup
            var exercises = new Exercises ();
            //Quando
            var isMoreBigger = exercises.Exercise9 (number1, number2, number3);

            // Deve
            Assert.Equal (expected, isMoreBigger);
        }

        [Theory]

        [InlineData (0, -3, true)]
        [InlineData (0.5, -1.2, true)]
        [InlineData (5, 3, true)]

        public void Ex_10__Shold_be_return_True_if_the_first_number_are_biggest_of_the_second_number (double number1, double number2, bool expected) {

            // Dado a aplicação esta preparada a aplicação deverá 
            //receber 2 números reais do teclado (A e B)
            //Caso 1º numero for maior que o 2º numero a aplicação deverá retornar true. 
            // é maior, ou a mensagem "A = B" caso sejam iguais.

            //Dado setup
            var exercises = new Exercises ();

            //Quando
            var AmaiorB = exercises.Exercisce10AmaiorB (number1, number2);

            // Deve
            Assert.Equal (expected, AmaiorB);
        }

        [Theory]

        [InlineData (5, 8, true)]
        [InlineData (8, 8, false)]
        [InlineData (5, 10, true)]
        public void Ex_10__Shold_be_return_True_if_the_second_number_is_biggest_of_the_first_number (double number1, double number2, bool expected) {

            // Dado a aplicação esta preparada a aplicação deverá 
            //receber 2 números reais do teclado (A e B)
            //Caso 2º numero for maior que  1º numero a aplicação deverá retornar true. 

            //Dado setup
            var exercises = new Exercises ();

            //Quando
            var BmaiorA = exercises.Exercisce10BmaiorA (number1, number2);

            // Deve
            Assert.Equal (expected, BmaiorA);
        }

        [Theory]

        [InlineData (5, 5, true)]
        public void Ex_10__Shold_be_return_True_if_the_first_number_are_Equal_of_the_second_number (double number1, double number2, bool expected) {

            // Dado a aplicação esta preparada a aplicação deverá 
            //receber 2 números reais do teclado (A e B)
            //Caso 1º numero for igual  ao 2º numero a aplicação deverá retornar true. 

            //Dado setup
            var exercises = new Exercises ();

            //Quando
            var AequalB = exercises.Exercisce10AequalB (number1, number2);

            // Deve
            Assert.Equal (expected, AequalB);
        }

        [Theory]

        [InlineData (5, 0, true)]
        public void Ex_11_if_the_second_numberIs_equal_a_zero_return_true (double number1, double number2, bool expected) {

            // Dado a aplicação esta preparada a aplicação deverá 
            //receber 2 números reais do teclado (A e B)
            //Caso o numero 2 for igual a zero a aplicaçao devera retornar False 

            //Dado setup
            var exercises = new Exercises ();

            //Quando
            var TheNumberOneIsZero = exercises.Exercise11_if_number2_equal_zero (number1, number2);

            // Deve
            Assert.Equal (expected, TheNumberOneIsZero);
        }

        [Theory]

        [InlineData (5, 2, 2.5)]
        [InlineData (6, 3, 2)]
        [InlineData (8, 2, 4)]

        public void Ex11_TheQuocientOfBetweenFirstNumberAndTheSecondNumber (double number1, double number2, double ? expected) {

            // Dado a aplicação esta preparada a aplicação deverá 

            //receber 2 números reais do teclado (A e B)
            //A aplicação deverá retornar o quociente do primeiro com o segundo digito  

            //Dado setup
            var exercises = new Exercises ();

            //Quando
            var DivisionOfSecForFirst = exercises.Exercise11_Division_of_number1_for_numer2 (number1, number2);

            // Deve
            Assert.Equal (expected, DivisionOfSecForFirst);
        }

        [Theory]

        [InlineData (5,2,6,4,12)]
        [InlineData (3,2,6,5,8)]
        [InlineData (8,2,6,1,16)]

        public void Ex12_Sum_Of_Pairs (double number1, double number2, double number3, double number4, double result) {

            // Dado a aplicação esta preparada a aplicação deverá 

            //receber 4 numeros e retornar a soma somente dos numeros pares

            //Dado setup
            var exercises = new Exercises ();

            //Quando

            var resultSumPairs = exercises.Exercise12_SumPairs (number1,number2,number3,number4);

            // Deve
            Assert.Equal (result, resultSumPairs);
        }

        [Fact]

        public void Ex13_return_the_biggest ( ) 
        {

            // Dado a aplicação esta preparada a aplicação deverá 

            //receber 10 numeros e retornar omaior numero

            //Dado setup
            var exercises = new Exercises ();

            //Quando

            var thebiggestnumber = exercises.Exercise13_return_the_biggest(1,3,5,4,7,8,9,63,45,5);

            // Deve
            Assert.Equal (63, thebiggestnumber);
        }
    }
}