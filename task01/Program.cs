// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых <=3 символов

string[] array = new string[4] { "hello", "2", "world", ";-)" };
string[] newarray = new string[array.Length];
void ResultArry(string[] array, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
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
ResultArry(array, newarray);
PrintArray(newarray);
