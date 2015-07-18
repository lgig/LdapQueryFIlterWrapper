using LdapQueryFilterWrapper.Filters;
using LdapQueryFilterWrapper.Filters.Compound.MultiArgument;
using LdapQueryFilterWrapper.Filters.Compound.SingleArgument;
using LdapQueryFilterWrapper.Filters.Simple;
using LdapQueryFilterWrapper.Filters.Simple.Comparison;

namespace LdapQueryFilterWrapper
{
    public class Ldap
    {
        public static Attribute Attribute(string name)
        {
            return new Attribute(name);
        }
    }
}
