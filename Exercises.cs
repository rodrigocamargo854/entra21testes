using System;

namespace entra21_tests {
    public class Exercises { // classe sempre publica
        public int[] Exercise1A () {
            var numbers = new int[10];

            for (int counter = 1; counter < 11; counter++) {
                numbers[counter - 1] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1b,
        // então a aplicação deverá retornar todos os números de 1 a 10 de forma decrescente
        public int[] Exercise1B () {
            int[] numbers = new int[10];

            for (int counter = 10; counter > 0; counter--) {
                numbers[numbers.Length - counter] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
        // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares
        public int[] Exercise1C () {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter += 2) {
                var index = (counter / 2) - 1;
                numbers[index] = counter;
            }

            return numbers;
        }

        // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 12,
        // então a aplicação deverá retornar a soma dos numeros de 1 a 100
        public int Exercise2 () {
            var numbers = 0;

            for (int i = 0; i <= 100; i++) {
                numbers += i;
            }

            return numbers;
        }
        //void n retorna nada
        public double Exercise5 (int[] ages)// sem o params tenho q isntanciar e encapsular

        {
            var counter = 0;
            var WomenAges = 0;
            


            for (counter = 0; counter < ages.Length; counter++) 
            {
                if (ages[counter] > 18 && ages[counter] < 35) 
                {
                    WomenAges++;
                }
            }

            double result = (WomenAges * 100) / counter;

            return result;
            

        }

    }
}