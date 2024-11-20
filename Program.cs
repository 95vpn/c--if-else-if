// See https://aka.ms/new-console-template for more information

Random random = new Random();
int daysUntilExpirations = random.Next(12);
int discountPercentage = 0;

Console.WriteLine(daysUntilExpirations);

if (daysUntilExpirations == 0) {
    Console.WriteLine("Your subscription ha expirado");
}
else if (daysUntilExpirations == 1) 
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if ( daysUntilExpirations <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpirations}");
    discountPercentage = 10;
}
else if (daysUntilExpirations <= 10) 
{
    Console.WriteLine("Your subscription expires soon. Renew now");
}

if(discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%");
}



    
    
    
    
    
    
    
    
    



