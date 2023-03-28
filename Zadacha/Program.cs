System.Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] Text = new string[size];
for (int i = 0; i < size; i++)
{
    System.Console.WriteLine($"Введите {i + 1}-й элемент: ");
    string a = Convert.ToString(Console.ReadLine());
    Text[i] = a;
}

string[] Result = new string[size];
int length = 3;
int count = 0;

for (int j = 0; j < size; j++)
{
    if (Text[j].Length <= length)
    {
        Result[count] = Text[j];
        count++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
PrintArray(Result);