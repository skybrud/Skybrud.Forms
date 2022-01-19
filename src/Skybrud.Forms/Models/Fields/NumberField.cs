using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {
    
    /// <summary>
    /// Class representing a HTML <c>number</c> field.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number</cref>
    /// </see>
    public class NumberField : InputField {
        
        /// <summary>
        /// Gets the type of buttons based on <see cref="NumberField"/>.
        /// </summary>
        protected const string FieldType = "number";

        #region Properties

        /// <summary>
        /// Gets or sets the minimum value allowed for the value of this field.
        /// 
        /// If the value of the element is less than this, the element fails constraint validation. If a value is
        /// specified for <see cref="Min"/> that isn't a valid number, the input has no minimum value.
        /// 
        /// This value must be less than or equal to the value of the <see cref="Max"/> property.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number#min</cref>
        /// </see>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public int? Min { get; set; }

        /// <summary>
        /// Gets or sets the maximum value allowed for the value of this field.
        /// 
        /// If the value entered into the element exceeds this, the element fails constraint validation. If the value of the max attribute isn't a number, then the element has no maximum value.
        /// 
        /// This value must be greater than or equal to the value of the <see cref="Min"/> property.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number#max</cref>
        /// </see>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public int? Max { get; set; }

        /// <summary>
        /// Gets or sets the vlue of this fields <c>step</c> attribute.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number#step</cref>
        /// </see>
        [JsonProperty("step", NullValueHandling = NullValueHandling.Ignore)]
        public int? Step { get; set; }

        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new, empty <c>number</c> input field.
        /// </summary>
        public NumberField() : base(FieldType) { }
        
        /// <summary>
        /// Initializes a new <c>email</c> input field with the specified <paramref name="name"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        public NumberField(string name) : base(FieldType) {
            Name = name;
        }

        /// <summary>
        /// Initializes a new <c>number</c> input field with the specified <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        public NumberField(string name, string label) : base(FieldType) {
            Name = name;
            Label = label;
        }

        /// <summary>
        /// Initializes a new <c>number</c> input field with the specified <paramref name="name"/>, <paramref name="label"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        public NumberField(string name, string label, object value) : base(FieldType) {
            Name = name;
            Label = label;
            Value = value;
        }

        #endregion

    }

}