Console.WriteLine("Первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Действие:");
string? action = Console.ReadLine();
Console.WriteLine("Второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int result;
if (action == "+")
{
    result = num1 + num2;
    Console.WriteLine(result);
}
else if (action == "*")
{
    result = num1 * num2;
    Console.WriteLine(result);
}
