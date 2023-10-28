using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

var number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

string[] digits = { "0 = ", "1 = ", "2 = ", "3 = ", "4 = ", "5 = ", "6 = ", "7 = ", "8 = ", "9 = " };

var counter0 = 0;
var counter1 = 0;
var counter2 = 0;
var counter3 = 0;
var counter4 = 0;
var counter5 = 0;
var counter6 = 0;
var counter7 = 0;
var counter8 = 0;
var counter9 = 0;

foreach (char letter in letters)
    if (letter == '0')
    {
        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }

Console.WriteLine(digits[0] + counter0++);
Console.WriteLine(digits[1] + counter1++);
Console.WriteLine(digits[2] + counter2++);
Console.WriteLine(digits[3] + counter3++);
Console.WriteLine(digits[4] + counter4++);
Console.WriteLine(digits[5] + counter5++);
Console.WriteLine(digits[6] + counter6++);
Console.WriteLine(digits[7] + counter7++);
Console.WriteLine(digits[8] + counter8++);
Console.WriteLine(digits[9] + counter9++);


      
