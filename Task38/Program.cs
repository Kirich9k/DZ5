void InputArray(int[]array){
	for (int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(0, 1000);
}

void ReleaseArray(int[] array){
    int different = 0;
    int min = 1000;
    int max = 0; 
	for (int i = 0; i < array.Length; i++){
		if (array[i] > max)
			max = array[i];          
	}
    for (int i = 0; i < array.Length; i++){
		if (array[i] < min)
			min = array[i];          
	}
    different = max - min;
	Console.WriteLine($"Разница между максимальным и минимальным: {different}");
}
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);