// Задача А. Программа заполняет массив 8 случайными числами. Напишите функцию, которая находит среднее 
// арифметическое чисел в массиве. Среднее арифметическое равно сумме, делёной на количество.

//Задача Б. Программа заполняет массив 8 случайными числами. Напишите функцию, которая принимает массив 
// и находит в нём наибольший элемент. Используйте накопительную переменную. Эта переменная изначально 
// равна первому элементу массива; когда встречается лучший кандидат на максимум, она его запоминает.

// Задача В. Программа заполняет массив 8 случайными числами. Напишите функцию, которая проверяет, 
// верно ли, что все числа в массиве чётные. Наличие хотя бы одного нечётного числа означает, что ответ — нет.

// Задача Г. Программа заполняет массив 8 случайными числами. Напишите функцию, которая проверяет, верно ли, 
// что числа в массиве идут по возрастанию. Если очередное число меньше предыдущего, ответ — нет.


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
PrintArray(array);
Console.WriteLine();
ArithmeticMean(array);
Console.WriteLine();
Max(array);
Console.WriteLine();
ParityСheck(array);
Console.WriteLine();
CheckArray(array);
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

void ParityСheck(int[] array)
{
    int count1 = 0;
    int count2 = 0;
    foreach (int elem in array)
    {
        if (elem % 2 == 0)
        {
            count1++;
        }
        else count2++;
    }

    if (count2 == 0)
    {
        Console.WriteLine("Задача В -> Все числа в массиве четные");
    }
    else Console.WriteLine("Задача В -> Не все числа в массиве четные");

    Console.WriteLine();
    Console.WriteLine($"Задача В -> Четных элементов в массиве {count1} а нечетных {count2}.");
}

void ArithmeticMean(int[] array)
{
    double avg = 0;
    foreach (int elem in array)
    {
        avg += elem;
    }
    avg /= array.Length;
    
    Console.WriteLine($"Задача А -> Среднее арифметическое элементов массива = {avg}");
}

void PrintArray(int[] array)
{

    foreach (int elem in array)
    {
        Console.Write($"{elem} ");
    }
    
}

void CheckArray(int[] array)
{
    string msg = "";
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] > array[i + 1])
        {
            msg = "Задача Г -> Числа в массиве расположены не по возрастанию.";
            Console.WriteLine($"{msg}");
            return;
        }
        else
        {
            msg = "Задача Г -> Числа в массиве расположены по возрастанию.";
        }

    }
    
    Console.WriteLine($"{msg}");
}

void Max(int[] array)
{
    double max = array[0];
    foreach (int elem in array)
    {
        if (max < elem)
        { max = elem; }
    }
    
    Console.WriteLine($"Задача Б -> Максимальное значение массива = {max}");
}
Console.WriteLine("_____________________________________________________________________________________");