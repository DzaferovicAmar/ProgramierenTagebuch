namespace Supermarket;

public sealed class Food : Product
{
    private const char AllergenSeparator = '|';
    private readonly SortedSet<AllergenType> _allergens;

    public Food(string productName, string barcode, int quantity, params AllergenType[] allergens)
        : base(productName, barcode, quantity)
    {
        // TODO
        _allergens = null!;
        Console.WriteLine($"Remove me, I just make code compile {_allergens}");
    }

    // TODO
    public AllergenType[] Allergens => null!;

    // TODO
    protected override string[] CsvColumnNames => null!;

    protected override string[] CsvColumnValues
    {
        get
        {
            // TODO
            return null!;
        }
    }

    // TODO
    public bool AddAllergen(AllergenType allergen) => false;

    // TODO
    public bool RemoveAllergen(AllergenType allergen) => false;

    public bool ContainsAnyAllergen(params AllergenType[] allergens)
    {
        // TODO
        return false;
    }
}
