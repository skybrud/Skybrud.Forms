using Skybrud.Forms.Models.Fields;

namespace TestProject1 {

    [TestClass]
    public class DateFieldTests {

        [TestMethod]
        public void ValidateType() {

            var field = new DateField();

            Assert.AreEqual("date", field.Type);

        }

    }

}