
# Mimicry

<code>ˈmiməkrē<code>
<i>the action or art of imitating someone or something, typically in order to entertain or ridicule.</i>
Lovey small project made in an evening to create something useful.

## Embedded webserver for mocking/mimicing your data

Can run in the commandline:
<code>
	dotnet mimicry.server.dll
</code>
or embedded in your unittests.
<code>
[Fact]
public void E2ETestSmallOk()
{
    using (var server = new EmbeddedServer("/foo", "bar"))
    {
        using (var client = new WebClient())
        {
            var foo = client.DownloadString(server.BaseUrl + "/foo");

            Assert.NotNull(foo);
            Assert.Equal("bar", foo);
        }
    }
}
</code>

# Why
Don't want to pay for online mocking services...

## Todo's

## too many...
- Dependency Injection
- Headers
- Soap... classic but still in use
- Console parameter parsing
- Create NuGet package
- Authentication mocking
- Testing Testing Testing
- Admin panel for creating SQLite db with preloaded and transferable data
- Imports
- Exports
- Reports
- more lovely features

# Help

Help is always welcome, make a pull request or [email me](mailto://martijn@vaandering.net)