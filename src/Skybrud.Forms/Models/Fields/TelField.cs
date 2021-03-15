namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>tel</c> field.
    /// </summary>
    public class TelField : InputField {

        protected const string FieldType = "tel";

        #region Constructors

        public TelField() : base(FieldType) { }

        public TelField(string name) : base(FieldType, name) { }

        public TelField(string name, string value) : base(FieldType, name, value) { }

        #endregion

    }

}