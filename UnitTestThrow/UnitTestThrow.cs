using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;
namespace UnitTestThrow
{
    [TestClass]
    public class UnitTestThrow
    {
        [TestMethod]
        public void TestMethodThrow()
        {
            //Arrange
            studerende studerende = new studerende("test", 13, 1);

            //Act 
            string årstid = studerende.Årstid();

            //Assert
            Assert.Fail();
        }

    }
}
