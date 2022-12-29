namespace OneDimArrays3
{
    public static class Tasks
    {
        public static (int, int) Task1(int[] array)
        {
            int sum = 0, number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] !=0)
                {
                    sum += array[i];
                    number ++;
                }
                    
            }

                return (sum, number);
        }

        public static double Task2(int[] array, int a)
        {
            double result = 0.0;
            int b = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > a)
                {
                    result += array[i];
                    b ++;
                }
            }
            result /= b;

                return result;
        }

        public static int Task3(int[] array)
        {
            int result = 0;
            int min = array[0];
            int max = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            result = max - min;
            return result;
        }
    }
}
