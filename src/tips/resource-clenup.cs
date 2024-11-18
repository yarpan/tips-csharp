
// Option 1
StreamReader reader = null;
try
{
    reader = new StreamReader("file.txt");
    content = await reader.ReadToEndAsync();
}
finally
{
    reader?.Dispose();
}


// Option 2
using (var reader = new StreamReader("file.txt"))
{
    content = await reader.ReadToEndAsync();
}


// Option 3
using var reader = new StreamReader("file.txt");
content = await reader.ReadToEndAsync();