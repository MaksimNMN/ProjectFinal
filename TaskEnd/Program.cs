// // ЗАДАЧА:
// //Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых либо меньше либо равна 3 символа. 

Console.WriteLine("Введите пожалуйста количество элементов ");
int size = System.Convert.ToInt32(System.Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string item = System.Convert.ToString(Console.ReadLine());
    arrayStrings[i] = item;
}

string[] arrayItem = new string[size];
int leng = 3;
int position = 0;

for (int e = 0; e < size; e++)
{
    if (arrayStrings[e].Length <= leng)
    {
        arrayItem[position] = arrayStrings[e];
        position++;
    }
}

Console.WriteLine();
PrintArray(arrayItem);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Элементы соответствующие требованиям массива [{array[i]}]");
    }

    Console.WriteLine();
}


