namespace Exercise4_Arrays_List2
{
    public class Exercise4_Arrays
    {
        public double Exercicio4(params double[] arrayA)
        {
            var count = 0.0;
            for (int i = 0; i < arrayA.Length; i++)
            {
                count += arrayA[i];
            }

            return count;

        }
        
    }
}