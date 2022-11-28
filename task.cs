int[] arr = { 1, 2, 3, 4, 5 };
int num = 6;
int new_size = 9;
void Resize(ref int[] arr, int newSize, int addNum)
{
    int[] arr2 = new int[newSize];
    if (arr.Length<newSize)
    {
        newSize=arr.Length;
    }
    for (int i = 0; i < newSize; i++)
    {

            arr2[i] = arr[i];
        

    }
    arr = arr2;
    arr2[arr.Length-1] = addNum;
    for (int index=0; index < arr2.Length; index++)
    {
        Console.WriteLine(arr2[index]);
    }
}
Resize(ref arr, new_size, num);