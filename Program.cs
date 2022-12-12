//Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.Clear();

Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];
string[] array2 = new string[array.Length];

void CreateArray1(int n)
{
    for (int i = 0; i < n; i++)
        array[i] = Convert.ToString(Console.ReadLine());
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CreateArray1(n);
SecondArrayWithIF(array, array2);
Console.WriteLine();
PrintArray(array2);