using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Abstract class representing an <c>&lt;input&gt;</c> field.
    /// </summary>
    public abstract class InputField : FieldBase {

        #region Properties

        /// <summary>
        /// The <c>placeholder</c> attribute is a string that provides a brief hint to the user as to what kind of
        /// information is expected in the field. It should be a word or short phrase that provides a hint as to the
        /// expected type of data, rather than an explanation or prompt. The text must not include carriage returns or
        /// line feeds. So for example if a field is expected to capture a user's first name, and its label is
        /// "First Name", a suitable placeholder might be "e.g. Mustafa".
        /// </summary>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#attr-placeholder</cref>
        /// </see>
        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string? Placeholder { get; set; }

        /// <summary>
        /// The pattern attribute, when specified, is a regular expression that the input's value must match in order
        /// for the value to pass constraint validation.
        ///
        /// If the <c>pattern</c> is present but is not specified or is invalid, no regular expression is applied and
        /// this attribute is ignored completely. If the pattern attribute is valid and a non-empty value does not
        /// match the pattern, constraint validation will prevent form submission.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#attr-pattern</cref>
        /// </see>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string? Pattern { get; set; }

        /// <summary>
        /// Gets or sets the size of the input field. Valid for <c>email</c>, <c>password</c>, <c>tel</c>, <c>url</c>
        /// and <c>text</c> input types only. Specifies how much of the input is shown. Basically creates same result
        /// as setting CSS width property with a few specialities.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input#attr-size</cref>
        /// </see>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new, empty input field.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        protected InputField(string type) : base(type) { }

        /// <summary>
        /// Initializes a new input field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        protected InputField(string type, string name) : base(type, name) { }

        /// <summary>
        /// Initializes a new input field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        protected InputField(string type, string name, string? label) : base(type, name, label) { }

        /// <summary>
        /// Initializes a new input field with the specified <paramref name="name"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        protected InputField(string type, string name, string? label, object? value) : base(type, name, label, value) { }

        #endregion

    }

}