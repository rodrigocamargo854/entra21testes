using System;
using System.Collections.Generic;

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

        public double Exercise4 (List<int> ages) // sem o params tenho q instanciar e encapsular

        {

            double sum = 0.0;
            var answers = ages.Count;

            foreach (var item in ages) {
                sum += item;
            }

            var average = sum / answers;

            return average;

        }

        public double Exercise5 (int[] ages) // sem o params tenho q instanciar e encapsular

        {
            var counter = 0;
            var WomenAges = 0;

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 5,
            // quando a aplicação receber im array com idades de 5 mulheres, deverá retornar a porcentagem 
            //das mulheres que estão entre 18 anos e 35 anos

            for (counter = 0; counter < ages.Length; counter++) {
                if (ages[counter] > 18 && ages[counter] < 35) {
                    WomenAges++;
                }
            }

            double result = (WomenAges * 100) / counter;

            return result;

        }

        public double Exercise7 (int cigarYears, int numberCigarsDay, double price) {

            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 7,
            // quando a aplicação receber o números de cigarros consumidos por dia e a quantidade
            //de anos de fumante deve retornar o custo total com duas casas decimais
            double calcPreco = 0.0;

            double finalPrice = (price / 20);

            calcPreco = (finalPrice * numberCigarsDay) * 365; // 1 ano
            double total = calcPreco * cigarYears;

            return Math.Round (total, 2);

        }

        public bool Exercise8 (int number1, int number2) {

            // A aplicação receberá dois números inteiros e deve retornar 
            //  True  o primeiro número é multiplo do segundo número

            bool isMultiple = true;
            isMultiple = number1 % number2 == 0;

            return isMultiple;
        }

        //A aplicação deverá receber tres numeros 
        // e retornar True se o primeiro digito for maior 
        // que a soma dos outros dois.
        public bool Exercise9 (int number1, int number2, int number3) {
            //fazer este

            bool type1 = number1 > (number2 + number3);

            return type1;
        }

        //A aplicação deverá receber dois numeros 
        // e retornar True se o primeiro digito for igual ao
        // segundo digito

        public bool Exercisce10AequalB (double number1, double number2) => number1 == number2;
        //A aplicação deverá receber dois numeros 
        // e retornar True se o primeiro digito for igual ao
        // segundo digito

        public bool Exercisce10AmaiorB (double number1, double number2) => number1 > number2;
        //A aplicação deverá receber dois numeros 
        // e retornar True se o segundo digito for maior que o
        // primeiro digito
        public bool Exercisce10BmaiorA (double number1, double number2) => number2 > number1;

        // Aplicação deverá receber dois numeros
        // se o segundo digito for diferente de zero, aplicação deverá retornar 
        // do primeiro digito pelo segundo, caso o segundo seja igual a zero
        //a aplicação deverá retornar false

        public bool Exercise11_if_number2_equal_zero (double number1, double number2) => number2 == 0;

        public double Exercise11_Division_of_number1_for_numer2 (double number1, double number2) => number1 / number2;

        // Aplicação deverá receber 4 números e retornar a soma dos que forem pares.

        public double Exercise12_SumPairs (double number1, double number2, double number3, double number4) {

            double sumPairs = 0.0;

            List<double> numbers = new List<double> { };
            numbers.Add (number1);
            numbers.Add (number2);
            numbers.Add (number3);
            numbers.Add (number4);

            foreach (var item in numbers) {
                if (item % 2 == 0) {
                    sumPairs += item;
                }
            }

            return sumPairs;

        }

        public double Exercise13_return_the_biggest (params int[] numbers) 
        {
            double biggest = 0.0;

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] > biggest)

                {
                    biggest = numbers[i];
                }
            }

            return biggest;

        }

    }

}