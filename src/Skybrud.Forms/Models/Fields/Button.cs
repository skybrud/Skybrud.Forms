namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Initializes a new <c>button</c> button.
    /// </summary>
    public class Button : ButtonBase {

        /// <summary>
        /// Gets the type of buttons based on <see cref="Button"/>.
        /// </summary>
        protected const string FieldType = "button";

        #region Constructors

        /// <summary>
        /// Initializes a new button with default values.
        /// </summary>
        public Button() : base(FieldType) { }

        /// <summary>
        /// Initializes a new button with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        public Button(string name, string label) : base(FieldType, name, label) { }

        /// <summary>
        /// Initializes a new button with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="name">The name of the button.</param>
        /// <param name="label">The label of the button.</param>
        /// <param name="value">The value of the button.</param>
        public Button(string name, string label, object value) : base(FieldType, name, label, value) { }

        #endregion

    }

}