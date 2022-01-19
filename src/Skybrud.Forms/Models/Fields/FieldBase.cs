using System;
using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields{

    /// <summary>
    /// Abstract class representing a field.
    /// </summary>
    public abstract class FieldBase {

        #region Properties

        /// <summary>
        /// Gets the type of the field.
        /// </summary>
        [JsonProperty("type", Order = -99)]
        public string Type { get; }

        /// <summary>
        /// Gets or sets the name of the field. This will typically be the value for the <c>name</c> attribute of the
        /// HTML element.
        /// </summary>
        /// <remarks>If set to <c>null</c>, this property will be omitted when serializing the field to JSON.</remarks>
        [JsonProperty("name", Order = -98, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the label of the field. This will typically be a user-friendly name of the field - eg. via a
        /// <c>&lt;label&gt;</c> element wrapping the field.
        /// </summary>
        /// <remarks>If set to <c>null</c>, this property will be omitted when serializing the field to JSON.</remarks>
        [JsonProperty("label", Order = -97, NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the description of the field.
        /// </summary>
        /// <remarks>If set to <c>null</c>, this property will be omitted when serializing the field to JSON.</remarks>
        [JsonProperty("description", Order = -96, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether the field is required.
        /// </summary>
        /// <remarks>If set to <c>false</c>, this property will be omitted when serializing the field to JSON.</remarks>
        [JsonProperty("required", Order = -95, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsRequired { get; set; }

        /// <summary>
        /// Gets or sets the value of the field.
        /// </summary>
        /// <remarks>If set to <c>null</c>, this property will be omitted when serializing the field to JSON.</remarks>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore, Order = 500)]
        public object Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new field with the specified <paramref name="type"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        protected FieldBase(string type) {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentNullException(nameof(type));
            Type = type;
        }

        /// <summary>
        /// Initializes a new field with the specified <paramref name="type"/> and <paramref name="name"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        protected FieldBase(string type, string name) {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentNullException(nameof(type));
            Type = type;
            Name = name;
        }
        
        /// <summary>
        /// Initializes a new field with the specified <paramref name="type"/>, <paramref name="name"/> and <paramref name="label"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        protected FieldBase(string type, string name, string label) {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentNullException(nameof(type));
            Type = type;
            Name = name;
            Label = label;
        }
        
        /// <summary>
        /// Initializes a new field with the specified <paramref name="type"/>, <paramref name="name"/> and <paramref name="value"/>.
        /// </summary>
        /// <param name="type">The type of the field.</param>
        /// <param name="name">The name of the field.</param>
        /// <param name="label">The label of the field.</param>
        /// <param name="value">The value of the field.</param>
        protected FieldBase(string type, string name, string label, object value) {
            if (string.IsNullOrWhiteSpace(type)) throw new ArgumentNullException(nameof(type));
            Type = type;
            Name = name;
            Label = label;
            Value = value;
        }

        #endregion

    }

}