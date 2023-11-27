// Задача: 
// Написать программу, которая 
// 1/ из имеющегося массива строк формирует новый массив из строк, 
// 2/ длина которых меньше, либо равна 3 символам. 
// 3/ Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.



void Main()
{
    Console.WriteLine("Введите количество элементов массива");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n <= 0) Console.WriteLine("Попробуйте еще раз");
    else 
    {
    string[] array = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент");
        array[i] = Console.ReadLine();
    }
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i == array.Length - 1) Console.Write($"“{array[i]}”");
        else Console.Write($"“{array[i]}”, ");
    }
    Console.Write("]");

    int numOfElem = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i].Length <= 3) numOfElem++;
    }

    string[] newArray = new string[numOfElem];

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    
    Console.WriteLine("->");
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        if(i == newArray.Length - 1) Console.Write($"“{newArray[i]}”");
        else Console.Write($"“{newArray[i]}”, ");
    }
    Console.Write("]");
    }

}

Main();