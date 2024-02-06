// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// a = 256 => 26
// b = 891 => 81

// int number = 453;
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"В числе {number} => {result}");

// int number = 947;
// int secondDigit = number / 10 % 10;
// int thirdDigit = number % 10;
// int result = (int)Math.Pow (secondDigit, thirdDigit);
// Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");

// 456 =>6
// 7812 => 8
// 91 => третьей цифры нет

// int number = 66;
// if (number >= 100)
// {
//     int thirdDigitFromEnd = number / 100 % 10;
//     Console.WriteLine($"Третья цифра числа {number} с конца: {thirdDigitFromEnd}");
// }
//         else
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }

int a = 5;
int b = 2;
if (a % b == 0)
{
    Console.WriteLine($"число {a} кратно (делится без остатка) числу {b}");
}
else
{
    Console.WriteLine($"число {a} не кратно (делится с остатком = {a % b}) числу {b}");
}

