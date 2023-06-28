//Задача34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

bool Check(int size)
{
    if (size < 1)
    {
        System.Console.WriteLine("Введите число больше нуля");
        return false;
    }
    return true;
}

int [] newArray(int size)
{
    int [] arr = new int [size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}

void Print (int [] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Resultat (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}
//----------------------------------------------------------
System.Console.WriteLine("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(System.Console.ReadLine());

if (Check(size))
{
    int [] array = newArray(size);
    Print(array);
    int result = Resultat(array);
    System.Console.WriteLine($"Количество четных чисел в массиве -> {result}");
}



//Задача36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

bool Check(int size)
{
    if (size < 1)
    {
        System.Console.WriteLine("Введите число больше нуля");
        return false;
    }
    return true;
}


int [] newArray(int size)
{
    int [] arr = new int [size];
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-100, 100);
    }
    return arr;
}

void Print (int [] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int Resultat (int [] array)
{
    int summa = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summa += array[i];
    }
    return summa;
}

//----------------------------------------------

System.Console.WriteLine("Введите количество элементов в массиве: ");
int size = Convert.ToInt32(System.Console.ReadLine());

if (Check(size))
{
    int [] array = newArray(size);
    Print(array);
    int result = Resultat(array);
    System.Console.WriteLine($"Сумма элементов массива с нечетными порядковыми номерами -> {result}");
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double [] FillArray (int size)
{
    Random rand = new Random();
    double [] array = new double [size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.NextDouble() + rand.Next(0,101), 2);
    }
    return array;
}

void PrintArray(double [] arr)
{
    System.Console.WriteLine("[" + string.Join("; ", arr) + "]");
}

void PrintResult(double [] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    double resultat = Math.Round(max - min, 2);
    System.Console.WriteLine(" ");
    System.Console.WriteLine("Максимальное значение массива: " + max);
    System.Console.WriteLine("Минимальное значение массива: " + min);
    System.Console.WriteLine("Разница между максимальным и минимальным значениями массива: " + resultat);
}

bool Check(int size)
{
    if (size < 1)
    {
        System.Console.WriteLine("Введите число больше нуля");
        return false;
    }
    return true;
}

//-----------------------------------------------------
System.Console.WriteLine("Укажите количество элементов в массиве: ");
int size = Convert.ToInt32(System.Console.ReadLine());

if (Check(size))
{
    double [] arr = FillArray(size);
    PrintArray(arr);
    PrintResult(arr);
}
