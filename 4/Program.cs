
Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int number2 = number1 * -1;

if (number2 < number1)
{
    while (number2 <= number1)
    {
    Console.WriteLine(number2);
    number2++;
    }
}

else
{
    while (number1 <= number2)
    {
    Console.WriteLine(number1);
    number1++;
    }
}