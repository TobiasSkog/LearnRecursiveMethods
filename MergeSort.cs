namespace LearnRecursiveMethods
{
    public static class MergeSort
    {
        public static void Sort(int[] array)
        {
            if (array.Length <= 1)
            {
                return;
            }

            var mid = array.Length / 2;
            var left = new int[mid];
            var right = new int[array.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (int i = mid; i < array.Length; i++)
            {
                right[i - mid] = array[i];
            }
            Sort(left);
            Sort(right);
            Merge(array, left, right);

        }
        private static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                array[k++] = left[i++];
            }
            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }
    }
}
