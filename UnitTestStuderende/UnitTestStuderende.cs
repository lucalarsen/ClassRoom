using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassRoom;

namespace UnitTestStuderende
{
    [TestClass]
    public class UnitTestStuderende
    {
        [DataTestMethod]
        [DataRow(12)]
        [DataRow(1)]
        [DataRow(2)]
        public void TestMethodStuderende(int value)
        {
            //Arrange
            studerende studerende = new studerende("test", value, 1);

            //Act
            string �rstid = studerende.�rstid();

            //Assert
            Assert.AreEqual("Vinter", �rstid);

        }
        [TestMethod]
        public void TestMethodThrow()
        {
            //Arrange
            studerende studerende = new studerende("test", 13, 1);

            //Act 
            string �rstid = studerende.�rstid();

            //Assert
            Assert.Fail();
        }
    }
}
