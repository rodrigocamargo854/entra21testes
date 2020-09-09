namespace Exercise_2_Arrays
 {

    public class ArraysListExercise2 
    {

        public double[,] Exercise2 ( double[] array10Int) 
        {

            var matrizArrays = new double[2,2];

            for (int i = 1; i < 2; i++) 
            {
                for (int j = 0; j < array10Int.Length; i++)

                {
                    matrizArrays[i,j] = array10Int[j];
                }   
            }
     
            for (int i = 2; i < 3; i++) 
            {
                for (int j = 0; j < array10Int.Length; i++)

                {
                    matrizArrays[i,j] = array10Int[j];
                }   
            }

            return matrizArrays;
        }
    }
}