int date;
System.Console.WriteLine("give me the month");
date=Convert.ToInt32(Console.ReadLine());


switch (date)
{
    case 1:
    System.Console.WriteLine("Janury");
        break;
    case 2:
    System.Console.WriteLine("February");
    break;
    case 3:
    System.Console.WriteLine("March");
    break;
    case 4:
    System.Console.WriteLine("April");
    break;
    default:
    System.Console.WriteLine("nadarim oskol");
        break;
}
