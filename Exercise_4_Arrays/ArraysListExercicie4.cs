namespace Exercise_4_Arrays {
    public class ArraysListExercicie4 {

        public bool Exercise4 (double[] arrayA, double[] arrayB) {

            var n = 10;
            for (int i = 0; i < n; i++)

            {
                if (arrayA[i] != arrayB[i]) {
                    return false;
                }
            }

            return true;
        }

    }
}