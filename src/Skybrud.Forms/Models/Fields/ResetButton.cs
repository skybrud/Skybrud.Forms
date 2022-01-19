namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Initializes a new <c>submit</c> button.
    /// </summary>
    public class ResetButton : ButtonBase {

        /// <summary>
        /// Gets the type of buttons based on <see cref="ResetButton"/>.
        /// </summary>
        protected const string FieldType = "reset";

        #region Constructors

        /// <summary>
        /// Initializes a new reset button with default values.
        /// </summary>
        public ResetButton() : base(FieldType) { }

        /// <summary>
        /// Initializes a new reset button with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        public ResetButton(string name, string label) : base(FieldType, name, label) { }

        /// <summary>
        /// Initializes a new reset button with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        public ResetButton(string name, string label, object value) : base(FieldType, name, label, value) { }

        #endregion

    }

}