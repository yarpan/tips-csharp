
// common variant
public bool AreStringsEqual(string first, string second)
{
    return first.ToUpper() == second.ToUpper();
}


// fast variant
public bool AreStringsEqual(string first, string second)
{
    return string.Equals(first, second, StringComparison.OrdinalIgnoreCase);
}
