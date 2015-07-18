using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LdapQueryFilterWrapper.Filters.Simple.Comparison;
using LdapQueryFilterWrapper.Filters.Simple;

namespace LdapQueryFilterWrapper.Filters
{
    public class Attribute
    {
        public string Name { get; set; }

        public Attribute(string name)
        {
            Name = name;
        }

        public Filter IsDefined()
        {
            return new DefinitionFilter(Name);
        }

        public Filter Equals(string value)
        {
            return new EqualityFilter(Name, value);
        }

        public static Filter operator ==(Attribute parameter, string value)
        {
            return new EqualityFilter(parameter.Name, value);
        }

        public static Filter operator !=(Attribute parameter, string value)
        {
            return ! new EqualityFilter(parameter.Name, value);
        }

        public Filter IsLessThan(string value)
        {
            return new MinorityFilter(Name, value);
        }

        public static Filter operator <(Attribute parameter, string value)
        {
            return new MinorityFilter(parameter.Name, value);
        }

        public Filter IsLessThanOrEqual(string value)
        {
            return new MinorityOrEqualityFilter(Name, value);
        }

        public static Filter operator <=(Attribute parameter, string value)
        {
            return new MinorityOrEqualityFilter(parameter.Name, value);
        }

        public Filter IsGreaterThan(string value)
        {
            return new MajorityFilter(Name, value);
        }

        public static Filter operator >(Attribute parameter, string value)
        {
            return new MajorityFilter(parameter.Name, value);
        }

        public Filter IsGreaterThanOrEqual(string value)
        {
            return new MajorityOrEqualityFilter(Name, value);
        }

        public static Filter operator >=(Attribute parameter, string value)
        {
            return new MajorityOrEqualityFilter(parameter.Name, value);
        }

        public Filter Contains(string value)
        {
            return new ContainmentFilter(Name, value);
        }

        public Filter StartsWith(string value)
        {
            return new StartFilter(Name, value);
        }

        public Filter EndsWith(string value)
        {
            return new EndFilter(Name, value);
        }

        //TODO: Add the "Matches" method. (which enables pattern matching based on wildcards)
    }
}
