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

        protected const string FieldType = "textarea";

        #region Properties

        /// <summary>
        /// The number of visible text lines for the control.
        /// </summary>
        [JsonProperty("rows", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rows { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize a new textarea field.
        /// </summary>
        public TextArea() : base(FieldType) { }

        public TextArea(string name) : base(FieldType, name) { }

        public TextArea(string name, string value) : base(FieldType, name, value) { }

        #endregion

    }

}