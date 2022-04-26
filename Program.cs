// Задача 1
/*
Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 1;
while (count != b)
{
    result *= a;
    count++;
}
Console.WriteLine(result);
*/
// Задача 2
/*
Console.Write("Input Your number: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (num / 10 != 0)
{
    result += num % 10;
    num /= 10;
}
result += num;
Console.WriteLine(result);
*/

// Задача 3

int[] array = new int[8];
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 150);
}
for (int j = 0; j < array.Length - 1; j++)
{
    Console.Write(array[j] + ", ");
}
Console.WriteLine(array[7] + "]");
