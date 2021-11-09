namespace BlazorToasterDemo.Extensions
{
    public static class StringExtensions
    {
        // Extension method to convert a string to Title Case
        public static string ToTitleCase(this string str)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }        
    }
}

