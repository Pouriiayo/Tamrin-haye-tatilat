//پوریا یوسفی 
// تمرین 3
int[] arr = { 3, 2, 1, -2, 34, -1, 23, 356, 1293, 129, -5, 0, -30, 90, 245, 98 };

//MergeSort.Mergesort(arr);
//BubbleSort.Bubblesort(arr);
InsertionSort.Inssort(arr);
foreach (var item in arr)
{
    Console.Write(item + " ");
}
public class BubbleSort
{
    public static void Bubblesort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            bool swapped = false;

            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break; //برای اینکه اگر مرتب شده بود دوباره شروع نکنه
            }
        }

    }
}

public class MergeSort
{
    public static void Mergesort(int[] array)
    {
        int length = array.Length;
        if (length <= 1) return;

        int middle = length / 2;

        int[] leftarray = new int[middle];
        int[] rightarray = new int[length - middle];

        int i = 0;
        int j = 0;

        for (; i < length; i++)
        {
            if (i < middle)
            {
                leftarray[i] = array[i];
            }
            else
            {
                rightarray[j] = array[i];
                j++;
            }
        }

        Mergesort(leftarray);
        Mergesort(rightarray);


        Merge(array, leftarray, rightarray);


    }

    public static void Merge(int[] array, int[] leftarray, int[] rightarray)
    {

        int leftsize = array.Length / 2;
        int rightsize = array.Length - leftsize;

        int i = 0, l = 0, r = 0;

        while (l < leftsize && r < rightsize)
        {
            if (leftarray[l] < rightarray[r])
            {
                array[i] = leftarray[l];
                l++;
                i++;
            }
            else
            {
                array[i] = rightarray[r];
                r++;
                i++;
            }
        }

        while (l < leftsize)
        {
            array[i] = leftarray[l];
            i++;
            l++;
        }

        while (r < rightsize)
        {
            array[i] = rightarray[r];
            i++;
            r++;
        }
    }
}

public class InsertionSort
{
    public static void Inssort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int temp = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > temp)
            {
                array[j + 1] = array[j];
                j--;
            }


            array[j + 1] = temp;
        }

    }
}