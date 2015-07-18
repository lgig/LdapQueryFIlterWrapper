using System.Text;

namespace LdapQueryFilterWrapper.Filters.Compound.MultiArgument
{
    public class MultiArgumentOperatorFilter : Filter
    {
        protected readonly string operatorToken;
        protected Filter[] filters;

        protected MultiArgumentOperatorFilter(string operatorToken, params Filter[] filters)
        {
            this.operatorToken = operatorToken;
            this.filters = filters;
        }

        public string GenerateMultipleFiltersString(Filter[] filters)
        {
            var argumentsStringBuilder = new StringBuilder();

            foreach (var filter in filters)
                argumentsStringBuilder.Append(filter.ToString());

            return string.Format(
                "({0}{1})"
                , operatorToken
                , argumentsStringBuilder.ToString());
        }

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
