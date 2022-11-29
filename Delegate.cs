Console.WriteLine(CheckIndex(new int[] {-1,3,-2,4}, Positive));

//int CheckIndex<int>(int[] arr, Check<int> check)
int CheckIndex<T>(T[] arr, Check<T> check)
{
	for (int i = 0; i < arr.Length; i++)
    {
	  if (check(arr[i]))
	  {
			return i;
	  }
    }
	return -1;
}

bool Positive(int element)
{
	if(element> 0)
		return true;

	return false;
}


//delegate bool Check<int>(int element);
delegate bool Check<K>(K element);