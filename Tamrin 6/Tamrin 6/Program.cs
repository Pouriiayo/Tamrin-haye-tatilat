//پوریا یوسفی

int[] arr = { 1, 0, 0, 4, 2, 2, 45, 2, 1, };
Movezero(arr);
foreach (int i in arr)
{
    Console.Write(i);
}
void Movezero(int[] arr)
{
    int index = 0;
    int temp;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != 0)
        {
            temp = arr[i];
            arr[i] = arr[index];
            arr[index] = temp;
            index++;
        }
    }
}