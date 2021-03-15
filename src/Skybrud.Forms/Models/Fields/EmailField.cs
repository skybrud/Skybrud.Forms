namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>email</c> field.
    /// </summary>
    public class EmailField : InputField {

        protected const string FieldType = "email";

        public EmailField() : base(FieldType) { }

        public EmailField(string name) : base(FieldType, name) { }

        public EmailField(string name, string value) : base(FieldType, name, value) { }

    }

}