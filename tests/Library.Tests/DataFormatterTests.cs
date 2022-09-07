using TestDateFormat;
namespace Library.Tests;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormatTest()
    {
        string testDate = "10/11/1997";
        string testDateFormat = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual("1997-11-10", testDateFormat);
    }
    [Test]
    public void IncorrectFormatTest()
    {
        string testDate = "10 11 1997";
        string testDateFormat = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual("1997-11-10", testDateFormat);
    }
    [Test]
    public void WhitespaceORNullTest()
    {
        string testDate = "";
        string testDateFormat = DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual("", testDateFormat);
    }


}