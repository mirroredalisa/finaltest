// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[] {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"};

int m = array.Length;

Console.Write("Исходный массив: ");

for (int i = 0; i < m; i++)
{
    Console.Write(array[i] + "  ");
}

Console.WriteLine(" ");
Console.Write("Новый массив: ");

for (int i = 0; i < m; i++)
{
    if (array[i].Length <= 3)
    {
        Console.Write(array[i] + "  ");
    }

}

