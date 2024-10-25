public class Product
{
    public string Name { get; init; }
    public doublle Price { get; init; }
    public int StockQuantity { get; init; }
}




public record Product(
    string Name,
    double Price,
    int StockQuantity);


// Choose 𝗿𝗲𝗰𝗼𝗿𝗱𝘀 when:
// - You need immutable data types.
// - You want built-in value equality.
// - You’re creating simple DTO without behavior