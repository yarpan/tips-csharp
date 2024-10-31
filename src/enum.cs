
// convert an enum to a string

// classic one, slow
public string GetGreenName()
{
    return Colors.Green.ToString();
}

// fast
public string GetGreenName()
{
    return nameof(Colors.Green);
}