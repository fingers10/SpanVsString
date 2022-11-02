// See https://aka.ms/new-console-template for more information

public class StringParser
{
    public string GetFirstName(string fullName)
    {
        return fullName.Split(" ")[0] ?? string.Empty;
    }

    public string GetFirstNameUsingSubstring(string fullName)
    {
        var lastSpaceIndex = fullName.LastIndexOf(" ", StringComparison.Ordinal);

        return lastSpaceIndex == -1
            ? string.Empty
            : fullName.Substring(0, lastSpaceIndex);
    }

    public ReadOnlySpan<char> GetFirstNameWithSpan(ReadOnlySpan<char> fullName)
    {
        var lastSpaceIndex = fullName.LastIndexOf(' ');

        return lastSpaceIndex == -1
            ? ReadOnlySpan<char>.Empty
            : fullName.Slice(0, lastSpaceIndex);
    }
}