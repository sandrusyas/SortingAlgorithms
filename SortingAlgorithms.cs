using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
    public class SortingAlgorithms
    {
        public static async Task BubbleSortAsync(int[] array, Func<int[], int, int, Task> visualizeStep)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    await visualizeStep(array, j, j + 1);
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        await visualizeStep(array, j, j + 1);
                    }
                }
            }
            await visualizeStep(array, -1, -1);
        }

        public static async Task SelectionSortAsync(int[] array, Func<int[], int, int, Task> visualizeStep)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    await visualizeStep(array, minIndex, j);
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    (array[i], array[minIndex]) = (array[minIndex], array[i]);
                    await visualizeStep(array, i, minIndex);
                }
            }
            await visualizeStep(array, -1, -1);
        }

        public static async Task ShuttleSortAsync(int[] array, Func<int[], int, int, Task> visualizeStep)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    await visualizeStep(array, j, j - 1);
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
                    await visualizeStep(array, j, j - 1);
                    j--;
                }
            }
            await visualizeStep(array, -1, -1);
        }
    }
}
