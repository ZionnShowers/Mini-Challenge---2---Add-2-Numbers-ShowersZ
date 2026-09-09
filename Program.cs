//Zionn Showers
//Mini Challenge # 2 - Add 2 Numbers
//I made the user input 2 numbers, with the program turning those numbers into strings. Afterwards, I made the program convert those two strings into integers so that they can successfully add together without showing the wrong number or any other errors.
//Peer Review: Chris Estrada
//Review: The code is clean and works and the flowchart is clear and easy to read. Good job!

Console.Clear();

Console.Write("Please input a number: ");
string num1 = Console.ReadLine();
Console.Write("Now input another number: ");
string num2 = Console.ReadLine();
int actualNum1 = Convert.ToInt32(num1);
int actualNum2 = Convert.ToInt32(num2);
Console.WriteLine($"Those numbers added together equal {actualNum1 + actualNum2}!");