namespace LdapQueryFilterWrapper.Filters.Simple.Comparison
{
    public class EqualityFilter : ComparisonFilter
    {
        public EqualityFilter(string attributeName, string value) : base(attributeName, value) { }

        public override string ToString()
        {
            return string.Format(
                "({0}={1})"
                , attributeName
                , value);
        }
    }
}
