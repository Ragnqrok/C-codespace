//WorkingWithInts();
//OrderPrecedence();
//Limits();
//doubles();
//decimals();

void WorkingWithInts()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    //Subtraction
    c = a -b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division

    c = a / b;
    Console.WriteLine(c);
}

void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);


    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 * 12;
    Console.WriteLine(d);


    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
}

void Limits()
{
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"Quotient: {d}");
    Console.WriteLine($"Remainder: {e}");

    int max = int.MaxValue;
    int min = int.MinValue;
    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
    Console.WriteLine($"The range of integers is {min} to {max}");
}

void doubles()
{
    double a = 19;
    double b = 23;
    double c = 8; 
    double d = ( a + b) / c;
    Console.WriteLine(d);

    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range pf double is {min} to {max}");

    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}

void decimals()
{
    Decimal min = Decimal.MinValue;
    Decimal max = Decimal.MaxValue;
    Console.WriteLine($"The range for decimals is {min} to {max}");

    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a/b);

    Decimal c = 1.0m;
    Decimal d = 3.0m;
    Console.WriteLine(c/d);
}
