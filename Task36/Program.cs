void InputArray(int[]array){
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(0, 10);
}

void ReleaseArray(int[] array){
	int sumOddPositions = 0;
	for (int i = 0; i < array.Length; i++){
		if (i % 2 != 0)
			sumOddPositions = array[i] + sumOddPositions;
	}
	Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sumOddPositions}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);