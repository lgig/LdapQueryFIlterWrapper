# LdapQueryFIlterWrapper
A simple .NET library for building LDAP query filter expressions taking advantage of compile-time syntax checking, intellisense autocompletion, and pre-implemented input encoding.

# Scenario
You find yourself working at a project that performs LDAP queries which have filters defined in the following way:
```C#
String.Format(
  "(&(|(&(name={0})(surname={1}))((email=*{3})))(age>={4}))"
  , "John"
  , "Doe"
  , "@company.com"
  , 18);
```
you need to edit several of those and you wish you:
- got compile-time syntax checking, so that you don't need to run the program to find out that you forgot a parenthesis;
- got intelli-sense suggesting you which type of filters are available without having to check LDAP query filters syntax definition every now and then;
- got input validation, so that your filter arguments get properly escaped if need be;

So you write yourself a small library wrapping those expressions and exposing an API such as the following:
```C#
((Ldap.Attribute("name").Equals("John") & Ldap.Attribute("surname").Equals("Doe"))
  | Ldap.Attribute("email").EndsWith("@company.com")) 
& Ldap.Attribute("age").IsGreaterThanOrEqualTo("18")
```

then it occurs to you that you could override some more operators and obtain an API such as the following:
```C#
((Ldap.Attribute("name") == "John" & Ldap.Attribute("surname") == "Doe")
  | Ldap.Attribute("email").EndsWith("@company.com")) 
& Ldap.Attribute("age") >= "18"
```

then you think someone else might find it useful, and upload it on GitHub.
