namespace Exercise5_Arrays_List2 
{
    public class Exercise5_Arrays 
    {
        public int Exercicio5 (params double[] arrayA)
         {
            var count = 0.0;
            for (int i = 0; i < arrayA.Length; i++) 
            {
                if (arrayA[i] > 0) 
                {
                    count++;

                }
                
            }

            return count;

        }
    }
}