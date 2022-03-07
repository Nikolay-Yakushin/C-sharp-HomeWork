/*
// проба
Console.WriteLine("Введите целое число");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value * value;
Console.Write("Квадрат числа равен ");
Console.WriteLine(kvadrat_value);
*/

/*
Console.WriteLine("Введите первое целое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_number2 = number2 * number2;

if (number1 == kvadrat_number2)
{
    Console.Write("Ура, первое число это квадрат второго");
}
    
else 
{
    Console.Write("Введи числа еще раз");
}
*/

// задача 3

Console.WriteLine("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n*(-1);

while (neg_n <=n)
{
    Console.Write(neg_n + " ");
    neg_n+=3;
}
