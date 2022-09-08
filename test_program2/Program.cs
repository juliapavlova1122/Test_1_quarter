// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше или равна
// 3 символа. Первоначальный массив можно ввести с помощью клавиатуры,
// либо задать на старте выполнения алгоритма. 
// Примеры
// hello, 2, world, :-)  -> [2, :-)]
// 1234, 1567, -2, computer science -> [-2]
// Russia, Denmark, Kazan -> []


void PrintArray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        int size = array[i].Length; 
        if (size <= 3)      
        Console.WriteLine($"{array[i]}");
             
    }
    Console.WriteLine();
}

Console.WriteLine ("Enter the number of strings: ");
int a = int.Parse(Console.ReadLine());

string[] array = FillArray(a);
string[] FillArray (int count)
{
    string[] Array = new string[count];
    for (int i=0; i<count; i++)
    {
        Console.WriteLine ("Enter a string: ");
        Array[i] = Console.ReadLine();
    }
    return Array;
}

Console.WriteLine();
Console.WriteLine ("3 symbols array: ");
PrintArray(array);

