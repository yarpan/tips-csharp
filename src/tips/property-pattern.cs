

if (product != null &&
    product.Category == "Books" &&
    product.Price > 100)
{
    Console.WriteLine("Offer Free Shipping");
}


// Property Pattern
if (product is { Category: "Books", Price: > 100 })
{
    Console.WriteLine("Offer Free Shipping");
}