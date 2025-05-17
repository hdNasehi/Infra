namespace Hesabo.Foundation.Guards;
public static class Guard
{
    public static void AgainstNull(object? input, string name)
    {
        if (input is null)
            throw new ArgumentNullException(name);
    }

    public static void AgainstNegative(decimal number, string name)
    {
        if (number < 0)
            throw new ArgumentOutOfRangeException(name, "Value cannot be negative.");
    }

    public static void AgainstEmpty(Guid guid, string name)
    {
        if (guid == Guid.Empty)
            throw new ArgumentException("GUID cannot be empty.", name);
    }
}
