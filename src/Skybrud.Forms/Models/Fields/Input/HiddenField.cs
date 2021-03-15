namespace Skybrud.Forms.Models.Fields.Input {

    /// <summary>
    /// Class representing a HTML <c>input</c> field with type <c>hidden</c>.
    /// </summary>
    public class HiddenField : InputField {

        protected const string FieldType = "hidden";

        #region Constructors

        public HiddenField() : base(FieldType) { }

        public HiddenField(string name) : base(FieldType) {
            Name = name;
        }

        public HiddenField(string name, object value) : base(FieldType) {
            Name = name;
            Value = value;
        }

        #endregion

    }

}