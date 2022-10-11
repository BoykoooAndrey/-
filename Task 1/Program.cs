// Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше или равна 3 символам.
int Promt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(System.Console.ReadLine());
}
string Promt2(string message)
{
    System.Console.Write(message);
    return System.Console.ReadLine();
}
string[] Complection(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt2($"Введите слово {i + 1}:");
    }
    return array;
}
string[] Filter(string[] array)
{
    int sizeNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            sizeNewArray++;
        }
    }
    string[] filteredArray = new string[sizeNewArray];
    for (int i = 0; i < filteredArray.Length;)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[j].Length < 4)
            {
                filteredArray[i] = array[j];
                i++;
            }
        }
    }
    return filteredArray;
}
void Print(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            System.Console.Write($"{array[i]}");
        }
        if (i < array.Length - 1)
        {
            System.Console.Write($"{array[i]},");
        }
    }
}
int size = Promt("Введите количество слов:");
string[] words = new string[size];
string[] wordsComplect = Complection(words);
Print(wordsComplect);
string[] wordsFiltered = Filter(wordsComplect);
System.Console.Write(" -> ");
Print(wordsFiltered);
