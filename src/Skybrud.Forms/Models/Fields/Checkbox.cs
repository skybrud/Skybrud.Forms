using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>checkbox</c> field.
    /// </summary>
    public class Checkbox : InputField {

        #region Properties

        /// <summary>
        /// Gets or sets whether the checkbox should initially be checked.
        /// </summary>
        [JsonProperty("checked")]
        public bool IsChecked { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new <c>checkbox</c> field with default options.
        /// </summary>
        public Checkbox() : base("checkbox") { }

        /// <summary>
        /// Initializes a new <c>checkbox</c> field with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        public Checkbox(string name, string? label) : base("checkbox") {
            Name = name;
            Label = label;
        }

        /// <summary>
        /// Initializes a new <c>checkbox</c> field with the specified <paramref name="name"/>, <paramref name="label"/>
        /// and <paramref name="value"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        public Checkbox(string name, string? label, object? value) : base("checkbox") {
            Name = name;
            Label = label;
            Value = value;
        }

        /// <summary>
        /// Initializes a new <c>checkbox</c> field with the specified <paramref name="name"/>, <paramref name="label"/>
        /// and <paramref name="value"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        /// <param name="isChecked">Whether the field should initially be checked.</param>
        public Checkbox(string name, string? label, object? value, bool isChecked) : base("checkbox") {
            Name = name;
            Label = label;
            Value = value;
            IsChecked = isChecked;
        }

        #endregion

    }

}