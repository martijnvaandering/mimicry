using Mimicry.Server;
using System.Net;
using System.Net.Mime;
using Xunit;

namespace Mimicry.Tests
{
    public class E2ETests
    {
        [Fact]
        public void E2ETestOk()
        {
            using (var server = new EmbeddedServer(new DefaultDefinitionLoader(new DefaultMimicDefinition("/foo", "bar", new ContentType("text/plain"))),999))
            {
                using (var client = new WebClient())
                {
                    var foo = client.DownloadString(server.BaseUrl + "/foo");

                    Assert.NotNull(foo);
                    Assert.Equal("bar", foo);
                }
            }
        }

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

        [Fact]
        public void E2ETestHitUndefined()
        {
            using (var server = new EmbeddedServer("/foo", "bar"))
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        var foo = client.DownloadString(server.BaseUrl + "/bla");
                    }
                    catch (WebException wex)
                    {
                        Assert.Equal(HttpStatusCode.NotImplemented, (wex.Response as HttpWebResponse).StatusCode);
                    }
                    Assert.True(server.HitUndefinedUrl);
                }
            }
        }

        [Fact]
        public void CheckIfFavIconIsServed()
        {
            using (var server = new EmbeddedServer("/foo", "bar"))
            {
                using (var client = new WebClient())
                {

                    var foo = client.DownloadData(server.BaseUrl + "/favicon.ico");
                    Assert.NotNull(foo);
                }
            }
        }
    }
}
