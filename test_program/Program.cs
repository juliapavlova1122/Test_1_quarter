// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше или равна
// 3 символа. Первоначальный массив можно ввести с помощью клавиатуры,
// либо задать на старте выполнения алгоритма. 
// Примеры
// hello, 2, world, :-)  -> [2, :-)]
// 1234, 1567, -2, computer science -> [-2]
// Russia, Denmark, Kazan -> []

string[] array = {"hello", "2", "world", ":-)"};
// string[] array = {"1234", "1567", "-2", "computer science"};
// string[] array = {"Russia", "Denmark", "Kazan"};

void PrintArray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        for (int size = array[i].Length; size <=3;)        
        {
        Console.Write($"{array[i]}");
        Console.WriteLine();
        break;
        }
    }
}
PrintArray(array);

