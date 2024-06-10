# Shape drawer

This program draws 3 different shapes
- Triangle
- Square
- Hexagon

We use `try and catch` operation, `do while` operation and three methods

- `try catch`
    ```cs
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
- `do while`
    ```cs
    do
    {
    if(selectedShape == 1)      Triangle();
    else if(selectedShape == 2) Square();
    else if(selectedShape == 3) Hexagon();

    Console.Write("1->Triangle 2->Square 3->Hexagon\nChoose: ");
    selectedShape = Convert.ToInt16(Console.ReadLine());
    }
    while (selectedShape == 1 || selectedShape == 2 || selectedShape == 3);

- Triangle
![Triangle](https://github.com/Javohir0102/Drawer/blob/main/Asset/Triangle.png)

- Square
![Square](https://github.com/Javohir0102/Drawer/blob/main/Asset/Square.png)

- Hexagon
[Hexagon](https://github.com/Javohir0102/Drawer/blob/main/Asset/Hexagon.png)
