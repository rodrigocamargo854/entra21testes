namespace Exercise_1_Arrays {
    public class ArraysListExercise1cs {

        public double[] Exercise1 (double[] ArraysA, double[] ArraysB)

        {
            //1-Leia dois arrays A e B com 15 elementos. Construir um array C, onde
            //cada elemento de C é a subtração do elemento correspondente de A com B.
            //versão com inserção automatica dos arrays

            var c = 15;
            Arrays[] vect = new Arrays[c];
            var arraysF = new double[c];


            

            for (int i = 0; i < c; i++) 
            {
                vect[i] = new Arrays (ArraysA[i], ArraysB[i]);
                arraysF[i] = vect[i].Array1 - vect[i].Array2;   
            }

            return arraysF;
        }

    }

}