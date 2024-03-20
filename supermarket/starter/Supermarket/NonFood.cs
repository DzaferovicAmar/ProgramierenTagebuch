using System.Globalization;

namespace Supermarket;

public sealed class NonFood : Product
{
    private readonly List<Review> _reviews;

    public NonFood(string productName, string barcode, int quantity)
        : base(productName, barcode, quantity)
    {
        // TODO
        _reviews = null!;
        Console.WriteLine($"Remove me, I just make code compile {_reviews}");
    }

    // TODO
    public Review[] Reviews => null!;

    public double? AverageRating
    {
        get
        {
            // TODO
            return -1D;
        }
    }

    // TODO
    protected override string[] CsvColumnNames => null!;

    // TODO
    // hint: .ToString("F1", CultureInfo.InvariantCulture)
    protected override string[] CsvColumnValues => null!;
    
    public void AddReview(Review review)
    {
        // TODO
    }
}
