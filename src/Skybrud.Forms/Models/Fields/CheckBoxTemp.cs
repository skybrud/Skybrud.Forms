namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>checkbox</c> field.
    /// </summary>
    public class CheckBoxTemp : InputField {

        public CheckBoxTemp() : base("checkbox") { }

        public CheckBoxTemp(string name, string value) : base("checkbox") {
            Name = name;
            Value = value;
        }

    }

}