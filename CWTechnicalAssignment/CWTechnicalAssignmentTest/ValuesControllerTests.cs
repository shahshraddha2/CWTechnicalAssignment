using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CWTechnicalAssignmentTest
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void TestInitilization()
        {
            CWTechnicalAssignment.Controllers.ValuesController valuesController = new CWTechnicalAssignment.Controllers.ValuesController(new CWTechnicalAssignment.Data.StaticHelloWorldRepository());
            Assert.IsNotNull(valuesController);
        }

        [TestMethod]
        public void TestGet()
        {
            CWTechnicalAssignment.Controllers.ValuesController valuesController = new CWTechnicalAssignment.Controllers.ValuesController(new CWTechnicalAssignment.Data.StaticHelloWorldRepository());
            var result = valuesController.Get();
            Assert.AreEqual("Hello World", result);
        }


        [TestMethod]
        public void TestPost()
        {
            CWTechnicalAssignment.Controllers.ValuesController valuesController = new CWTechnicalAssignment.Controllers.ValuesController(new CWTechnicalAssignment.Data.StaticHelloWorldRepository());
            valuesController.Post("Hi");
            Assert.IsNotNull(valuesController);
        }
    }
}
