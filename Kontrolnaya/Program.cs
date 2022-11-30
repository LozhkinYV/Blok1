//Ввод натуральных чисел
int InputLengthArray(string massege)
{
    while (true)
    {
        Console.WriteLine(massege);
        string value = Console.ReadLine();
        if (int.TryParse(value, out int resalt))
        {
            if (resalt > 0)
            {
                return resalt;
                break;
            }
            else
            {
                Console.WriteLine("Попробуйте еще раз ввести количество строк!");
            }
        }
        else
        {
            Console.WriteLine("Попробуйте еще раз ввести количество строк!");
        }
    }
}

//заполнение массива с клавиатуры
string[] FillArray(int leng, string[] array)
{
    for (int i = 0; i < leng; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

//Вывод массива
void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        Console.WriteLine($"\"{array[array.Length - 1]}\"]");
    }
    else
    {
        Console.Write("[]");
    }
}

//заполнение нового массива, длина ячеек которго меньше некоторого значения символов
string[] SmallThreeArray(string[] oldArray, int namber)
{
    int count = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= namber)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    count = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= namber)
        {
            newArray[count] = oldArray[i];
            count++;
        }
    }
    return newArray;
}

int n = InputLengthArray("Введите количество строк массива: ");
int a = 3; //значение меньше которого нужно вывести

string[] arrayString = new string[n];
Console.WriteLine("После введнного значения строки нажмите клавишу [Enter]");
FillArray(n, arrayString);
Console.Write("Вы ввели следующие значения строк: ");
PrintArray(arrayString);
Console.WriteLine($"Строки, длина которых меньше {a} символов");
PrintArray(SmallThreeArray(arrayString, a));


