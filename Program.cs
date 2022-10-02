// Задача 29: Напишите программу,
// которая задаёт массив из 8 элементов и выводит их на экран.

Console.Write("Введите ряд чисел, разделенных запятой : ");
string? numbers = Console.ReadLine();
int B = numbers.Length;
int[] array = new int[B] ;
int i = 0;
while(i < B)
{
    if (numbers[i] == ',') {}
    else {
        while(i == ',')
        {
            int [] mas = nambers[i];
            i++;
        }
        x = mas
    }
    array[i] = Convert.ToInt32(numbers[i]);
    Console.Write(numbers[i]);
    i = i + 1;
}
