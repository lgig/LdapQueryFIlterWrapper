using System.Text;

namespace LdapQueryFilterWrapper.Filters.Compound.MultiArgument
{
    public class AndFilter : MultiArgumentOperatorFilter
    {
        public AndFilter(params Filter[] filters)
            : base("&", filters)
        { }

        public override string ToString()
        {
            if (filters.Length == 0)
                return string.Empty;

            if (filters.Length == 1)
                return filters[0].ToString();

            return GenerateMultipleFiltersString(filters);
        }
    }
}
