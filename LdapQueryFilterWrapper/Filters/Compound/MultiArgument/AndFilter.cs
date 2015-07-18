using System.Text;

namespace LdapQueryFilterWrapper.Filters.Compound.MultiArgument
{
    public class AndFilter : MultiArgumentOperatorFilter
    {
        public AndFilter(params Filter[] filters)
            : base("&", filters)
        { }
    }
}
