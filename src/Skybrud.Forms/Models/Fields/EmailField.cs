namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>email</c> field.
    /// </summary>
    public class EmailField : InputField {
        
        /// <summary>
        /// Gets the type of buttons based on <see cref="EmailField"/>.
        /// </summary>
        protected const string FieldType = "email";

        #region Constructors
        
        /// <summary>
        /// Initializes a new <c>email</c> field with default values.
        /// </summary>
        public EmailField() : base(FieldType) { }

        /// <summary>
        /// Initializes a new <c>email</c> input field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        public EmailField(string name) : base(FieldType) {
            Name = name;
        }
        
        /// <summary>
        /// Initializes a new <c>email</c> input field with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        public EmailField(string name, string label) : base(FieldType) {
            Name = name;
            Label = label;
        }

        /// <summary>
        /// Initializes a new <c>email</c> input field with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        public EmailField(string name, string label, object value) : base(FieldType)  {
            Name = name;
            Label = label;
            Value = value;
        }

        #endregion

    }

}