using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Docs.Components.MSTest
{
  [TestClass]
  public class HelloHelloWorldImplicitContextTest : BunitTestContext
  {
    [TestMethod]
    public void HelloWorldComponentRendersCorrectly()
    {
      // Act
      var cut = RenderComponent<HelloWorld>();

      // Assert
      cut.MarkupMatches("<h1>Hello world from Blazor</h1>");
    }
  }
}