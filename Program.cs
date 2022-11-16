void PrintArray(string[] array) // вывод массива в консоль
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}
int CountStringLessThreeChar(string[] array) // считаем строки, 3 символа и меньше.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}
string[] arrayFirst =  {"hello", "2", "world", ":-)"};
int countFirst = CountStringLessThreeChar(arrayFirst);
string[] resultFirst =  FillResultArray(arrayFirst,countFirst);
PrintArray(resultFirst);

string[] arraySecond = {"1234", "1567", "-2", "computer science"};
int countSecond  = CountStringLessThreeChar(arraySecond);
string[] resultSecond = FillResultArray(arraySecond,countSecond);
PrintArray(resultSecond);

string[] arrayThird = {"Russia", "Denmark", "Kazan"};
int countThird = CountStringLessThreeChar(arrayThird);
string[] resultThird = FillResultArray(arrayThird, countThird);
PrintArray(resultThird);