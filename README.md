# How this project was created

This was created using the instructions at https://xunit.net/docs/getting-started/netfx/cmdline

```
mkdir emailaddr 
cd emailaddr
dotnet new sln
dotnet new xunit
dotnet sln add .
```

# Run tests

If you have the DotNet framework installed, you should be able to run the tests from the command line in your shell:

```
dotnet test
```

Alternately, you may want to open the Solution in a suitable IDE (e.g. Rider, Visual Studio, or VS Code) and run the tests from the IDE.

# To Do

Not all invalid e-mail addresses are identified as such -- the algorithm is currently more permissive than it needs to.

There are skipped test in a `[Theory]` that should be made to pass.

The test cases for these skipped tests have been drawn from the [Wikipedia Entry](https://en.wikipedia.org/wiki/Email_address).

# References

1. IETF SMTP standard. [Section 4.1.2](https://datatracker.ietf.org/doc/html/rfc5321#section-4.1.2) defines the standard for e-mail addresses (i.e. Mailbox): https://datatracker.ietf.org/doc/html/rfc5321
2. xUnit: https://xunit.net/
3. C# Regular expressions: https://www.tutorialspoint.com/csharp/csharp_regular_expressions.htm
