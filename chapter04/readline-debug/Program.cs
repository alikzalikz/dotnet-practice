Console.WriteLine("enter the price:");
decimal price=decimal.Parse(Console.ReadLine()!);
Console.WriteLine("enter the quantity:");
int quantity =int.Parse(Console.ReadLine()!);

static decimal TotalPrice(decimal price,int quantity)
{

    
   if(price<0 || quantity < 0)
    {
        
    
    throw new ArgumentException("just use positive number for price and quantity");
    }

    return price*quantity; 
    
    
}
try {
Console.WriteLine($"total: {TotalPrice(price,quantity)}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}