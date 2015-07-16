namespace LdapQueryFilterWrapper.Filters.Simple
{
    public class LdapInputSanitizer
    {
        public static string Sanitize(string input)
        {
            input.Replace("(", "\\28");
            input.Replace(")", "\\29");
            input.Replace("&", "\\26");
            input.Replace("=", "\\3d");
            input.Replace(">", "\\3e");
            input.Replace("<", "\\3c");
            input.Replace("~", "\\7e");
            input.Replace("*", "\\2a");
            input.Replace("/", "\\2f");
            input.Replace("\\", "\\5c");
            return input;
        }
    }
}
