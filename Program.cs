// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void RandArray(int[] collection)                    //  метод наполняет массив случайными числами
{
	for (int i=0; i<collection.Length; i++)
        collection[i] = new Random().Next(1,100);
}
 
void PrintArray(int[] collection)                   //  метод выводит массив на консоль
{
	for (int i=0; i<collection.Length; i++)
        Console.Write($"{i+1}) {collection[i]}    ");
}

int[] array = new int[8];
RandArray(array);                                   //  вызов метода по наполнению массива
PrintArray(array);                                  //  вызов метода по выводу массива на консоль