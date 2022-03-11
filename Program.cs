int a;
for (var i = 0; i < 4; i++)
{
System.Console.WriteLine("wage");
a=Convert.ToInt32(Console.ReadLine());
if (a>2000000 && a<3000000)
{
    System.Console.WriteLine(a*0.05);
}

if (a>3000000)
{
    System.Console.WriteLine(a*0.07);
}

if (a<2000000)
{
    System.Console.WriteLine(a*0);
}

}
