using LdapQueryFilterWrapper.Filters;
using LdapQueryFilterWrapper.Filters.Compound.MultiArgument;
using LdapQueryFilterWrapper.Filters.Compound.SingleArgument;
using LdapQueryFilterWrapper.Filters.Simple;
using LdapQueryFilterWrapper.Filters.Simple.Comparison;

namespace LdapQueryFilterWrapper
{
    public class Ldap
    {
        public static Filter And(params Filter[] filters)
        {
            return new AndFilter(filters);
        }

        public static Filter Or(params Filter[] filters)
        {
            return new OrFilter(filters);
        }

        public static Filter Not(Filter filter)
        {
            return new NotFilter(filter);
        }

        public static Filter Equals(string attributeName, string value)
        {
            return new EqualityFilter(attributeName, value);
        }

        public static Filter Contains(string attributeName, string value)
        {
            return new ContainmentFilter(attributeName, value);
        }

        public static Filter StartsWith(string attributeName, string value)
        {
            return new StartFilter(attributeName, value);
        }

        public static Filter EndsWith(string attributeName, string value)
        {
            return new EndFilter(attributeName, value);
        }

        public static Filter IsPresent(string attributeName)
        {
            return new PresenceFilter(attributeName);
        }
    }
}
