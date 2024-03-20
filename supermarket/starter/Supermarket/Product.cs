namespace Supermarket;

public abstract class Product
{
    public const char Separator = ';';
    
    public const string Invalid = "Invalid!";

    protected Product(string productName, string barcode, int quantity)
    {
        // TODO
        ProductName = null!;
        Barcode = null!;
    }

    public string ProductName { get; }

    public string Barcode { get; }

    public int Quantity { get; }

    // TODO
    protected virtual string[] CsvColumnNames => null!;

    // TODO
    protected virtual string[] CsvColumnValues => null!;

    // TODO
    public string GetCsvHeader() => null!;

    // TODO
    public string ToCsv() => null!;

    // TODO
    protected static string ToCsvLine(string[] values, char separator) => null!;

    public static bool IsBarcodeValid(string? barcode)
    {
        // TODO
        return false;
    }

    protected static T[] AppendToArray<T>(T[] existingArray, params T[] newValues)
    {
        // TODO
        return null!;
    }
}
