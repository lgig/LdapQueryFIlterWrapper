namespace LdapQueryFilterWrapper.Filters.Compound.SingleArgument
{
    public class NotFilter : Filter
    {
        private Filter filter;

        public NotFilter(Filter filter)
        {
            this.filter = filter;
        }

        public override string ToString()
        {
            return string.Format("(!{0})", filter.ToString());
        }
    }
}
