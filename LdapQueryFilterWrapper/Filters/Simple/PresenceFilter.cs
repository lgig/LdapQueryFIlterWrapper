namespace LdapQueryFilterWrapper.Filters.Simple
{
    public class PresenceFilter : Filter
    {
        private string attributeName;

        public PresenceFilter(string attributeName)
        {
            this.attributeName = LdapInputSanitizer.Sanitize(attributeName);
        }

        public override string ToString()
        {
            return string.Format("({0}=*)", attributeName);
        }
    }
}
