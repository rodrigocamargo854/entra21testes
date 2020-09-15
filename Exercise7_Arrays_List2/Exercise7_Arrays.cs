namespace Exercise7_Arrays_List2 {
    public class Exercise7_Arrays {
        public int Exercise7 (int[] x)
         {
            var count = 0;

            for (int i = 0; i < x.Length; i++) {
                if (x[i] == i) {
                    count++;
                }

            }

            return count;

        }
    }
}