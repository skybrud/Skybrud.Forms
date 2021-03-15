namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>text</c> field.
    /// </summary>
    public class TextField : InputField {

        protected const string FieldType = "text";

        #region Constructors

        public TextField() : base(FieldType) { }

        public TextField(string name) : base(FieldType, name) { }

        public TextField(string name, string value) : base(FieldType, name, value) { }

        #endregion

    }

}