using Skybrud.Forms.Models.Fields.Input;

namespace Skybrud.Forms.Models.Fields.CheckBox {

    /// <summary>
    /// Class representing a HTML <c>checkbox</c> field.
    /// </summary>
    public class CheckBox : InputField {

        public CheckBox() : base("checkbox") { }

        public CheckBox(string name, string value) : base("checkbox") {
            Name = name;
            Value = value;
        }

    }

}