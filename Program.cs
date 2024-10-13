//1
Console.WriteLine("sheiyvanet pirveli ricxvi: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("sheiyvanet meore ricxvi: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("sheiyvanet moqmedeba risi gaketebac gsurt: ");
string operacia = Console.ReadLine();

if (operacia == "+")
{
    double jami = num1 + num2;
    Console.WriteLine(num1 + " + " + num2 + " = " + jami);
}
else if (operacia == "-")
{
    double sxvaoba = num1 - num2;
    Console.WriteLine(num1 + " - " + num2 + " = " + sxvaoba);
}
else if (operacia == "*")
{
    double namravli = num1 * num2;
    Console.WriteLine(num1 + " * " + num2 + " = " + namravli);
}
else if (operacia == "/")
{
    if (num1 == 0)
    {
        Console.WriteLine("ar sheidzleba");
    }
    else
    {
        double gayofa = num1 / num2;
        Console.WriteLine(num1 + " / " + num2 + " = " + gayofa);
    }
}
else if (operacia == "%")
{
    double nashti = num1 % num2;
    Console.WriteLine(num1 + " % " + num2 + " = " + nashti);
}
else
{
    Console.WriteLine("araswori operetaoria");
}

//2

Console.WriteLine("sheiyvanet ricxvi #1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("sheiyvanet ricxvi #2: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("sheiyvanet ricxvi #3: ");
int c = Convert.ToInt32(Console.ReadLine());


if (c > b && a < c)
{
    Console.WriteLine(c + "aris yvelaze didi");
}
else if (b > c && b > a)
{
    Console.WriteLine(b + "aris yvelaze didi");
}
else if (a > b && a > c)
{
    Console.WriteLine(a + "aris yvelaze didi");
}
else
{
    Console.WriteLine("tolia");
}
//3
Console.WriteLine("sheiyvanet samkutxedis gverdi #1: ");
int gverdi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("sheiyvanet samkutxedis gverdi #2: ");
int gverdi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("sheiyvanet samkutxedis gverdi #3: ");
int gverdi3 = Convert.ToInt32(Console.ReadLine());

if (gverdi + gverdi2 < gverdi3 || gverdi + gverdi3 < gverdi2 || gverdi2 + gverdi3 < gverdi)
{
    Console.WriteLine("araa validuri");
}
else
{
    Console.WriteLine("validuria");
}