void InputArray(int[]array){
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(0, 10);
}

void ReleaseArray(int[] array){
	int sumEvenPositions = 0;
	for (int i = 0; i < array.Length; i++){
		if (i % 2 == 0)
			sumEvenPositions = array[i] + sumEvenPositions;
	}
	Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sumEvenPositions}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);