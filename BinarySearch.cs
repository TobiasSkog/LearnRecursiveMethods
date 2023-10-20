namespace LearnRecursiveMethods
{
    // Binary Search (Intermediate):Create a recursive function to perform a
    // binary search on a sorted array. This will involve dividing
    // the array in half and searching for a target value.
    public static class BinarySearch
    {
        public static int Search(int[] sortedArray, int target, int low, int mid, int high)
        {
            if (sortedArray.Length <= 1)
            {
                return -1;
            }
            if (target == sortedArray[low])
            {
                return low;
            }
            if (target == sortedArray[mid])
            {
                return mid;
            }
            if (target == sortedArray[high])
            {
                return high;
            }



            if (target > sortedArray[mid])
            {
                return Search(sortedArray, target, mid, ((high / 2) + (mid / 2)), high);
            }
            else
            {
                return Search(sortedArray, target, low, mid / 2, mid);
            }
        }

    }
}
