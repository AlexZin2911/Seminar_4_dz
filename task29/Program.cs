// Задача 29. Пользователель вводит 8 чисел.
// Поместите их в массив и распечатайте.
Console.WriteLine();
Console.WriteLine("_____________________________________________________________________________________");
Console.Write("Введите желаемое количество элементов в массиве (число/цифра должны быть целыми)");
Console.WriteLine("Нажмите Enter после ввода или Ctrl + C, если передумали");

bool numBool = false;
int num = 0;

while (!numBool)
{
    Console.WriteLine("Вы ввели не целое чило, попробуйте еще раз.");
    numBool = int.TryParse(Console.ReadLine()!, out num);
}

int[] array = CreateArray(num);
Console.WriteLine();
AddedArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

int[] CreateArray(int num)
{
    int[] array = new int[num];
    Console.WriteLine($"Рандомный массив с желаемым количеством элементов {num}");
    return array;
}

void AddedArray(int[] randomArray)
{
    for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(0, 10001);
    }
}

void PrintArray(int[] array)
{
    foreach (int elem in array)
    {
        Console.Write($"{elem} ");
    }
    
}

Console.WriteLine("_____________________________________________________________________________________");
