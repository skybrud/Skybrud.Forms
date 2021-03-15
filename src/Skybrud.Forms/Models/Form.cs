using System.Collections.Generic;
using Newtonsoft.Json;
using Skybrud.Forms.Models.Fields;

namespace Skybrud.Forms.Models {
	
    public class Form {

        #region Properties

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("endpointUrl")]
        public string EndpointUrl { get; set; }

        [JsonProperty("fields")]
        public List<FieldBase> Fields { get; set; }

        #endregion

        #region Constructors

        public Form() {
            Fields = new List<FieldBase>();
        }

        public Form(string endpointUrl) {
            EndpointUrl = endpointUrl;
            Fields = new List<FieldBase>();
        }

        #endregion

        #region Static methods

        public static Form New() {
            return new Form();
        }

        public static Form New(string endpointUrl) {
            return new Form(endpointUrl);
        }

        #endregion

    }

}