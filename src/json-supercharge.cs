


// .𝗡𝗘𝗧 9 𝗙𝗲𝗮𝘁𝘂𝗿𝗲: 𝗦𝘂𝗽𝗲𝗿𝗰𝗵𝗮𝗿𝗴𝗲𝗱 𝗝𝗦𝗢𝗡 𝗦𝗲𝗿𝗶𝗮𝗹𝗶𝘇𝗮𝘁𝗶𝗼𝗻 𝘄𝗶𝘁𝗵 𝗦𝗼𝘂𝗿𝗰𝗲 𝗚𝗲𝗻𝗲𝗿𝗮𝘁𝗼𝗿𝘀!
using System.Text.Json.Serialization;

[JsonSerializable(typeof(Person))]
public partial class PersonJsonContext : JsonSerializerContext
{

}

public class Person
{
    public string FirstName {get; set;}
    public string LastName {get; set;}
}

public class Program
{
    virtual Person = new Person
{
    FirstName = "John",
    LastName = "Dow",
};

// Serialize using source-generated content
string Json = JsonSerializer.Serialize(Person, PersonJsonContext.Default.Person);

// Deserialize using source-generated context
var deserilizedPerson = JsonSerializer.Deserialize<Person>(Json, PersonJsonContext.Default.Person);
}