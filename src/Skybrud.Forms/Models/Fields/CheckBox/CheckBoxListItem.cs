using System;
using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields.CheckBox{
    
    public class CheckBoxListItem {

        #region Properties

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("checked")]
        public bool IsChecked { get; set; }

        #endregion

        #region Constructors

        public CheckBoxListItem(int value, string label) {
            Value = value.ToString();
            Label = label;
        }

        public CheckBoxListItem(int value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        public CheckBoxListItem(Guid value, string label) {
            Value = value.ToString();
            Label = label;
        }

        public CheckBoxListItem(Guid value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        public CheckBoxListItem(string value, string label) {
            Value = value;
            Label = label;
        }

        public CheckBoxListItem(string value, string label, bool isChecked) {
            Value = value;
            Label = label;
            IsChecked = isChecked;
        }

        #endregion

    }

}