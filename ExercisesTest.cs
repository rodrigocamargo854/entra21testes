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

            // Dado / Setup
            var exercises = new Exercises ();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1B ();

            // Deve / Asserções
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

            // Dado / Setup
            var exercises = new Exercises ();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C ();

            // Deve / Asserções
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
        public void should_return_a_Sum_of_all_numbers_between_1_and_10 () {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar a soma dos numeros entre 1 a 100

            // Dado / Setup
            var exercises = new Exercises ();

            // Quando / Ação
            int returnedTotalSum1_100 = exercises.Exercise2 ();

            // Deve / Asserções

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
        public void should_return_a_Sum_of_all_numbers_between_1_and_100 () {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar a soma dos numeros entre 1 a 100

            // Dado / Setup
            var exercises = new Exercises ();

            // Quando / Ação
            int returnedTotalSum = exercises.Exercise2 ();

            // Deve / Asserções

            Assert.Equal (returnedTotalSum, returnedTotalSum);

        }

        [Fact]
        public void should_return_a_percent_of_women_between_18_and_35_years () {

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
            // quando a aplicação receber a idade de 5 mulheres
            // deve retornar a porcentagem de mulheres que tem a idade entre 18 e 35

            var exercises = new Exercises ();
            int[] idades = new int[5] { 23, 25, 45, 69, 89 }; // é preciso instanciar e encapsular dentro da instancia

            var resultado = exercises.Exercise5 (idades);
            Assert.Equal (40, resultado);

        }

    }
}