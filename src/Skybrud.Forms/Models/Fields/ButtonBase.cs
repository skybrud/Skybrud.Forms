namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Abstract class serving as a common base for button based fields like <see cref="Button"/>, <see cref="ResetButton"/> and <see cref="SubmitButton"/>.
    /// </summary>
    public abstract class ButtonBase : FieldBase {

        #region Constructors

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        protected ButtonBase(string type) : base(type, null, null) { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/>, <paramref name="name"/> and
        /// <paramref name="label"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        protected ButtonBase(string type, string name, string label) : base(type, name, label) { }

        /// <summary>
        /// Initializes a new instance with the specified <paramref name="type"/>, <paramref name="name"/>,
        /// <paramref name="label"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        protected ButtonBase(string type, string name, string label, object value) : base(type, name, label, value) { }

        #endregion

    }

}