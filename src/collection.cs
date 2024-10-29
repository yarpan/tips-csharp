//using Any and Exist in collections

public bool ContainsPositive(List<int> numbers)
{
    return numbers.Any(x => x > 0);
}


public bool ContainsPositive(List<int> numbers)
{
    return numbers.Exists(x => x > 0); // Faster
}


//CountBy
// .NET 8
var categoryCounts = products
    .GroupBy(p => p.Category)
    .Select(group => new
    {
        Category = group.Key,
        Count = group.Count()
    });

// .NET 9
var categoryCounts = products
    .CountBy(p => p.Category);


//MinBy and MaxBy
// .NET 5
var cheapest = cars.OrderBy(categoryCounts => categoryCounts.Price).First();
var priciest = cars.OrderByDescending(c => c.Price).First();

// .NET 6
var cheapest - cars.MinBy(c=>c.Price);
var priciest - cars.MaxBy(c=>c.Price);
