using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Skybrud.Forms.Models.Fields;

// ReSharper disable InconsistentNaming

namespace Skybrud.Forms.Models {

    /// <summary>
    /// Class representing a HTML <c>form</c> element.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/form</cref>
    /// </see>
    public class Form {

        #region Properties

        /// <summary>
        /// Gets or sets the name of the form. The value must not be the empty string, and must be unique among the
        /// form elements in the forms collection that it is in, if any. If set to <c>null</c> (default), the property
        /// will be omitted when serializing the form to JSON.
        /// </summary>
        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Element/form#attr-name</cref>
        /// </see>
        [JsonProperty("name", Order = -200, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the title of the form. If set to <c>null</c> (default), the property will be omitted when
        /// serializing the form to JSON.
        /// </summary>
        [JsonProperty("title", Order = -175, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the URL to the endpoint behind the form. This is where the form data should be submitted to
        /// when doing asynchronous postbacks using JavaScript. If set to <c>null</c> (default), the property will be omitted when serializing the form to JSON.
        /// </summary>
        [JsonProperty("endpointUrl", Order = -150, NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointUrl { get; set; }

        /// <summary>
        /// Gets or sets the list of fields making up the form. By default, the property is initialized with an empty
        /// list to which fields can be added.  If set to <c>null</c> (default), the property will be omitted when
        /// serializing the form to JSON.
        /// </summary>
        [JsonProperty("fields", Order = 100, NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldBase> Fields { get; set; }

        /// <summary>
        /// Gets or sets a dictionary representing the labels associated with the form.
        /// </summary>
        [JsonProperty("labels", Order = 150, NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new form with default options.
        /// </summary>
        public Form() {
            Fields = new List<FieldBase>();
            Labels = new Dictionary<string, string>();
        }

        /// <summary>
        /// Initializes a new form based on the specified <paramref name="endpointUrl"/>.
        /// </summary>
        /// <param name="endpointUrl">The endpoint URL.</param>
        public Form(string endpointUrl) {
            EndpointUrl = endpointUrl;
            Fields = new List<FieldBase>();
            Labels = new Dictionary<string, string>();
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Returns whether the <see cref="Labels"/> property should be serialized when converting the form to a JSON string representation.
        /// </summary>
        /// <returns><c>true</c> if the <see cref="Labels"/> property should be serialized, otherwise, <c>false</c>.</returns>
        public bool ShouldSerializeLabels() {
            return Labels is { Count: > 0 };
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Initializes a new form with default options.
        /// </summary>
        /// <returns>An instance of <see cref="Form"/>.</returns>
        public static Form Create() {
            return new Form();
        }

        /// <summary>
        /// Initializes a new form based on the specified <paramref name="endpointUrl"/>.
        /// </summary>
        /// <param name="endpointUrl">The endpoint URL.</param>
        /// <returns>An instance of <see cref="Form"/>.</returns>
        public static Form Create(string endpointUrl) {
            return new Form(endpointUrl);
        }

        /// <summary>
        /// Initializes a new form with default options.
        /// </summary>
        /// <returns>An instance of <see cref="Form"/>.</returns>
        [Obsolete("Use 'Create' method instead.")]
        public static Form New() {
            return new Form();
        }

        /// <summary>
        /// Initializes a new form based on the specified <paramref name="endpointUrl"/>.
        /// </summary>
        /// <param name="endpointUrl">The endpoint URL.</param>
        /// <returns>An instance of <see cref="Form"/>.</returns>
        [Obsolete("Use 'Create' method instead.")]
        public static Form New(string endpointUrl) {
            return new Form(endpointUrl);
        }

        #endregion

    }

}