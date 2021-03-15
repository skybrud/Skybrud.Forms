using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields{

    public class FieldBase {

        #region Properties

        [JsonProperty("type", Order = -99, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; }

        [JsonProperty("name", Order = -98, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("label", Order = -97, NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("description", Order = -96, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("required", Order = -95, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsRequired { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore, Order = 500)]
        public object Value { get; set; }

        #endregion

        #region Constructors

        public FieldBase(string type) {
            Type = type;
        }

        public FieldBase(string type, string name) {
            Type = type;
            Name = name;
        }

        public FieldBase(string type, string name, object value) {
            Type = type;
            Name = name;
            Value = value;
        }

        #endregion

    }

}