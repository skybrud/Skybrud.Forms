using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {
    
    /// <summary>
    /// The HTML <c>&lt;textarea&gt;</c> element represents a multi-line plain-text editing control, useful when you
    /// want to allow users to enter a sizeable amount of free-form text, for example a comment on a review or feedback
    /// form.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/textarea</cref>
    /// </see>
    public class TextArea : InputField {
        
        /// <summary>
        /// Gets the type of buttons based on <see cref="TextArea"/>.
        /// </summary>
        protected const string FieldType = "textarea";

        #region Properties

        /// <summary>
        /// The number of visible text lines for the control.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/textarea#attr-rows</cref>
        /// </see>
        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rows { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize a new <c>&lt;textarea&gt;</c> field.
        /// </summary>
        public TextArea() : base(FieldType) { }

        /// <summary>
        /// Initializes a new <c>&lt;textarea&gt;</c> input field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        public TextArea(string name) : base(FieldType) {
            Name = name;
        }
        
        /// <summary>
        /// Initializes a new <c>&lt;textarea&gt;</c> input field with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        public TextArea(string name, string label) : base(FieldType) {
            Name = name;
            Label = label;
        }

        /// <summary>
        /// Initializes a new <c>&lt;textarea&gt;</c> input field with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        public TextArea(string name, string label, object value) : base(FieldType)  {
            Name = name;
            Label = label;
            Value = value;
        }

        #endregion

    }

}