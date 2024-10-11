
// ways to check strings

if (text.StartsWith('C') && text.EndsWith('A'))
{
    Console.WriteLine("starts with C, ends with A");
}


if (text[0] == 'C' && text[^1] == 'A')
{
    Console.WriteLine("starts with C, ends with A");
}


if (text is ['C', .., 'A'])
{
    Console.WriteLine("starts with C, ends with A");
}