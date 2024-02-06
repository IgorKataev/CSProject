// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// a = 256 => 26
// b = 891 => 81

// int number = 453;
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"В числе {number} => {result}");

int number = 947;
int secondDigit = number / 10 % 10;
int thirdDigit = number % 10;
int result = (int)Math.Pow (secondDigit, thirdDigit);
// int result = Math.Pow (secondDigit, thirdDigit);
Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");
