using Newtonsoft.Json;
using Skybrud.Forms.Models;

namespace TestProject1 {

    [TestClass]
    public class FormTests {

        [TestMethod]
        public void EmptyForm() {

            Form form = new();

            string actual1 = JsonConvert.SerializeObject(form, Formatting.None);

            Assert.AreEqual("{\"fields\":[]}", actual1, "#1");

        }

        [TestMethod]
        public void WithMethodAndAction() {

            Form form = new() {
                Method = "POST",
                Action = "/api/save"
            };

            string actual1 = JsonConvert.SerializeObject(form, Formatting.None);

            Assert.AreEqual("{\"method\":\"POST\",\"action\":\"/api/save\",\"fields\":[]}", actual1, "#1");

        }

    }

}