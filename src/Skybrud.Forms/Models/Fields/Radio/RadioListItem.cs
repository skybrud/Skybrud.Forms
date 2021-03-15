using System;
using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields.Radio{
    public class RadioListItem {

        #region Properties

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("checked")]
        public bool IsChecked { get; set; }

        #endregion

        #region Constructors

        public RadioListItem(int value, string label) {
            Value = value.ToString();
            Label = label;
        }

        public RadioListItem(int value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        public RadioListItem(Guid value, string label) {
            Value = value.ToString();
            Label = label;
        }

        public RadioListItem(Guid value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        public RadioListItem(string value, string label) {
            Value = value;
            Label = label;
        }

        public RadioListItem(string value, string label, bool isChecked) {
            Value = value;
            Label = label;
            IsChecked = isChecked;
        }

        #endregion

    }

}