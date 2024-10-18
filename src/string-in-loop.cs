

string result = string.Empty;
foreach (var str in arrayOfStrings)
{
    result += str;
}


StringBuilder builder = new StringBuilder();
foreach(var str in arrayOfStrings)
{
    builder.Append(str);
}
string result = builder.ToString(); // Faster