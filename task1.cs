//first homework

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
{
    Console.Write(num1);
}

else if (num1==num2)
{
    Console.Write ("числа равны");

}
else
{
    Console.Write(num2);
}

