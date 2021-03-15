using System.Collections.Generic;
using Newtonsoft.Json;
using Skybrud.Forms.Models.Fields;
using Skybrud.Forms.Models.Fields.Buttons;
using Skybrud.Forms.Models.Fields.CheckBox;
using Skybrud.Forms.Models.Fields.Input;
using Skybrud.Forms.Models.Fields.Lists;
using Skybrud.Forms.Models.Fields.Radio;

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

        #region Member methods

        public Form SetTitle(string title) {
            Title = title;
            return this;
        }

        public Form AddField(FieldBase field) {
            Fields.Add(field);
            return this;
        }

        public Form AddField(string type, string name, object value) {
            Fields.Add(new FieldBase(type, name, value));
            return this;
        }

        public Form AddHiddenField(string name, object value) {
            Fields.Add(new HiddenField(name, value));
            return this;
        }

        public Form AddEmailField(string name, string value = null, string placeholder = null, string label = null, bool required = false) {
            Fields.Add(new EmailField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                IsRequired = required
            });
            return this;
        }

        public Form AddTextField(string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? size = null, bool required = false) {
            Fields.Add(new TextField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                Size = size,
                IsRequired = required
            });
            return this;
        }

        public Form AddTextarea(string name, string value = null, string placeholder = null, string label = null, string pattern = null, int? size = null, bool required = false) {
            Fields.Add(new TextArea {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                Size = size,
                IsRequired = required
            });
            return this;
        }

        public Form AddTelField(string name, string value = null, string placeholder = null, string label = null, string pattern = null, bool required = false) {
            Fields.Add(new TelField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                IsRequired = required
            });
            return this;
        }

        public Form AddNumberField(string name, string value = null, string placeholder = null,
            string label = null, string pattern = null, int? min = null, int? max = null, int? size = null, bool required = false) {

            Fields.Add(new NumberField {
                Name = name,
                Value = value,
                Placeholder = placeholder,
                Label = label,
                Pattern = pattern,
                Min = min,
                Max = max,
                Size = size,
                IsRequired = required
            });

            return this;

        }

        public Form AddRadioGroup(string name, IEnumerable<ListItem> value) {
            Fields.Add(new RadioList(name, value));
            return this;
        }

        public Form AddRadioGroup(string name, params ListItem[] value) {
            Fields.Add(new RadioList(name, value));
            return this;
        }

        public Form AddRadioGroup(string name, string label, IEnumerable<ListItem> value) {
            Fields.Add(new RadioList(name, label, value));
            return this;
        }

        public Form AddRadioGroup(string name, string label, params ListItem[] value) {
            Fields.Add(new RadioList(name, label, value));
            return this;
        }

        public Form SetUrl(string url) {
            Url = url;
            return this;
        }

        public Form AddCheckbox(string name, string value = null, string label = null, bool required = false, string description = null) {
            Fields.Add(new CheckBox(name, value)  {
                Label = label,
                IsRequired = required,
                Description = description
            });
            return this;
        }

        public Form AddButton(string label) {
            Fields.Add(new Button { Label = label });
            return this;
        }

        public Form AddResetButton(string label) {
            Fields.Add(new ResetButton { Label = label });
            return this;
        }

        public Form AddSubmitButton(string label) {
            Fields.Add(new SubmitButton { Label = label });
            return this;
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