# LdapQueryFIlterWrapper
A simple .NET library for building LDAP query filter expressions taking advantage of C# compile-time syntax checking, Visual Studio's Intellisense autocompletion, and built-in input encoding.

# Scenario
You find yourself working at a project that performs LDAP queries and need to work with query filter expressions defined this way:
```C#
String.Format(
  "(&(|(&(name={0})(surname={1}))((email=*{3})))(age>={4}))"
  , "John"
  , "Doe"
  , "@company.com"
  , 18);
```
you're not much fond of their LISP-styled syntax, and while wrestling with them you wish:
- you didn't have to constantly match arguments and parameters inside String.Format invocation;
- there was compile-time syntax checking, so that you wouldn't need to run the program to find out that you forgot a parenthesis;
- Visual Studio would help you highlighting matching parenthesis when your cursor steps on one;
- Visual Studio's Intellisense would suggest you which filters expressions are available, thus not having to check the LDAP query filter expression's syntax definition every now and then;
- there was input validation, so that you didn't need to write code in order to get some characters properly escaped if need be;

So you write a simple library wrapping the LDAP query filter expressions in a .NET hierarchy exposing an API such as the following:
```C#
((Ldap.Attribute("name").Equals("John") & Ldap.Attribute("surname").Equals("Doe"))
  | Ldap.Attribute("email").EndsWith("@company.com")) 
& Ldap.Attribute("age").IsGreaterThanOrEqualTo("18")
```
...then it occurs to you that you could override some more operators and obtain an even more familiar API:
```C#
((Ldap.Attribute("name") == "John" & Ldap.Attribute("surname") == "Doe")
  | Ldap.Attribute("email").EndsWith("@company.com")) 
& Ldap.Attribute("age") >= "18"
```
you think someone else might find it useful, and upload it on GitHub.
## Remark
This library aims at making working with LDAP query filter expressions easier in situations where you cannot afford to replace the data access object model currently in use. (e.g. the System.DirectoryServices classes)
If you are planning a wider refactoring you might consider using some more complex libraries such as LINQ to LDAP, (see https://linqtoldap.codeplex.com/ ) which already addresses some of the issues this library does.
