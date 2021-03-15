using System;
using Newtonsoft.Json;

namespace Skybrud.Forms.Models.Fields.DropDown{
    public class DropDownItem {

        #region Properties

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("checked")]
        public bool IsChecked { get; set; }

        #endregion

        #region Constructors

        public DropDownItem(int value, string label) {
            Value = value.ToString();
            Label = label;
        }

        public DropDownItem(int value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        public DropDownItem(Guid value, string label) {
            Value = value.ToString();
            Label = label;
        }

        public DropDownItem(Guid value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        public DropDownItem(string value, string label) {
            Value = value;
            Label = label;
        }

        public DropDownItem(string value, string label, bool isChecked) {
            Value = value;
            Label = label;
            IsChecked = isChecked;
        }

        #endregion

    }

}