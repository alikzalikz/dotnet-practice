static decimal CalculateTax(decimal x,string countrycode)
{ 
    decimal tax;
    
    switch (countrycode)
    {
        case "FR" :
       tax=x*0.20m;

        break;

        case "US" :
         tax=x*0.08m;

        break;

        case "IR" :
         tax=x*0.09m;

        break;

        default :
        tax=x*0.05m;

        break;
            
    }
    Console.WriteLine($"tax of this country is :{tax}");
    return tax;
   
}
Console.Write("enter the price:");
decimal price=decimal.Parse(Console.ReadLine()!);
Console.Write("enter your country:");
string country =Console.ReadLine()!;
decimal tax= CalculateTax(price,country);