void InputArray(int[]array){
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(100, 1000);
}

void ReleaseArray(int[] array){
	int sumEven = 0;
	for (int i = 0; i < array.Length; i++){
		if (array[i] % 2 == 0)
			sumEven = sumEven + 1;
	}
	Console.WriteLine($"Кол-во чётных чисел: {sumEven}");
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);