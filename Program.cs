﻿Console.Write("\nIsmingizni kiriting : ");
string ism =Console.ReadLine();
Console.WriteLine($"\nAssalomu aleykum!\n\nXush kelibsiz {ism}\n");
Console.Write($"{ism} tug'ulgan yilingizni kiriting : ");
int tyil=Convert.ToInt32(Console.ReadLine());
int yosh = 2023 - tyil;
Console.WriteLine($"\nHurmatli {ism} yoshingiz {yosh} da!");
string info=$"\n{ism} siz Kescha nomli qush borligini bilasizmi!\n";
Console.WriteLine($"{info}\nKescha va sizning yoshingiz farqini natijada ko'ring!\n");
int k_age = 3;
int Age=yosh-k_age;
int aGE=k_age-yosh;


if (yosh > k_age)
{
        Console.WriteLine($"{ism} ning yoshi Kescha yoshidan {Age} yoshga katta!\n");
}
else
{
        Console.WriteLine($"{ism} ning yoshi Kescha yoshidan {aGE} yoshga kichik!\n");
}