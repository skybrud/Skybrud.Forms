using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {

    public abstract class InputField : FieldBase {

        #region Properties

        [JsonProperty("placeholder", NullValueHandling = NullValueHandling.Ignore)]
        public string Placeholder { get; set; }

        /// <see>
        ///     <cref>https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/pattern</cref>
        /// </see>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        #endregion

        #region Constructors

        protected InputField(string type) : base(type, null, null) { }

        protected InputField(string type, string name) : base(type, name) { }

        protected InputField(string type, string name, string value) : base(type, name, value) { }

        #endregion

    }

}