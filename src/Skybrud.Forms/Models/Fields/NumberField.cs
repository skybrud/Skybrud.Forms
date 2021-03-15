using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields {

    /// <summary>
    /// Class representing a HTML <c>number</c> field.
    /// </summary>
    public class NumberField : InputField {

        #region Properties

        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public int? Min { get; set; }

        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public int? Max { get; set; }

        #endregion

        #region Constructors

        public NumberField() : base("number") { }

        #endregion

    }

}