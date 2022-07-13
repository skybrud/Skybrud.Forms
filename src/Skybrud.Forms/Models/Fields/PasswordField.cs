namespace Skybrud.Forms.Models.Fields {

    public class PasswordField : InputField {

        protected const string FieldType = "password";

        #region Constructors

        /// <summary>
        /// Initializes a new, empty <c>password</c> input field.
        /// </summary>
        public PasswordField() : base(FieldType) { }

        /// <summary>
        /// Initializes a new <c>password</c> input field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name.</param>
        public PasswordField(string name) : base(FieldType) {
            Name = name;
        }

        /// <summary>
        /// Initializes a new <c>password</c> input field with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        public PasswordField(string name, string label) : base(FieldType) {
            Name = name;
            Label = label;
        }

        /// <summary>
        /// Initializes a new <c>password</c> input field with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        public PasswordField(string name, string label, object value) : base(FieldType) {
            Name = name;
            Label = label;
            Value = value;
        }

        #endregion

    }

}