static decimal CalculateDiscount(decimal x , string type)
{
    decimal discount;
    if (type == "VIP" || type=="vip")
    {
         discount=x *0.2m;
        Console.WriteLine( $"discount :{discount}");
    }
    else
    {
        discount=x *0.05m;
        Console.WriteLine($"discount :{discount}");
    }

    return discount;
}
Console.Write("Enter price:");
decimal price=decimal.Parse(Console.ReadLine()!);
Console.Write("VIP or normal?");
string type=Console.ReadLine()!;
decimal discount= CalculateDiscount(price,type);