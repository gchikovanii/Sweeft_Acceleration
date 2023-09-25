#region Task N.1

//bool IsPalindrome(string text)
//{
//    if(text.Length <= 1)
//        return true;
//    else
//    {
//        if (text[0] != text[text.Length - 1])
//        {
//            return false;
//        }
//        return IsPalindrome(text.Substring(1, text.Length - 2));
//    }
//}

//Console.WriteLine(IsPalindrome("aacaa"));
//Console.WriteLine(IsPalindrome("aacaa1"));


#endregion

#region Task N.2
//int MinSplit(int amount)
//{
//	int count = 0;
//    int[] coins = new int[] { 1, 5, 10, 20, 50 };
//	for (int i = coins.Length - 1; i >=0 ; i--)
//	{
//		if (amount % coins[i] == 0)
//		{
//			count += amount / coins[i];
//			break;
//		}
//		if (amount / coins[i] == 0)
//			continue;
//		if(amount / coins[i] > 0)
//		{
//            count += amount / coins[i];
//			amount %= coins[i];
//        }
//	}
//	return count;
//}
//Console.WriteLine(MinSplit(50));
//Console.WriteLine(MinSplit(3));
//Console.WriteLine(MinSplit(13));
//Console.WriteLine(MinSplit(49));

#endregion


#region Task.3
//int NotContains(int[] array)
//{
//	int temp;
//	for (int i = 0; i < array.Length; i++)
//	{
//		for (int j = 0; j < array.Length - 1; j++)
//		{
//            if (array[j] < array[j + 1])
//			{
//				temp = array[j];
//				array[j] = array[j + 1];
//				array[j + 1] = temp;
//			}
//		}
//	}
//	int MinValue = array[array.Length - 1];
//	if(MinValue - 1 != 0)
//		return MinValue - 1;
//	else
//	{
//        for (int i = array.Length - 1; i > 0; i--)
//        {
//            if (array[i] != 1)
//            {
//                return array[i] - 1;
//            }
//        }
//        throw new Exception("Only 1 is in array");
//    }
//}
//Console.WriteLine(NotContains(new int[] {1,12,5,7,1,1,13})); 

#endregion

#region Task.4
//bool IsProperly(string sequence)
//{
//    int leftCount = 0;
//    int rightCount = 0;
//    for (int i = 0; i < sequence.Length; i++)
//    {
//        if (sequence[i] == '(')
//            leftCount++;
//        else if (sequence[i] == ')')
//            rightCount++;
//    }
//    return leftCount == rightCount && rightCount > 0 ? true : false;
//}
//Console.WriteLine(IsProperly("(()())"));
//Console.WriteLine(IsProperly("())()"));


#endregion

#region Task.5

//int CountVariants(int stairCount)
//{
//    if (stairCount < 0)
//        return 0;
//    if (stairCount == 0)
//        return 1;
//    return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
//}
//Console.WriteLine(CountVariants(3));
//Console.WriteLine(CountVariants(5));

#endregion