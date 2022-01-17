namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>checkbox</c> field.
    /// </summary>
    public class Checkbox : InputField {

        public Checkbox() : base("checkbox") { }

        public Checkbox(string name, string value) : base("checkbox") {
            Name = name;
            Value = value;
        }

    }

}