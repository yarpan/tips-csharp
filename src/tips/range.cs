
if (score >= 60 && score <= 100)
{
    Console.WriteLine("Data in the expected range");
}


//Relational Pattern
if (score is >= 60 and <= 100)
{
    Console.WriteLine("Data in the expected range");
}



//Take with range

List<int> numbers = GetNumbers();
var result = numbers.Skip(6).Take(4);

List<int> numbers = GetNumbers();
var result = numbers.Take(6..10);