Console.Clear();

Console.Write("Please input a number: ");
string num1 = Console.ReadLine();
Console.Write("Now input another number: ");
string num2 = Console.ReadLine();
int actualNum1 = Convert.ToInt32(num1);
int actualNum2 = Convert.ToInt32(num2);
Console.WriteLine($"Those numbers added together equal {actualNum1 + actualNum2}!");