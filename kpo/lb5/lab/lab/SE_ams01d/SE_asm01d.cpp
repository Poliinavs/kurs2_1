extern "C"
{
	int getmin(int arr[], int size)
	{
		int min = 2147483647;
		for (int i = 0; i < size; i++)
		{
			if (min > arr[i])
			{
				min = arr[i];
			}
		}
		return min;
	} 

	int getmax(int arr[], int size)
	{
		int max = -2147483648;
		for (int i = 0; i < size; i++)
		{
			if (max < arr[i])
			{
				max = arr[i];
			}
		}
		return max;
	}
}