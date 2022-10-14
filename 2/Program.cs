Console.Write("Ведите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sqrNumber = number2 * number2;

if (sqrNumber == number1)
{
   Console.Write("ДА!");
}

if (sqrNumber != number1)
{
    Console.Write("НЕТ!");
}