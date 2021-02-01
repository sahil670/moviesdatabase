using Microsoft.VisualStudio.TestTools.UnitTesting;
using moviesdatabase;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Database obj = new Database();
        [TestMethod]
        public void TestMethod1()
        {
            var actString =
                @"Data Source=SYSTEM\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True;Connect Timeout=30";
            var expString = obj.connectionString;
            Assert.AreEqual(actString, expString);
        }
    }
}
