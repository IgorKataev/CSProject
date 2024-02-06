// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// a = 256 => 26
// b = 891 => 81

int number = 453;
int firstDigit = number / 100;
int thirdGigit = number % 10;
int result = firstDigit * 10 + thirdGigit;
Console.WriteLine($"В числе {number} => {result}");
