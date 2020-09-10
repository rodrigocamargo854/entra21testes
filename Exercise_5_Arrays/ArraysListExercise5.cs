namespace Exercise_5_Arrays {
    public class ArraysListExercise5 {

        public double Exercise5 (params double[] numbers)

        {
            var media = 0.0;
            var x = 0.0;
            var underAverage = 0.0;
            var count = 0;

            for (count = 0; count < numbers.Length; count++) 
            {
                x += numbers[count];
            }

            media = x / count;

            for (var i = 0; i < numbers.Length; i++) {
                if (numbers[i] > media) {

                    underAverage++;

                }
            }

            return underAverage;
        }

    }
}