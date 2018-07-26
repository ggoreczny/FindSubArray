using System.Linq;

namespace FindArray
{
    public class MyFindArray
    {
        static void Main(string[] args)
        {
        }

        public int FindArray(int[] array, int[] subArray)
        {
            if (!subArray.Any())
            {
                return -1;
            }

            for (var i = 0; i < array.Length; i++)
            {
                if (IsSubArray(array, subArray, i))
                {
                    return i;
                }
            }

            return -1;

        }

        private static bool IsSubArray(int[] array, int[] subArray, int index)
        {
            if (index + subArray.Length > array.Length)
            {
                return false;
            }

            return !subArray.Where((t, i) => array[i + index] != t).Any();
        }
    }
}
