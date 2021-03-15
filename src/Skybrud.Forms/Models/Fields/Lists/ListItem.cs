using System;
using System.ComponentModel;
using Newtonsoft.Json;
using Skybrud.Essentials.Reflection.Extensions;
using Skybrud.Essentials.Strings.Extensions;

namespace Skybrud.Forms.Models.Fields.Lists{
    
    public class ListItem {

        #region Properties

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("checked")]
        public bool IsChecked { get; set; }

        #endregion

        #region Constructors

        public ListItem(int value, string label) {
            Value = value.ToString();
            Label = label;
        }

        public ListItem(int value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        public ListItem(Guid value, string label) {
            Value = value.ToString();
            Label = label;
        }

        public ListItem(Guid value, string label, bool isChecked) {
            Value = value.ToString();
            Label = label;
            IsChecked = isChecked;
        }

        public ListItem(string value, string label) {
            Value = value;
            Label = label;
        }

        public ListItem(string value, string label, bool isChecked) {
            Value = value;
            Label = label;
            IsChecked = isChecked;
        }

        public ListItem(Enum value) {
            Value = value.ToCamelCase();
            Label = value.HasCustomAttribute(out DescriptionAttribute result) ? result.Description : value.ToString();
        }

        public ListItem(Enum value, bool isChecked) : this(value) {
            IsChecked = isChecked;
        }

        #endregion

    }

}