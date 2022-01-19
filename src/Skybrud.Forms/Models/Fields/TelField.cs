namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>tel</c> input field.
    /// </summary>
    public class TelField : InputField {
        
        /// <summary>
        /// Gets the type of buttons based on <see cref="TelField"/>.
        /// </summary>
        protected const string FieldType = "tel";

        #region Constructors
        
        /// <summary>
        /// Initializes a new, empty <c>text</c> input field.
        /// </summary>
        public TelField() : base(FieldType) { }
        
        /// <summary>
        /// Initializes a new <c>tel</c> input field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name.</param>
        public TelField(string name)  : base(FieldType) {
            Name = name;
        }
        
        /// <summary>
        /// Initializes a new <c>tel</c> input field with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        public TelField(string name, string label) : base(FieldType) {
            Name = name;
            Label = label;
        }

        /// <summary>
        /// Initializes a new <c>tel</c> input field with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        public TelField(string name, string label, object value) : base(FieldType)  {
            Name = name;
            Label = label;
            Value = value;
        }

        #endregion

    }

}