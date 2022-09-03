Console.WriteLine("введите целые числа ");
string numbers = Console.ReadLine();
string[] Numb = numbers.Split(",");
int[] convertarray = new int[Numb.Length];

for (int i = 0; i < Numb.Length; i++)
{
    convertarray[i] = int.Parse(Numb[i]);
}

int PositiveNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}
PositiveNumb(convertarray);
Console.WriteLine($"количество введенных чисел больше 0 равно {PositiveNumb(convertarray)}");





