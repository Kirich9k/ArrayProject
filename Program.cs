string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
		
int LenghtCondition = 3;
		
string[] ConditionArray(string[] array)
{
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
    for (int i = 0; i < length; i++)
	{
		if(array[i].Length <= LenghtCondition)
		{
			result[count] = array[i];
			count++;
		}
	}
	Array.Resize(ref result, count);	
	return result;
}
void PrintArray(string[] array)
{
	if(array.Length == 0)
		Console.WriteLine("Массив пуст");
	else
		Array.ForEach(array, (str) => Console.Write($"{str} "));
		Console.WriteLine();

}
		
void Solution(string[] array)
{
	Console.WriteLine("Исходный массив:");
	PrintArray(array);
	string[] Condition = ConditionArray(array);
	Console.WriteLine($"Массив, в котором каждый элемент имеет длину меньше или равную {LenghtCondition} символам):");
	PrintArray(Condition);
	Console.WriteLine();
}
Solution(arr1);
Solution(arr2);
Solution(arr3);