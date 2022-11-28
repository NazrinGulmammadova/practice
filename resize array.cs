int[] arr = { 1, 2, 3, 4, 5 };
Array.Resize(ref arr, arr.Length + 3);

void Resize(ref int[] arr,int newSize)
{
    int[] arr2=new int[newSize];
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length)
        {
            arr2[i] = arr[i];
        }
        else
        {
            arr2[i] = 0;
        }

    }
    arr=arr2;
}
Console.WriteLine(arr.Length);