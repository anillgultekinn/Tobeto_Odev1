﻿
using System.Runtime.CompilerServices;
static void ForLoop()
{
    for (int i = 0; i <= 100; i += 2)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
}
//ForLoop();

static void WhileLoop()
{
    int number = 100;
    while (number >= 0)
    {
        Console.WriteLine(number);
        number--;
    }
    Console.WriteLine("Now number is {0}", number);
}
//WhileLoop();


int number = 10;
do
{
    Console.WriteLine(number);
    number--;
} while (number >= 11);