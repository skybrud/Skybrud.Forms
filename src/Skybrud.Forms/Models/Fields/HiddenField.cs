namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>input</c> field with type <c>hidden</c>.
    /// </summary>
    public class HiddenField : InputField {
        
        /// <summary>
        /// Gets the type of buttons based on <see cref="HiddenField"/>.
        /// </summary>
        protected const string FieldType = "hidden";

        #region Constructors

        /// <summary>
        /// Initializes a new <c>hidden</c> field with default values.
        /// </summary>
        public HiddenField() : base(FieldType) { }
        
        /// <summary>
        /// Initializes a new <c>hidden</c> field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        public HiddenField(string name) : base(FieldType) {
            Name = name;
        }
        
        /// <summary>
        /// Initializes a new <c>hidden</c> field with the specified <paramref name="name"/> and <paramref name="value"/>..
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="value">The value of the field.</param>
        public HiddenField(string name, object value) : base(FieldType) {
            Name = name;
            Value = value;
        }

        #endregion

    }

}