using System;

Console.WriteLine("============ choose geometric form ==============");
Console.WriteLine("1 - Triangle ");
Console.WriteLine("2 - Square");
Console.WriteLine("3 - Hexagon");
Console.WriteLine("=================================================");

string inputChoice = Console.ReadLine();
int selectedShape = 0;
try
{
    selectedShape = Convert.ToInt16(inputChoice);    
}
catch (FormatException)
{
    Console.WriteLine("format xato kiritilgan");
}
catch (Exception)
{
    Console.WriteLine("Faqat 1, 2, 3 qiymatni kiriting!");
}

do
{
    if(selectedShape == 1)      Triangle();
    else if(selectedShape == 2) Square();
    else if(selectedShape == 3) Hexagon();

    Console.Write("1->Triangle 2->Square 3->Hexagon\nChoose: ");
    selectedShape = Convert.ToInt16(Console.ReadLine());

} while (selectedShape == 1 || selectedShape == 2 || selectedShape == 3);

void Triangle()
{
    for(int i = 1; i <= 5; i++)
    {
        for(int j = i; j < 5; j++)
        {
            Console.Write(" ");
        }
        for(int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        for(int j = 1; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

void Square()
{
    for(int i = 1; i <= 5; i++)
    {
        for(int j = 1; j <= 5; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

void Hexagon()
{
    for(int i = 1; i <= 5; i++)
    {
        for(int j = i; j < 5; j++)
        {
            Console.Write(" ");
        }
        for(int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        for(int j = 1; j < 5; j++)
        {
            Console.Write("*");
        }
        for(int j = 1; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    for(int i = 1; i < 5; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            Console.Write(" ");
        }
        for(int j = i; j < 5; j++)
        {
            Console.Write("*");
        }
        for(int j = 1; j < 5; j++)
        {
            Console.Write("*");
        }
        for(int j = i; j < 4; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
