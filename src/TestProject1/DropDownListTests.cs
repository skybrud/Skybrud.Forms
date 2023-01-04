using Newtonsoft.Json;
using Skybrud.Forms.Models;
using Skybrud.Forms.Models.Fields;

namespace TestProject1 {

    [TestClass]
    public class DropDownListTests {

        [TestMethod]
        public void SetPlaceholder() {

            var form = new Form();

            var ddl = new DropDownList("hello")
                .SetPlaceholder("Hello")
                .AppendTo(form);

            const string expected1 = """
                                     {
                                       "fields": [
                                         {
                                           "type": "dropdown",
                                           "name": "hello",
                                           "placeholder": "Hello",
                                           "items": []
                                         }
                                       ]
                                     }
                                     """;
            string actual1 = JsonConvert.SerializeObject(form, Formatting.Indented);

            Assert.AreEqual(expected1, actual1, "#1");

            ddl.SetPlaceholder(null);

            const string expected2 = """
                                     {
                                       "fields": [
                                         {
                                           "type": "dropdown",
                                           "name": "hello",
                                           "items": []
                                         }
                                       ]
                                     }
                                     """;

            string actual2 = JsonConvert.SerializeObject(form, Formatting.Indented);

            Assert.AreEqual(expected2, actual2, "#2");

        }

    }

}