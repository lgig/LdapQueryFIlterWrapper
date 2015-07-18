using LdapQueryFilterWrapper.Filters.Compound.MultiArgument;
using LdapQueryFilterWrapper.Filters.Compound.SingleArgument;

namespace LdapQueryFilterWrapper.Filters
{
    public abstract class Filter {
        public static Filter operator &(Filter leftHandFilter, Filter rightHandFilter)
        {
            return new AndFilter(leftHandFilter, rightHandFilter);
        }

        public static Filter operator |(Filter leftHandFilter, Filter rightHandFilter)
        {
            return new OrFilter(leftHandFilter, rightHandFilter);
        }

        public static Filter operator !(Filter filter)
        {
            return new NotFilter(filter);
        }

        //TODO: Add the method "ToIndentedString"
    }
}
