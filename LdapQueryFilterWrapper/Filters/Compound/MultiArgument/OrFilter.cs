namespace LdapQueryFilterWrapper.Filters.Compound.MultiArgument
{
    public class OrFilter : MultiArgumentOperatorFilter
    {
        public OrFilter(params Filter[] filters)
            : base("|", filters)
        { }
    }
}
