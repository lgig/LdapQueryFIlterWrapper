namespace LdapQueryFilterWrapper.Filters.Simple.Comparison
{
    public class ComparisonFilter : Filter
    {
        protected string attributeName, value;

        protected ComparisonFilter(string attributeName, string value) {
            this.attributeName = LdapInputSanitizer.Sanitize(attributeName);
            this.value = LdapInputSanitizer.Sanitize(value);
        }
    }
}
