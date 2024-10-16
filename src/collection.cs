//using Any and Exist in collections

public bool ContainsPositive(List<int> numbers)
{
    return numbers.Any(x => x > 0);
}


public bool ContainsPositive(List<int> numbers)
{
    return numbers.Exists(x => x > 0); // Faster
}