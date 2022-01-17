using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>checkbox</c> field.
    /// </summary>
    public class Checkbox : InputField {

        [JsonProperty("checked")]
        public bool IsChecked { get; set; }

        public Checkbox() : base("checkbox") { }

        public Checkbox(string name, string value) : base("checkbox") {
            Name = name;
            Value = value;
        }

        public Checkbox(string name, string value, bool isChecked) : base("checkbox") {
            Name = name;
            Value = value;
            IsChecked = isChecked;
        }

    }

}